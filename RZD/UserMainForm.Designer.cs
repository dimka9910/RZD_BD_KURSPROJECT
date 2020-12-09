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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
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
      this.cancel = new System.Windows.Forms.Button();
      this.UpdateTickets = new System.Windows.Forms.Button();
      this.dgv3 = new System.Windows.Forms.DataGridView();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.UpdateLinens = new System.Windows.Forms.Button();
      this.dgv4 = new System.Windows.Forms.DataGridView();
      this.dataSet1 = new System.Data.DataSet();
      this.dataSet2 = new System.Data.DataSet();
      this.dataSet3 = new System.Data.DataSet();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv22)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
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
      this.tabPage1.Controls.Add(this.TextBoxTo);
      this.tabPage1.Controls.Add(this.TextBoxFrom);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.dgv1);
      this.tabPage1.Controls.Add(this.Search);
      this.tabPage1.Controls.Add(this.monthCalendar1);
      this.tabPage1.Controls.Add(this.pictureBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(791, 423);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Купить Билет";
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
      this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
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
      this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Search.Location = new System.Drawing.Point(607, 14);
      this.Search.Name = "Search";
      this.Search.Size = new System.Drawing.Size(154, 33);
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
      this.TextBoxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TextBoxTo.Location = new System.Drawing.Point(424, 16);
      this.TextBoxTo.Name = "TextBoxTo";
      this.TextBoxTo.Size = new System.Drawing.Size(177, 31);
      this.TextBoxTo.TabIndex = 1;
      this.TextBoxTo.TextChanged += new System.EventHandler(this.TextBoxTo_TextChanged);
      // 
      // TextBoxFrom
      // 
      this.TextBoxFrom.AccessibleDescription = "Пртае";
      this.TextBoxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.TextBoxFrom.Location = new System.Drawing.Point(231, 16);
      this.TextBoxFrom.Name = "TextBoxFrom";
      this.TextBoxFrom.Size = new System.Drawing.Size(155, 31);
      this.TextBoxFrom.TabIndex = 0;
      this.TextBoxFrom.Tag = "";
      this.TextBoxFrom.TextChanged += new System.EventHandler(this.TextBoxFrom_TextChanged);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.dgv22);
      this.tabPage2.Controls.Add(this.delete);
      this.tabPage2.Controls.Add(this.save);
      this.tabPage2.Controls.Add(this.add);
      this.tabPage2.Controls.Add(this.pictureBox2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(791, 423);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Мои Пассажиры";
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
      this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.delete.Location = new System.Drawing.Point(170, 294);
      this.delete.Name = "delete";
      this.delete.Size = new System.Drawing.Size(142, 55);
      this.delete.TabIndex = 3;
      this.delete.Text = "Удалить";
      this.delete.UseVisualStyleBackColor = true;
      this.delete.Click += new System.EventHandler(this.delete_Click);
      // 
      // save
      // 
      this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.save.Location = new System.Drawing.Point(170, 194);
      this.save.Name = "save";
      this.save.Size = new System.Drawing.Size(142, 83);
      this.save.TabIndex = 2;
      this.save.Text = "Сохранить изменения";
      this.save.UseVisualStyleBackColor = true;
      this.save.Click += new System.EventHandler(this.save_Click);
      // 
      // add
      // 
      this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.add.Location = new System.Drawing.Point(170, 121);
      this.add.Name = "add";
      this.add.Size = new System.Drawing.Size(142, 55);
      this.add.TabIndex = 1;
      this.add.Text = "Добавить";
      this.add.UseVisualStyleBackColor = true;
      this.add.Click += new System.EventHandler(this.add_Click);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.cancel);
      this.tabPage3.Controls.Add(this.UpdateTickets);
      this.tabPage3.Controls.Add(this.dgv3);
      this.tabPage3.Controls.Add(this.pictureBox3);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(791, 423);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Мои Билеты";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
      // 
      // cancel
      // 
      this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.cancel.Location = new System.Drawing.Point(11, 321);
      this.cancel.Name = "cancel";
      this.cancel.Size = new System.Drawing.Size(156, 59);
      this.cancel.TabIndex = 2;
      this.cancel.Text = "Оменить Билет";
      this.cancel.UseVisualStyleBackColor = true;
      this.cancel.Click += new System.EventHandler(this.cancel_Click);
      // 
      // UpdateTickets
      // 
      this.UpdateTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.UpdateTickets.Location = new System.Drawing.Point(622, 321);
      this.UpdateTickets.Name = "UpdateTickets";
      this.UpdateTickets.Size = new System.Drawing.Size(156, 59);
      this.UpdateTickets.TabIndex = 1;
      this.UpdateTickets.Text = "Обновить";
      this.UpdateTickets.UseVisualStyleBackColor = true;
      this.UpdateTickets.Click += new System.EventHandler(this.UpdateTickets_Click);
      // 
      // dgv3
      // 
      this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv3.Location = new System.Drawing.Point(11, 6);
      this.dgv3.Name = "dgv3";
      this.dgv3.Size = new System.Drawing.Size(767, 291);
      this.dgv3.TabIndex = 0;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.label4);
      this.tabPage4.Controls.Add(this.UpdateLinens);
      this.tabPage4.Controls.Add(this.dgv4);
      this.tabPage4.Controls.Add(this.pictureBox4);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(791, 423);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Бельё";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // UpdateLinens
      // 
      this.UpdateLinens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.UpdateLinens.Location = new System.Drawing.Point(636, 376);
      this.UpdateLinens.Name = "UpdateLinens";
      this.UpdateLinens.Size = new System.Drawing.Size(149, 40);
      this.UpdateLinens.TabIndex = 1;
      this.UpdateLinens.Text = "Update";
      this.UpdateLinens.UseVisualStyleBackColor = true;
      this.UpdateLinens.Click += new System.EventHandler(this.UpdateLinens_Click);
      // 
      // dgv4
      // 
      this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv4.Location = new System.Drawing.Point(7, 54);
      this.dgv4.Name = "dgv4";
      this.dgv4.Size = new System.Drawing.Size(499, 362);
      this.dgv4.TabIndex = 0;
      // 
      // dataSet1
      // 
      this.dataSet1.DataSetName = "NewDataSet";
      // 
      // dataSet2
      // 
      this.dataSet2.DataSetName = "NewDataSet";
      // 
      // dataSet3
      // 
      this.dataSet3.DataSetName = "NewDataSet";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(795, 626);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(-2, -102);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(795, 626);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 7;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(-2, -102);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(795, 626);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox3.TabIndex = 7;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox4
      // 
      this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
      this.pictureBox4.Location = new System.Drawing.Point(-2, -102);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(795, 626);
      this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox4.TabIndex = 7;
      this.pictureBox4.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(193, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "Из";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(386, 20);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "До";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(215, 20);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(460, 73);
      this.label3.TabIndex = 8;
      this.label3.Text = "ПАССАЖИРЫ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(7, 12);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(509, 39);
      this.label4.TabIndex = 9;
      this.label4.Text = "Пассажиры не сдавшие бельё";
      // 
      // UserMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "UserMainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "UserMainForm";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMainForm_FormClosing);
      this.Load += new System.EventHandler(this.UserMainForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv22)).EndInit();
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
    private System.Windows.Forms.Button UpdateTickets;
    private System.Windows.Forms.DataGridView dgv3;
    private System.Data.DataSet dataSet2;
    private System.Windows.Forms.Button cancel;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.Button UpdateLinens;
    private System.Windows.Forms.DataGridView dgv4;
    private System.Data.DataSet dataSet3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.PictureBox pictureBox4;
  }
}