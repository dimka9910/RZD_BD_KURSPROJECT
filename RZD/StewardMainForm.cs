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
  public partial class StewardMainForm : Form
  {
    private string ok = "Соответствует";
    private int id;
    private OleDbConnection cn;
    OleDbDataAdapter dAdapter;
    private int id_tt;

    public StewardMainForm(int id, OleDbConnection cn)
    {
      InitializeComponent();
      id_tt = 0;
      this.id = id;
      this.cn = cn;
      SetLabelText();
      SetPasLabelsText();
      SearchLinensFun();
      ComboBoxFill();
      dgv4.AllowUserToAddRows = false;
      totalPriceLbl.Text = "0";
    }
    
    private void UpdateTableTimeTable()
    {
      string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
      
      DateTime localDate = Time.GetTime();
      dataSet1.Clear();
      dgv1.AllowUserToAddRows = false;
      dgv1.AllowUserToResizeColumns = false;
      dAdapter = new OleDbDataAdapter();
      dAdapter.SelectCommand = new OleDbCommand("TimeTableForToday", cn);
      dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      dAdapter.SelectCommand.Parameters.AddWithValue("@Date", date);
      dAdapter.Fill(dataSet1);
      dgv1.DataSource = dataSet1.Tables[0];
      for (int c_ = 0; c_ < dgv1.Columns.Count; c_++)
      {
        dgv1.Columns[c_].ReadOnly = true;
      }
      dgv1.Columns["Id"].Width = 35;
      dgv1.Columns["Name"].Width = 160;
    }

    private void SetLabelText()
    {
      if (id_tt == 0)
      {
        label1.Text = "Рейс не выбран";
      }
      else
      {
        label1.Text = "Ваш рейс №" + id_tt;
      }
    }

    private void SetPasLabelsText()
    {
      PasNameLbl.Text = "";
      PasRouteLbl.Text = "";
      PasLinensLbl.Text = "";
      PasStatusLbl.Text = "";
      PasFromLbl.Text = "";
      PasToLbl.Text = "";
      LinensBarcodeLbl.Text = "";
    }

    private void SelectTimeTable()
    {
      int count_t = dgv1.SelectedRows.Count;
      if (count_t == 1)
      {
        try
        {
          foreach (DataGridViewRow row in dgv1.SelectedRows)
          {
            id_tt = Int32.Parse(row.Cells["Id"].Value.ToString());
          }
          SetLabelText();
        }
        catch (Exception e1)
        {
          MessageBox.Show("Выберите конкретный рейс!", "ERROR", MessageBoxButtons.OK);
        }
      }
      else
      {
        MessageBox.Show("Выберите конкретный рейс!", "ERROR", MessageBoxButtons.OK);
      }
    }

    private bool SearchPasFun()
    {
      if (id_tt == 0)
      {
        MessageBox.Show("Вы не выбрали рейс!", "ERROR", MessageBoxButtons.OK);
        return false;
      }
      SetPasLabelsText();
      int pas_id = 0;
      if (Int32.TryParse(textBox1.Text.ToString(), out pas_id))
      {
        OleDbCommand cmd = new OleDbCommand("SearchPas", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Id", pas_id);
        OleDbDataReader dr = cmd.ExecuteReader();
        
        while (dr.Read())
        {
          PasNameLbl.Text = dr.GetString(1) + " " + dr.GetString(2) + " " + dr.GetString(3);
          PasRouteLbl.Text = dr.GetString(4);
          PasFromLbl.Text = dr.GetString(5);
          PasToLbl.Text = dr.GetString(6);
          if (dr.GetInt32(0) == id_tt)
          {
            PasRouteLbl.Text = ok;
          }
          else
          {
            PasRouteLbl.Text = "Не соответствует";
          }

          if (dr.GetBoolean(dr.GetOrdinal("Checked")) == false)
          {
            PasStatusLbl.Text = "Не проверен";
          }
          else
          {
            PasStatusLbl.Text = "Проверен";
          }
          
          if (dr.IsDBNull(8))
          {
            PasLinensLbl.Text = "Не получал";
            LinensBarcodeLbl.Text = "";
          }
          else
          {
            PasLinensLbl.Text = "Получено";
            LinensBarcodeLbl.Text = dr.GetInt32(8).ToString();
          }
        }
        return true;
      }
      return false;
    }

    private void SearchLinensFun()
    {
      dataSet2.Clear();
      dgv2.AllowUserToAddRows = false;
      dgv2.AllowUserToResizeColumns = false;
      dAdapter = new OleDbDataAdapter();
      dAdapter.SelectCommand = new OleDbCommand("SearchLinens", cn);
      dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      dAdapter.SelectCommand.Parameters.AddWithValue("@Id", id);
      dAdapter.Fill(dataSet2);
      dgv2.DataSource = dataSet2.Tables[0];
      for (int c_ = 0; c_ < dgv2.Columns.Count; c_++)
      {
        dgv2.Columns[c_].ReadOnly = true;
        dgv2.Columns[c_].Width = 100;
      }
      dgv2.Columns["Id"].Width = 45;
      dgv2.Columns["Barcode"].Width = 57;
    }
    
    
    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void CheckPasBtn_Click(object sender, EventArgs e)
    {
      if (id_tt == 0)
      {
        MessageBox.Show("Вы не выбрали рейс!", "ERROR", MessageBoxButtons.OK);
        return;
      }
      SetPasLabelsText();
      SearchPasFun();
      if (PasRouteLbl.Text == ok)
      {
        int pas_id = 0;
        if (Int32.TryParse(textBox1.Text.ToString(), out pas_id))
        {
          OleDbCommand cmd = new OleDbCommand("CheckPas", cn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@Id", pas_id);
          cmd.ExecuteNonQuery();
        }
      }
      SearchPasFun();
    }

    private void GiveBtn_Click(object sender, EventArgs e)
    {
      if (SearchPasFun())
      {
        int pas_id = 0;
        if (Int32.TryParse(textBox1.Text.ToString(), out pas_id) && PasRouteLbl.Text == ok 
        && PasStatusLbl.Text == "Проверен" && PasLinensLbl.Text == "Не получал")
        {
          OleDbCommand cmd = new OleDbCommand("GiveLinens", cn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@PasAndTrip_Id", pas_id);
          cmd.Parameters.AddWithValue("@Steward_id", id);
          cmd.ExecuteNonQuery();
        }
        SearchPasFun();
        SearchLinensFun();
      }
    }

    private void TakeBtn_Click(object sender, EventArgs e)
    {
      if (SearchPasFun())
      {
        int pas_id = 0;
        if (Int32.TryParse(textBox1.Text.ToString(), out pas_id) && PasRouteLbl.Text == ok)
        {
          OleDbCommand cmd = new OleDbCommand("TakeLinens", cn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@PasAndTrip_Id", pas_id);
          cmd.ExecuteNonQuery();
        }
        SearchPasFun();
        SearchLinensFun();
      }
    }

    private void SearchPasBtn_Click(object sender, EventArgs e)
    {
      SearchPasFun();
    }

    private void SearchBtn_Click(object sender, EventArgs e)
    {
      UpdateTableTimeTable();
    }

    private void StewardMainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Application.Exit();
    }

    private void ApplyBtn_Click(object sender, EventArgs e)
    {
      SelectTimeTable();
    }

    private void LinensBarcodeLbl_Click(object sender, EventArgs e)
    {

    }
    
    private void HardDeleteBtn_Click(object sender, EventArgs e)
    {
      int count_t = dgv2.SelectedRows.Count;
      if (count_t > 0)
      {
        var confirmResult = MessageBox.Show("Вы уверены что эти пассажиры сдали бельё?", "Caution",
          MessageBoxButtons.YesNo);
        if (confirmResult == DialogResult.Yes)
        {
          foreach (DataGridViewRow row in dgv2.SelectedRows)
          {
            try
            {
              OleDbCommand cmd = new OleDbCommand("TakeLinens", cn);
              cmd.CommandType = CommandType.StoredProcedure;
              cmd.Parameters.AddWithValue("@Id", Int32.Parse(row.Cells["Id"].Value.ToString()));
              cmd.ExecuteNonQuery();
            }
            catch (Exception e2)
            {
            }
          }
        }
        SearchLinensFun();
      }
      
    }

    private void Refresh_Click(object sender, EventArgs e)
    {
      if (id_tt == 0)
      {
        MessageBox.Show("Вы не выбрали рейс!", "ERROR", MessageBoxButtons.OK);
        return;
      }
      dataSet3.Clear();
      dgv3.AllowUserToAddRows = false;
      dgv3.AllowUserToResizeColumns = false;
      dAdapter = new OleDbDataAdapter();
      dAdapter.SelectCommand = new OleDbCommand("SearchPasForTimeTable", cn);
      dAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      dAdapter.SelectCommand.Parameters.AddWithValue("@id_tt", id_tt);
      dAdapter.Fill(dataSet3);
      dgv3.DataSource = dataSet3.Tables[0];
      for (int c_ = 0; c_ < dgv3.Columns.Count; c_++)
      {
        dgv3.Columns[c_].ReadOnly = true;
        dgv3.Columns[c_].Width = 100;
      }
      //dgv3.Columns["Id"].Width = 45;
      //dgv3.Columns["Barcode"].Width = 57;
    }

    //5я страница, снэки
    // ------------------------------------- \\
    private void ComboBoxFill()
    {
      OleDbCommand IDS = new OleDbCommand("SELECT Name FROM Snacks", cn);
      OleDbDataReader rdr = IDS.ExecuteReader();

      while(rdr.Read()) 
        comboBox1.Items.Add(rdr["Name"]);

    }
    
    private void addSnack_Click(object sender, EventArgs e)
    {
      int amount = 0;
      if (Int32.TryParse(amountTB.Text.ToString(), out amount))
      {
        OleDbCommand cmd = new OleDbCommand("SearchSnack", cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name", comboBox1.Text.ToString());
        OleDbDataReader dr = cmd.ExecuteReader();
        string[] rowData = new string[3];
        while (dr.Read())
        {
          totalPriceLbl.Text = (Int32.Parse(totalPriceLbl.Text) + dr.GetInt32(0) * amount).ToString();
          rowData[0] = comboBox1.Text;
          rowData[1] = amount.ToString();
          rowData[2] = dr.GetInt32(0).ToString();
          dgv4.Rows.Add(rowData);
        }
      }
    }

    private void ConfirnBtn_Click(object sender, EventArgs e)
    {
      if (dgv4.Rows.Count > 0)
      {
        OleDbCommand cmd = new OleDbCommand("INSERT INTO Sales(Steward_Id, Date) VALUES (?,?)", cn);
        cmd.Parameters.Add("@CID", OleDbType.Integer);
        cmd.Parameters.Add("@OD", OleDbType.Date);
        cmd.Parameters[0].Value = id;
        cmd.Parameters[1].Value = Time.GetTime();
        OleDbDataReader dr = cmd.ExecuteReader();
        int sales_id = 0;
        if (dr.Read()) { sales_id = dr.GetInt32(0); }

        foreach (DataGridViewRow row in dgv4.Rows)
        {
          try
          {
            cmd = new OleDbCommand("SalesDetailsFill", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesId", sales_id);
            cmd.Parameters.AddWithValue("@Name", row.Cells["Snack"].Value.ToString());
            cmd.Parameters.AddWithValue("@UnitPrice", Int32.Parse(row.Cells["UnitPrice"].Value.ToString()));
            cmd.Parameters.AddWithValue("@Quantity", Int32.Parse(row.Cells["Amount"].Value.ToString()));
            cmd.ExecuteNonQuery();
          }
          catch (Exception e2)
          {
          }
        }
        dgv4.Rows.Clear();
        totalPriceLbl.Text = "0";
      }
    }

    private void clearSnackBtn_Click(object sender, EventArgs e)
    {
      dgv4.Rows.Clear();
      totalPriceLbl.Text = "0";
    }
  }
}
