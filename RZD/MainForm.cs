using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace RZD
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      try
      {
        cn.Open();
      }
      catch (Exception)
      {
        MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OleDbCommand cmd = new OleDbCommand("LoginUser", cn);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.AddWithValue("@Login", LoginTextBox.Text);
      cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
      OleDbDataReader reader = cmd.ExecuteReader();
      ////
      this.Hide();
      //UserMainForm u1 = new UserMainForm(1, cn);
      StewardMainForm u1 = new StewardMainForm(1, cn);
      u1.Show();
      ////
      
      if (reader.Read())
      {
        string role = reader[2].ToString();
        int id = int.Parse(reader[0].ToString());
        if (role == "user" || role == "stewards" || role == "admin")
        {
          this.Hide();
          UserMainForm u = new UserMainForm(id, cn);
          u.Show();
          

          //MessageBox.Show(role, "ERROR", MessageBoxButtons.OK);
        }
        else
        {
          //MessageBox.Show(role, "ERROR", MessageBoxButtons.OK);
        }
      }
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {

    }
  }
}
