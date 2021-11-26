namespace LibraryCourseWork
{
  partial class RegistrationForm
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
      this.RNameLabel = new System.Windows.Forms.Label();
      this.REmailLabel = new System.Windows.Forms.Label();
      this.RSurnameLabel = new System.Windows.Forms.Label();
      this.RPasswordLabel = new System.Windows.Forms.Label();
      this.RNameTextBox = new System.Windows.Forms.TextBox();
      this.RSurenameTextBox = new System.Windows.Forms.TextBox();
      this.REmailTextBox = new System.Windows.Forms.TextBox();
      this.RPasswordTextBox = new System.Windows.Forms.TextBox();
      this.RegistrationButton = new System.Windows.Forms.Button();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.RPositionLabel = new System.Windows.Forms.Label();
      this.RPositionComboBox = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // RNameLabel
      // 
      this.RNameLabel.AutoSize = true;
      this.RNameLabel.Location = new System.Drawing.Point(277, 111);
      this.RNameLabel.Name = "RNameLabel";
      this.RNameLabel.Size = new System.Drawing.Size(29, 13);
      this.RNameLabel.TabIndex = 0;
      this.RNameLabel.Text = "Имя";
      this.RNameLabel.Click += new System.EventHandler(this.RNameLabel_Click);
      // 
      // REmailLabel
      // 
      this.REmailLabel.AutoSize = true;
      this.REmailLabel.Location = new System.Drawing.Point(277, 171);
      this.REmailLabel.Name = "REmailLabel";
      this.REmailLabel.Size = new System.Drawing.Size(32, 13);
      this.REmailLabel.TabIndex = 1;
      this.REmailLabel.Text = "Email";
      this.REmailLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // RSurnameLabel
      // 
      this.RSurnameLabel.AutoSize = true;
      this.RSurnameLabel.Location = new System.Drawing.Point(277, 141);
      this.RSurnameLabel.Name = "RSurnameLabel";
      this.RSurnameLabel.Size = new System.Drawing.Size(56, 13);
      this.RSurnameLabel.TabIndex = 2;
      this.RSurnameLabel.Text = "Фамилия";
      // 
      // RPasswordLabel
      // 
      this.RPasswordLabel.AutoSize = true;
      this.RPasswordLabel.Location = new System.Drawing.Point(277, 237);
      this.RPasswordLabel.Name = "RPasswordLabel";
      this.RPasswordLabel.Size = new System.Drawing.Size(45, 13);
      this.RPasswordLabel.TabIndex = 3;
      this.RPasswordLabel.Text = "Пароль";
      this.RPasswordLabel.Click += new System.EventHandler(this.RPasswordLabel_Click);
      // 
      // RNameTextBox
      // 
      this.RNameTextBox.Location = new System.Drawing.Point(409, 108);
      this.RNameTextBox.Name = "RNameTextBox";
      this.RNameTextBox.Size = new System.Drawing.Size(131, 20);
      this.RNameTextBox.TabIndex = 4;
      // 
      // RSurenameTextBox
      // 
      this.RSurenameTextBox.Location = new System.Drawing.Point(409, 138);
      this.RSurenameTextBox.Name = "RSurenameTextBox";
      this.RSurenameTextBox.Size = new System.Drawing.Size(131, 20);
      this.RSurenameTextBox.TabIndex = 5;
      // 
      // REmailTextBox
      // 
      this.REmailTextBox.Location = new System.Drawing.Point(409, 168);
      this.REmailTextBox.Name = "REmailTextBox";
      this.REmailTextBox.Size = new System.Drawing.Size(131, 20);
      this.REmailTextBox.TabIndex = 6;
      // 
      // RPasswordTextBox
      // 
      this.RPasswordTextBox.Location = new System.Drawing.Point(409, 234);
      this.RPasswordTextBox.Name = "RPasswordTextBox";
      this.RPasswordTextBox.Size = new System.Drawing.Size(131, 20);
      this.RPasswordTextBox.TabIndex = 7;
      // 
      // RegistrationButton
      // 
      this.RegistrationButton.Location = new System.Drawing.Point(344, 290);
      this.RegistrationButton.Name = "RegistrationButton";
      this.RegistrationButton.Size = new System.Drawing.Size(128, 23);
      this.RegistrationButton.TabIndex = 8;
      this.RegistrationButton.Text = "Зарегистрироваться";
      this.RegistrationButton.UseVisualStyleBackColor = true;
      this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-9H28KO5;Integrated Security=SSPI;Initial C" +
    "atalog=Library";
      // 
      // RPositionLabel
      // 
      this.RPositionLabel.AutoSize = true;
      this.RPositionLabel.Location = new System.Drawing.Point(277, 203);
      this.RPositionLabel.Name = "RPositionLabel";
      this.RPositionLabel.Size = new System.Drawing.Size(51, 13);
      this.RPositionLabel.TabIndex = 9;
      this.RPositionLabel.Text = "Позиция";
      // 
      // RPositionComboBox
      // 
      this.RPositionComboBox.FormattingEnabled = true;
      this.RPositionComboBox.Items.AddRange(new object[] {
            "Читатель",
            "Автор",
            "Сотрудник"});
      this.RPositionComboBox.Location = new System.Drawing.Point(409, 200);
      this.RPositionComboBox.Name = "RPositionComboBox";
      this.RPositionComboBox.Size = new System.Drawing.Size(131, 21);
      this.RPositionComboBox.TabIndex = 10;
      // 
      // RegistrationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.RPositionComboBox);
      this.Controls.Add(this.RPositionLabel);
      this.Controls.Add(this.RegistrationButton);
      this.Controls.Add(this.RPasswordTextBox);
      this.Controls.Add(this.REmailTextBox);
      this.Controls.Add(this.RSurenameTextBox);
      this.Controls.Add(this.RNameTextBox);
      this.Controls.Add(this.RPasswordLabel);
      this.Controls.Add(this.RSurnameLabel);
      this.Controls.Add(this.REmailLabel);
      this.Controls.Add(this.RNameLabel);
      this.Name = "RegistrationForm";
      this.Text = "Регистрация";
      this.Load += new System.EventHandler(this.RegistrationForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label RNameLabel;
        private System.Windows.Forms.Label REmailLabel;
        private System.Windows.Forms.Label RSurnameLabel;
        private System.Windows.Forms.Label RPasswordLabel;
        private System.Windows.Forms.TextBox RNameTextBox;
        private System.Windows.Forms.TextBox RSurenameTextBox;
        private System.Windows.Forms.TextBox REmailTextBox;
        private System.Windows.Forms.TextBox RPasswordTextBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label RPositionLabel;
        private System.Windows.Forms.ComboBox RPositionComboBox;
    }
}