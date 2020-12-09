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

      if (reader.Read())
      {
        string role = reader[2].ToString();
        int id = int.Parse(reader[0].ToString());
        if (role == "user") 
        {
          this.Hide();
          UserMainForm u = new UserMainForm(id, cn);
          u.Show();
        }
        else if (role == "stewards")
        {
          this.Hide();
          StewardMainForm u1 = new StewardMainForm(1, cn);
          u1.Show();
        }
        else if (role == "admin")
        {
          this.Hide();
          AdminMainForm u1 = new AdminMainForm(1, cn);
          u1.Show();
        }
        else
        {
          MessageBox.Show(role, "ERROR", MessageBoxButtons.OK);
        }
      }
    }

    private void MainForm_Activated(object sender, EventArgs e)
    {

    }

    private void Registration_Click(object sender, EventArgs e)
    {
      this.Hide();
      Registration u = new Registration(cn);
      u.Show();
    }

    private void LoginTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }
  }
}
