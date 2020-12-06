namespace RZD
{
  partial class UserBuyForm
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
      this.dgv22 = new System.Windows.Forms.DataGridView();
      this.dataSet1 = new System.Data.DataSet();
      this.label1 = new System.Windows.Forms.Label();
      this.Buy = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgv22)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv22
      // 
      this.dgv22.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv22.Location = new System.Drawing.Point(150, 102);
      this.dgv22.Name = "dgv22";
      this.dgv22.Size = new System.Drawing.Size(477, 188);
      this.dgv22.TabIndex = 0;
      // 
      // dataSet1
      // 
      this.dataSet1.DataSetName = "NewDataSet";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // Buy
      // 
      this.Buy.Location = new System.Drawing.Point(576, 359);
      this.Buy.Name = "Buy";
      this.Buy.Size = new System.Drawing.Size(75, 23);
      this.Buy.TabIndex = 2;
      this.Buy.Text = "Buy";
      this.Buy.UseVisualStyleBackColor = true;
      this.Buy.Click += new System.EventHandler(this.Buy_Click);
      // 
      // UserBuyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.Buy);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgv22);
      this.Name = "UserBuyForm";
      this.Text = "UserBuyForm";
      ((System.ComponentModel.ISupportInitialize)(this.dgv22)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv22;
    private System.Data.DataSet dataSet1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button Buy;
  }
}