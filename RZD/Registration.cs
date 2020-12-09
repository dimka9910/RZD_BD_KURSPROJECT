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
  public partial class Registration : Form
  {
    private OleDbConnection cn;
    
    public Registration(OleDbConnection cn)
    {
      InitializeComponent();
      this.cn = cn;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text == "" || textBox2.Text == "")
      {
        MessageBox.Show("Заполните все поля", "ERROR", MessageBoxButtons.OK);
        return;
      }
      
      OleDbCommand cmd = new OleDbCommand("LoginUser", cn);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.AddWithValue("@Login", textBox1.Text);
      cmd.Parameters.AddWithValue("@Password", textBox2.Text);
      OleDbDataReader reader = cmd.ExecuteReader();
      
      if (reader.Read())
      {
        string role = reader[2].ToString();
        if (role == "WRONG PASSWORD")
        {
          MessageBox.Show("Такой login занят", "ERROR", MessageBoxButtons.OK);
          return;
        }
      }
      
      OleDbCommand cmd1 = new OleDbCommand("Insert into Accounts (Login, Password) VALUES (?,?)", cn);
      cmd1.Parameters.Add("@p1", OleDbType.VarChar);
      cmd1.Parameters.Add("@p2", OleDbType.VarChar);
      cmd1.Parameters[0].Value = textBox1.Text;
      cmd1.Parameters[1].Value = textBox2.Text;
      cmd1.ExecuteNonQuery();
      MessageBox.Show("Аккаунт успешно создан", "SUCCESS", MessageBoxButtons.OK);
      this.Hide();
      MainForm u = new MainForm();
      u.Show();
    }

    private void Registration_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.Hide();
      MainForm u = new MainForm();
      u.Show();
    }
  }
}
