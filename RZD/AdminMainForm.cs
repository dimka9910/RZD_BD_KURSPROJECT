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
using System.Data.OleDb;

namespace RZD
{
    public partial class AdminMainForm : Form
    {
        private int id;
        private int day_of_week = 1;
        private OleDbConnection cn;

        public AdminMainForm(int id, OleDbConnection cn)
        {
            InitializeComponent();
            numLbl.Text = "";
            day_of_week = 1;
            this.id = id;
            this.cn = cn;
            UpdateAllRoutes();
            FillStationsCb();
            dgv12Clear();
            trainsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            routeNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            NameTTBaseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StationsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StationFirstCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            StationsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            setBtnColor();
            FillRoutesCb();
            FillDgv3();
            FillStationsCb();
            fillTrainsCB();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // 1 я страница//

        private void UpdateAllRoutes()
        {
            dataSet1.Clear();
            dgv1.AllowUserToAddRows = false;
            dgv1.AllowUserToResizeColumns = false;
            OleDbDataAdapter dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = new OleDbCommand("SELECT Name, Stops, Prices, Times FROM Routes", cn);
            dAdapter.Fill(dataSet1);
            dgv1.DataSource = dataSet1.Tables[0];
            for (int c_ = 0; c_ < dgv1.Columns.Count; c_++)
            {
                dgv1.Columns[c_].ReadOnly = true;
            }

            dgv1.Columns["Stops"].Width = 300;
            dgv1.Columns["Name"].Width = 200;
        }

        private void FillStationsCb()
        {
            StationsCB.Items.Clear();
            StationFirstCB.Items.Clear();
            OleDbCommand IDS = new OleDbCommand("SELECT Name FROM Stations", cn);
            OleDbDataReader rdr = IDS.ExecuteReader();
            while (rdr.Read())
            {
                StationsCB.Items.Add(rdr["Name"]);
                StationFirstCB.Items.Add(rdr["Name"]);
            }
        }

        private void dgv12Clear()
        {
            dgv12.AllowUserToAddRows = false;
            dgv12.AllowUserToResizeColumns = false;
            dgv12.Rows.Clear();
        }

        private void addStationRow()
        {
            int price = 0;
            int time = 0;
            if (Int32.TryParse(PriceTB.Text.ToString(), out price) &&
                Int32.TryParse(TripTimeTB.Text.ToString(), out time) &&
                StationsCB.Text.Length != 0)
            {
                string[] rowData = new string[3];
                rowData[0] = StationsCB.Text;
                rowData[1] = PriceTB.Text.ToString();
                rowData[2] = TripTimeTB.Text.ToString();
                dgv12.Rows.Add(rowData);
            }
        }

        private void CreateNewRoute()
        {
            if (textBox3.Text != "" && StationFirstCB.Text.Length > 0)
            {

                string stops = "";
                string price = "";
                string time = "";
                string last = "";
                foreach (DataGridViewRow row in dgv12.Rows)
                {
                    stops += row.Cells["Station"].Value.ToString() + ',';
                    last = row.Cells["Station"].Value.ToString();
                    price += row.Cells["Price"].Value.ToString() + ',';
                    time += row.Cells["Time"].Value.ToString() + ',';
                }
                Console.WriteLine(stops);

                stops = stops.Remove(stops.Length - 1);
                Console.WriteLine(stops);
                price = price.Remove(price.Length - 1);
                time = time.Remove(time.Length - 1);
                
                OleDbCommand cmd = new OleDbCommand("CreateNewRoute", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@DepStation", StationFirstCB.Text);
                cmd.Parameters.AddWithValue("@DestStation", last);
                cmd.Parameters.AddWithValue("@Stops", stops);
                cmd.Parameters.AddWithValue("@Prices", price);
                cmd.Parameters.AddWithValue("@Times", time);
                cmd.ExecuteNonQuery();
                UpdateAllRoutes();
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void addStationBtn_Click(object sender, EventArgs e)
        {
            
            addStationRow();
        }

        private void ClearStationsBtn_Click(object sender, EventArgs e)
        {
            dgv12Clear();
        }

        private void createRouteBtn_Click(object sender, EventArgs e)
        {
            CreateNewRoute();
            dgv12Clear();
            UpdateAllRoutes();
            FillRoutesCb();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm u = new MainForm();
            u.Show();
        }

        private void CreateNewStationBtn_Click(object sender, EventArgs e)
        {
            if (CreateNewStationTB.Text.Length > 0 && CreateNewStationTB.Text != " ")
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Stations(Name) VALUES (?)", cn);
                    cmd.Parameters.Add("@Name", OleDbType.VarChar);
                    cmd.Parameters[0].Value = CreateNewStationTB.Text;
                    cmd.ExecuteNonQuery();
                    FillStationsCb();
                    MessageBox.Show("Станция " + CreateNewStationTB.Text + " добавлена", "Success",
                        MessageBoxButtons.OK);
                    CreateNewStationTB.Text = "";
                }
                catch (Exception e1)
                {
                }
            }
        }
        
        /////////////////////////////////////////////////
        // ------------------------------------------------\\
        // 2 я страница//

        private void CreatNewInTTBase()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("CreatNewInTTBase", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DayOfWeek", day_of_week);
                cmd.Parameters.AddWithValue("@Name", NameTTBaseCB.Text.ToString());
                cmd.Parameters.AddWithValue("@Time", timeTTBaseTB.Text.ToString());
                OleDbDataReader dr = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Заполните все поля правильно! \n И не создавайте одинаковых маршрутов", "ERROR",
                MessageBoxButtons.OK);
                
            }
        }

