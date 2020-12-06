using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RZD
{
    public partial class UserBuyForm : Form
    {
        private int id;
        private OleDbConnection cn;
        private int id_tt;
        OleDbDataAdapter dAdapter;
        private string from;
        private string to;
        private string deptime;
        private int price;


        public UserBuyForm(int id, OleDbConnection cn, int id_tt, string name, string from, string to, string deptime, int price)
        {
            InitializeComponent();
            Name = name;
            this.from = from;
            this.to = to;
            this.deptime = deptime;
            this.price = price;
            this.id = id;
            this.cn = cn;
            this.id_tt = id_tt;

            label1.Text = "Рейс " + name + " Из " + from + " До " + to + " Время отправления " + deptime;
            UpdateTablePassDate();
        }

        private void UpdateTablePassDate()
        {
            dataSet1.Clear();
            dgv22.AllowUserToAddRows = false;
            dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = new OleDbCommand("GetPssData", cn);
            dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dAdapter.SelectCommand.Parameters.AddWithValue("@Account_Id", this.id);
            dAdapter.Fill(dataSet1);

            dgv22.DataSource = dataSet1.Tables[0];

            dgv22.Columns["Id"].ReadOnly = true;
            dgv22.Columns["Id"].Width = 1;
        }

    private void Buy_Click(object sender, EventArgs e)
    {
        int count_t = dgv22.SelectedRows.Count;
        if (count_t > 0)
        {
            var confirmResult = MessageBox.Show("Подтверждаете покупку " + count_t + " билетов на сумму " +
                                                price * count_t + " рублей?", "Подтвердите",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv22.SelectedRows)
                {
                    OleDbCommand cmd = new OleDbCommand("BuyTicket", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@Account_Id", id);
                    cmd.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                    cmd.Parameters.AddWithValue("@Surname", row.Cells["Surname"].Value);
                    cmd.Parameters.AddWithValue("@FName", row.Cells["FName"].Value);
                    cmd.Parameters.AddWithValue("@TimeTeble_Id", id_tt);
                    cmd.Parameters.AddWithValue("@DestStationName", to);
                    Console.WriteLine(to);
                    cmd.Parameters.AddWithValue("@DepStationName", from);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Билеты куплены. Теперь они у вас на вкладке билетов", "Success", MessageBoxButtons.OK);
            }
        }
    }
  }
}