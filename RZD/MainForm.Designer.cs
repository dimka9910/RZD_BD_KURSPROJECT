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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.button1 = new System.Windows.Forms.Button();
      this.LoginTextBox = new System.Windows.Forms.TextBox();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.Registration = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(53, 156);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(138, 45);
      this.button1.TabIndex = 0;
      this.button1.Text = "Enter";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // LoginTextBox
      // 
      this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LoginTextBox.Location = new System.Drawing.Point(18, 32);
      this.LoginTextBox.Name = "LoginTextBox";
      this.LoginTextBox.Size = new System.Drawing.Size(208, 38);
      this.LoginTextBox.TabIndex = 1;
      this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PasswordTextBox.Location = new System.Drawing.Point(18, 100);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.Size = new System.Drawing.Size(208, 38);
      this.PasswordTextBox.TabIndex = 2;
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=LAPTOP-5VEJHNRM;Integrated Security=SSPI;Initial C" +
    "atalog=RZD";
      // 
      // Registration
      // 
      this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Registration.Location = new System.Drawing.Point(573, 407);
      this.Registration.Name = "Registration";
      this.Registration.Size = new System.Drawing.Size(215, 31);
      this.Registration.TabIndex = 3;
      this.Registration.Text = "Registration";
      this.Registration.UseVisualStyleBackColor = true;
      this.Registration.Click += new System.EventHandler(this.Registration_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(-75, -13);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(934, 560);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 4;
      this.pictureBox1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Bisque;
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.LoginTextBox);
      this.panel1.Controls.Add(this.PasswordTextBox);
      this.panel1.Location = new System.Drawing.Point(33, 69);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(243, 218);
      this.panel1.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(109, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Login";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(99, 84);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Password";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.Registration);
      this.Controls.Add(this.pictureBox1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "MainForm";
      this.Activated += new System.EventHandler(this.MainForm_Activated);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox LoginTextBox;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Data.OleDb.OleDbConnection cn;
    private System.Windows.Forms.Button Registration;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}