        private void DeleteInTTBase()
        {
            int count_t = dgv2.SelectedRows.Count;
            if (count_t > 0)
            {
                var confirmResult = MessageBox.Show("Подтверждаете удаление " + count_t + " рейсов", "Подтвердите",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgv2.SelectedRows)
                    {
                        try
                        {
                            OleDbCommand cmd = new OleDbCommand("DELETE FROM TimeTable_Base WHERE Id = ?", cn);
                            cmd.Parameters.Add("@Id", OleDbType.Integer);
                            cmd.Parameters[0].Value = Int32.Parse(row.Cells["Id"].Value.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception e2)
                        {
                        }
                    }
                }
            }
        }

        private void FillRoutesCb()
        {
            NameTTBaseCB.Items.Clear();
            routeNameCB.Items.Clear();
            OleDbCommand IDS = new OleDbCommand("SELECT Name FROM Routes", cn);
            OleDbDataReader rdr = IDS.ExecuteReader();
            while (rdr.Read())
            {
                NameTTBaseCB.Items.Add(rdr["Name"]);
                routeNameCB.Items.Add(rdr["Name"]);
            }
        }
        
        private void setBtnColor()
        {
            monBtn.BackColor = Color.Transparent;
            tueBtn.BackColor = Color.Transparent;
            wedBtn.BackColor = Color.Transparent;
            thuBtn.BackColor = Color.Transparent;
            friBtn.BackColor = Color.Transparent;
            satBtn.BackColor = Color.Transparent;
            sunBtn.BackColor = Color.Transparent;
            switch (day_of_week)
            {
                case 1:
                    monBtn.BackColor = Color.White;
                    break;
                case 2:
                    tueBtn.BackColor = Color.White;
                    break;
                case 3:
                    wedBtn.BackColor = Color.White;
                    break;
                case 4:
                    thuBtn.BackColor = Color.White;
                    break;
                case 5:
                    friBtn.BackColor = Color.White;
                    break;
                case 6:
                    satBtn.BackColor = Color.White;
                    break;
                case 7:
                    sunBtn.BackColor = Color.White;
                    break;
            }
        }


        private void dgv2Fill()
        {
            dataSet2.Clear();
            dgv2.AllowUserToAddRows = false;
            dgv2.AllowUserToResizeColumns = false;
            OleDbDataAdapter dAdapter = new OleDbDataAdapter();
            dAdapter.SelectCommand = new OleDbCommand(
                "SELECT TimeTable_Base.Id, DayOfWeek, Name, Stops, Time FROM TimeTable_Base " + 
                "INNER JOIN Routes on Route_Id = Routes.Id WHERE DayOfWeek = ? ORDER BY Time", cn);
            dAdapter.SelectCommand.Parameters.Add("@DayOfWeek", OleDbType.Integer);
            dAdapter.SelectCommand.Parameters[0].Value = day_of_week;
            dAdapter.Fill(dataSet2);
            dgv2.DataSource = dataSet2.Tables[0];
            for (int c_ = 0; c_ < dgv2.Columns.Count; c_++)
                dgv2.Columns[c_].ReadOnly = true;
            dgv2.Columns["Stops"].Width = 270;
            dgv2.Columns["Name"].Width = 160;
        } 
        /////////////// КНОПКИ ДНЕЙ НЕДЕЛИ \\\\\\\\\\\\\\\\\\\\
        private void monBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 1;
            dgv2Fill();
            setBtnColor();
        }

