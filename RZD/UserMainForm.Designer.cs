namespace RZD
{
  partial class UserMainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.dgv1 = new System.Windows.Forms.DataGridView();
      this.id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ArrivingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TripTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Search = new System.Windows.Forms.Button();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      this.TextBoxTo = new System.Windows.Forms.TextBox();
      this.TextBoxFrom = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.dgv22 = new System.Windows.Forms.DataGridView();
      this.delete = new System.Windows.Forms.Button();
      this.save = new System.Windows.Forms.Button();
      this.add = new System.Windows.Forms.Button();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.dataSet1 = new System.Data.DataSet();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv22)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(1, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(799, 449);
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      this.tabControl1.Click += new System.EventHandler(this.tabPage2_Click);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.dgv1);
      this.tabPage1.Controls.Add(this.Search);
      this.tabPage1.Controls.Add(this.monthCalendar1);
      this.tabPage1.Controls.Add(this.TextBoxTo);
      this.tabPage1.Controls.Add(this.TextBoxFrom);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(791, 423);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
      // 
      // dgv1
      // 
      this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_,
            this.time,
            this.From,
            this.To,
            this.DepartureTime,
            this.ArrivingTime,
            this.TripTime,
            this.Price});
      this.dgv1.Location = new System.Drawing.Point(189, 53);
      this.dgv1.Name = "dgv1";
      this.dgv1.Size = new System.Drawing.Size(572, 347);
      this.dgv1.TabIndex = 5;
      this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
      // 
      // id_
      // 
      this.id_.Frozen = true;
      this.id_.HeaderText = "Id";
      this.id_.MinimumWidth = 2;
      this.id_.Name = "id_";
      this.id_.ReadOnly = true;
      this.id_.Width = 2;
      // 
      // time
      // 
      this.time.Frozen = true;
      this.time.HeaderText = "Имя";
      this.time.Name = "time";
      this.time.Width = 140;
      // 
      // From
      // 
      this.From.Frozen = true;
      this.From.HeaderText = "From";
      this.From.Name = "From";
      this.From.ReadOnly = true;
      // 
      // To
      // 
      this.To.Frozen = true;
      this.To.HeaderText = "To";
      this.To.Name = "To";
      this.To.ReadOnly = true;
      this.To.Width = 95;
      // 
      // DepartureTime
      // 
      this.DepartureTime.Frozen = true;
      this.DepartureTime.HeaderText = "Departure Time";
      this.DepartureTime.Name = "DepartureTime";
      this.DepartureTime.ReadOnly = true;
      this.DepartureTime.Width = 65;
      // 
      // ArrivingTime
      // 
      this.ArrivingTime.Frozen = true;
      this.ArrivingTime.HeaderText = "Arriving Time";
      this.ArrivingTime.Name = "ArrivingTime";
      this.ArrivingTime.ReadOnly = true;
      this.ArrivingTime.Width = 55;
      // 
      // TripTime
      // 
      this.TripTime.Frozen = true;
      this.TripTime.HeaderText = "Trip Time";
      this.TripTime.Name = "TripTime";
      this.TripTime.ReadOnly = true;
      this.TripTime.Width = 40;
      // 
      // Price
      // 
      this.Price.Frozen = true;
      this.Price.HeaderText = "Price";
      this.Price.Name = "Price";
      this.Price.ReadOnly = true;
      this.Price.Width = 35;
      // 
      // Search
      // 
      this.Search.Location = new System.Drawing.Point(573, 14);
      this.Search.Name = "Search";
      this.Search.Size = new System.Drawing.Size(154, 23);
      this.Search.TabIndex = 3;
      this.Search.Text = "Search";
      this.Search.UseVisualStyleBackColor = true;
      this.Search.Click += new System.EventHandler(this.Search_Click);
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.Location = new System.Drawing.Point(13, 16);
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 2;
      this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
      // 
      // TextBoxTo
      // 
      this.TextBoxTo.Location = new System.Drawing.Point(384, 16);
      this.TextBoxTo.Name = "TextBoxTo";
      this.TextBoxTo.Size = new System.Drawing.Size(177, 20);
      this.TextBoxTo.TabIndex = 1;
      this.TextBoxTo.TextChanged += new System.EventHandler(this.TextBoxTo_TextChanged);
      // 
      // TextBoxFrom
      // 
      this.TextBoxFrom.Location = new System.Drawing.Point(205, 16);
      this.TextBoxFrom.Name = "TextBoxFrom";
      this.TextBoxFrom.Size = new System.Drawing.Size(155, 20);
      this.TextBoxFrom.TabIndex = 0;
      this.TextBoxFrom.TextChanged += new System.EventHandler(this.TextBoxFrom_TextChanged);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dgv22);
      this.tabPage2.Controls.Add(this.delete);
      this.tabPage2.Controls.Add(this.save);
      this.tabPage2.Controls.Add(this.add);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(791, 423);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
      // 
      // dgv22
      // 
      this.dgv22.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv22.Location = new System.Drawing.Point(318, 121);
      this.dgv22.Name = "dgv22";
      this.dgv22.Size = new System.Drawing.Size(401, 228);
      this.dgv22.TabIndex = 4;
      // 
      // delete
      // 
      this.delete.Location = new System.Drawing.Point(115, 259);
      this.delete.Name = "delete";
      this.delete.Size = new System.Drawing.Size(75, 23);
      this.delete.TabIndex = 3;
      this.delete.Text = "delete";
      this.delete.UseVisualStyleBackColor = true;
      this.delete.Click += new System.EventHandler(this.delete_Click);
      // 
      // save
      // 
      this.save.Location = new System.Drawing.Point(115, 218);
      this.save.Name = "save";
      this.save.Size = new System.Drawing.Size(75, 23);
      this.save.TabIndex = 2;
      this.save.Text = "save";
      this.save.UseVisualStyleBackColor = true;
      this.save.Click += new System.EventHandler(this.save_Click);
      // 
      // add
      // 
      this.add.Location = new System.Drawing.Point(115, 175);
      this.add.Name = "add";
      this.add.Size = new System.Drawing.Size(75, 23);
      this.add.TabIndex = 1;
      this.add.Text = "add";
      this.add.UseVisualStyleBackColor = true;
      this.add.Click += new System.EventHandler(this.add_Click);
      // 
      // tabPage3
      // 
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(791, 423);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "tabPage3";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
      // 
      // dataSet1
      // 
      this.dataSet1.DataSetName = "NewDataSet";
      // 
      // UserMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "UserMainForm";
      this.Text = "UserMainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMainForm_FormClosing);
      this.Load += new System.EventHandler(this.UserMainForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv22)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button Search;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
    private System.Windows.Forms.TextBox TextBoxTo;
    private System.Windows.Forms.TextBox TextBoxFrom;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.DataGridView dgv1;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_;
    private System.Windows.Forms.DataGridViewTextBoxColumn time;
    private System.Windows.Forms.DataGridViewTextBoxColumn From;
    private System.Windows.Forms.DataGridViewTextBoxColumn To;
    private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn ArrivingTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn TripTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    private System.Windows.Forms.Button delete;
    private System.Windows.Forms.Button save;
    private System.Windows.Forms.Button add;
    private System.Windows.Forms.DataGridView dgv22;
    private System.Data.DataSet dataSet1;
  }
}