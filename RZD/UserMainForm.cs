﻿using System;
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
  public partial class UserMainForm : Form
  {
    private int id;
    private OleDbConnection cn;
    OleDbDataAdapter dAdapter;

    public UserMainForm(int id, OleDbConnection cn)
    {
      InitializeComponent();
      this.id = id;
      this.cn = cn;
      UpdateTablePassDate();
      UpdateTableTickets();
      UpdateTableLinens();

    }

    private void Search_Click(object sender, EventArgs e)
    {
      string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
      string from_ = TextBoxFrom.Text;
      string to_ = TextBoxTo.Text;
      OleDbCommand cmd = new OleDbCommand("SelectSuitableTimeTableWitPrice", cn);
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.AddWithValue("@Date1", date);
      cmd.Parameters.AddWithValue("@DestStationName", to_);
      cmd.Parameters.AddWithValue("@DepStationName", from_);
      OleDbDataReader dr = cmd.ExecuteReader();
      
      int columnCount = dr.FieldCount;
      dgv1.Rows.Clear();
      string[] rowData = new string[columnCount];
      while (dr.Read())
      {
        rowData[0] = dr.GetInt32(0).ToString();
        rowData[1] = dr.GetString(1);
        rowData[2] = dr.GetString(2);
        rowData[3] = dr.GetString(3);
        rowData[4] = dr.GetDateTime(4).ToShortTimeString();
        rowData[5] = dr.GetDateTime(5).ToShortTimeString();
        rowData[6] = dr.GetDateTime(6).ToShortTimeString();
        rowData[7] = dr.GetInt32(7).ToString();

        dgv1.Rows.Add(rowData);
      }
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
    
    private void UpdateTableTickets()
    {
      DateTime localDate = Time.GetTime();
      dataSet2.Clear();
      dgv3.AllowUserToAddRows = false;
      dgv3.AllowUserToResizeColumns = false;
      dAdapter = new OleDbDataAdapter();
      dAdapter.SelectCommand = new OleDbCommand("SelectAllTickets", cn);
      dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      dAdapter.SelectCommand.Parameters.AddWithValue("@Date", localDate.ToString());
      dAdapter.SelectCommand.Parameters.AddWithValue("@Account_Id", this.id);
      dAdapter.Fill(dataSet2);

      dgv3.DataSource = dataSet2.Tables[0];
      for (int c_ = 0; c_ < dgv3.Columns.Count; c_++)
      {
        dgv3.Columns[c_].ReadOnly = true;
      }
      dgv3.Columns["Id"].Width = 35;
      dgv3.Columns["Route Name"].Width = 150;
      dgv3.Columns["Checked"].Width = 55;
      dgv3.Columns["Name"].Width = 60;
      dgv3.Columns["Surname"].Width = 70;
      dgv3.Columns["Fname"].Width = 70;
      dgv3.Columns["To"].Width = 80;
    }
    


    private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void TextBoxTo_TextChanged(object sender, EventArgs e)
    {

    }

    private void TextBoxFrom_TextChanged(object sender, EventArgs e)
    {

    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void tabPage3_Click(object sender, EventArgs e)
    {

    }

    private void add_Click(object sender, EventArgs e)
    {
      DataRow row = dataSet1.Tables[0].NewRow(); // добавляем новую строку в DataTable
      dataSet1.Tables[0].Rows.Add(row);
    }

    private void save_Click(object sender, EventArgs e)
    {
      int iRowID = 0;
      for (iRowID = 0; iRowID < dataSet1.Tables[0].Rows.Count; iRowID++)
      {
        try
        {
          OleDbCommand cmd = new OleDbCommand("SetPssData", cn);
          cmd.CommandType = CommandType.StoredProcedure;
          DataRow dRow = dataSet1.Tables[0].Rows[iRowID];
          if (dRow["Name"].ToString() == "" || dRow["FName"].ToString() == "")
          {
            MessageBox.Show("Поля Имя и Фамилия не могут быть пустыми", "ERROR", MessageBoxButtons.OK);
            break;
          }

          cmd.Parameters.AddWithValue("@Account_Id", id);
          try
          {
            cmd.Parameters.AddWithValue("@Id_PassData", Int32.Parse(dRow["Id"].ToString()));
          }
          catch (Exception exc)
          {
            cmd.Parameters.AddWithValue("@Id_PassData", -1);
          }
          cmd.Parameters.AddWithValue("@Name", dRow["Name"].ToString());
          cmd.Parameters.AddWithValue("@Surname", dRow["Surname"].ToString());
          cmd.Parameters.AddWithValue("@FName", dRow["FName"].ToString());
          cmd.ExecuteNonQuery();
        }
        catch (Exception e1)
        {
        }
      }
      
      UpdateTablePassDate();
    }

    private void delete_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgv22.SelectedRows)
      {
        try
        {
          String strSQL = "DELETE FROM PassData WHERE Id = " + row.Cells["Id"].Value;
          OleDbCommand cmdIC = new OleDbCommand(strSQL, cn);
          cmdIC.ExecuteNonQuery();
        }
        catch (Exception e2) { }
        
      }
      UpdateTablePassDate();
    }

    private void UserMainForm_Load(object sender, EventArgs e)
    {

    }

    private void UserMainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.Hide();
      MainForm u = new MainForm();
      u.Show();
    }

    private void UpdateTickets_Click(object sender, EventArgs e)
    {
      UpdateTableTickets();
    }

    private void cancel_Click(object sender, EventArgs e)
    {
      int count_t = dgv3.SelectedRows.Count;
      if (count_t > 0)
      {
        var confirmResult = MessageBox.Show("Подтверждаете отмену " + count_t + " билетов" , "Подтвердите",
          MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
          foreach (DataGridViewRow row in dgv3.SelectedRows)
          {
            try
            {
              OleDbCommand cmd = new OleDbCommand("CancelTicket", cn);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Int32.Parse(row.Cells["Id"].Value.ToString()));
              OleDbDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
              {
                if (dr.GetInt32(0) == 1)
                {
                  MessageBox.Show(row.Cells["Name"].Value.ToString() + " " +
                                  row.Cells["Surname"].Value.ToString() + ", должен бельё", "Ошибка",
                    MessageBoxButtons.OK);
                }
              }
            }
            catch (Exception e2)
            {
            }
          }
        }
        UpdateTableTickets();
      }
    }


    private void UpdateTableLinens()
    {
      dataSet3.Clear();
      dgv4.AllowUserToAddRows = false;
      dgv4.AllowUserToResizeColumns = false;
      dAdapter = new OleDbDataAdapter();
      dAdapter.SelectCommand = new OleDbCommand("SelectMyLinens", cn);
      dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      dAdapter.SelectCommand.Parameters.AddWithValue("@Id", this.id);
      dAdapter.Fill(dataSet3);
      dgv4.DataSource = dataSet3.Tables[0];
      for (int c_ = 0; c_ < dgv4.Columns.Count; c_++)
      {
        dgv3.Columns[c_].ReadOnly = true;
      }
    }
    private void UpdateLinens_Click(object sender, EventArgs e)
    {
      UpdateTableLinens();
    }

    private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        DataGridViewRow row = dgv1.Rows[e.RowIndex];
        Console.WriteLine(Int32.Parse(row.Cells[0].Value.ToString()));
        int id_tt = Int32.Parse(row.Cells[0].Value.ToString());
        string name = row.Cells[1].Value.ToString();
        string from = row.Cells[2].Value.ToString();
        string to = row.Cells[3].Value.ToString();
        string deptime = row.Cells[4].Value.ToString();
        int price = Int32.Parse(row.Cells[7].Value.ToString());
        UserBuyForm ubf = new UserBuyForm(id, cn, id_tt, name, from, to, deptime, price);
        ubf.Show();
      }
    }
  }
}