        private void tueBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 2;
            dgv2Fill();
            setBtnColor();
        }

        private void wedBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 3;
            dgv2Fill();
            setBtnColor();
        }

        private void thuBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 4;
            dgv2Fill();
            setBtnColor();
        }

        private void friBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 5;
            dgv2Fill();
            setBtnColor();
        }

        private void satBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 6;
            dgv2Fill();
            setBtnColor();
        }

        private void sunBtn_Click(object sender, EventArgs e)
        {
            day_of_week = 7;
            dgv2Fill();
            setBtnColor();
        }

    private void addTTBaseBtn_Click(object sender, EventArgs e)
    {
        CreatNewInTTBase();
        dgv2Fill();
    }

    private void deleteTTBaseBtn_Click(object sender, EventArgs e)
    {
        DeleteInTTBase();
        dgv2Fill();
    }

    // ------------------------------------------------\\

    /////////////////////////////////////////////////
    // ------------------------------------------------\\
    // 3 я страница//

    private void FillDgv3()
    {
        DateTime localDate = RZD.Time.GetTime();
        dataSet3.Clear();
        dgv3.AllowUserToAddRows = false;
        dgv3.AllowUserToResizeColumns = false;
        OleDbDataAdapter dAdapter = new OleDbDataAdapter();
        dAdapter.SelectCommand = new OleDbCommand("SELECT CONVERT(DATE, DepartureTime) as Date,COUNT(Id) as Amount" + 
                                                  " FROM TimeTable GROUP BY CONVERT(DATE, DepartureTime) "+
                                                  "HAVING CONVERT(DATE, DepartureTime) > '" + localDate.ToShortDateString() +"'", cn);
        //dAdapter.SelectCommand.Parameters.Add("@DayOfWeek", OleDbType.Integer);
        //dAdapter.SelectCommand.Parameters[0].Value = day_of_week;
        dAdapter.Fill(dataSet3);
        dgv3.DataSource = dataSet3.Tables[0];
        for (int c_ = 0; c_ < dgv3.Columns.Count; c_++)
            dgv3.Columns[c_].ReadOnly = true;
    }
    
    private void fillTTbtn_Click(object sender, EventArgs e)
    {
        DateTime from;
        DateTime to;

        if (DateTime.TryParse(fromTimeTTCB.Text.ToString(), out from) &&
            DateTime.TryParse(toTimeTTCB.Text.ToString(), out to))
        {
            for (DateTime ii11=from;  ii11<=to; ii11=ii11.AddDays(1)  )
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("TimeTableFilling", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Date", ii11);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e2)
                {
                }
            }
        }
        else
        {
            MessageBox.Show("Заполните дату корректно", "ERROR", MessageBoxButtons.OK);
        }

        FillDgv3();
    }

    private void FillDgv32()
    {
        string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
        dataSet32.Clear();
        dgv32.AllowUserToAddRows = false;
        dgv32.AllowUserToResizeColumns = false;
        OleDbDataAdapter dAdapter = new OleDbDataAdapter();
        dAdapter.SelectCommand = new OleDbCommand("SearchTimeTableAdmin", cn);
        dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        dAdapter.SelectCommand.Parameters.AddWithValue("@Date", date);
        dAdapter.Fill(dataSet32);
        dgv32.DataSource = dataSet32.Tables[0];
        for (int c_ = 0; c_ < dgv32.Columns.Count; c_++)
            dgv32.Columns[c_].ReadOnly = true;
        dgv32.Columns["Id"].Width = 40;
        dgv32.Columns["Name"].Width = 160;
        dgv32.Columns["Train_Id"].Width = 50;
        dgv32.Columns["Train Name"].Width = 70;
        
    }

    private void AddDirectlyInTTFun()
    {
        try
        {
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            OleDbCommand cmd = new OleDbCommand("AddDirectlyInTTFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DayOfWeek", date);
            cmd.Parameters.AddWithValue("@Name", routeNameCB.Text.ToString());
            cmd.Parameters.AddWithValue("@Time", timeTTtb.Text.ToString());
            OleDbDataReader dr = cmd.ExecuteReader();
        }
        catch (Exception e)
        {
            MessageBox.Show("Заполните все поля правильно!", "ERROR",
                MessageBoxButtons.OK);

        }
    }

    private void fillTrainsCB()
    {
        trainsCB.Items.Clear();
        OleDbCommand IDS = new OleDbCommand("SELECT Name FROM Trains", cn);
        OleDbDataReader rdr = IDS.ExecuteReader();
        while (rdr.Read())
        {
            trainsCB.Items.Add(rdr["Name"]);
        }
    }

    private void addTTbtn_Click(object sender, EventArgs e)
    {
        AddDirectlyInTTFun();
        FillDgv32();
    }

    private void applyTrainsBtn_Click(object sender, EventArgs e)
    {
        try
        {
            OleDbCommand IDS =
                new OleDbCommand("UPDATE TimeTable Set Train_Id = (SELECT Id FROM Trains WHERE Name = ?) WHERE Id = ?",
                    cn);
            IDS.Parameters.Add("@P1", OleDbType.VarChar);
            IDS.Parameters.Add("@P2", OleDbType.Integer);
            IDS.Parameters[0].Value = trainsCB.Text.ToString();
            IDS.Parameters[1].Value = Int32.Parse(numLbl.Text);
            IDS.ExecuteNonQuery();
            FillDgv32();
        }
        catch (Exception e2)
        {
            MessageBox.Show("Выберите рейс и поезд", "ERROR",
                MessageBoxButtons.OK);
        }
    }

    private void SearchBtn_Click(object sender, EventArgs e)
    {
        numLbl.Text = "";
        FillDgv32();
    }

    private void dgv32_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dgv32.Rows[e.RowIndex];
            Console.WriteLine(Int32.Parse(row.Cells[0].Value.ToString()));
            numLbl.Text = row.Cells[0].Value.ToString();
        }
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }
  }
}