namespace RZD
{
  partial class MainForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.LoginTextBox = new System.Windows.Forms.TextBox();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(391, 236);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 36);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // LoginTextBox
      // 
      this.LoginTextBox.Location = new System.Drawing.Point(193, 109);
      this.LoginTextBox.Name = "LoginTextBox";
      this.LoginTextBox.Size = new System.Drawing.Size(208, 20);
      this.LoginTextBox.TabIndex = 1;
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(193, 153);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.Size = new System.Drawing.Size(208, 20);
      this.PasswordTextBox.TabIndex = 2;
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-5VEJHNRM;Integrated Security=SSPI;Initial C" +
    "atalog=RZD";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.LoginTextBox);
      this.Controls.Add(this.button1);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Activated += new System.EventHandler(this.MainForm_Activated);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox LoginTextBox;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Data.OleDb.OleDbConnection cn;
  }
}

