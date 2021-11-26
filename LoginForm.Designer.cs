namespace LibraryCourseWork
{
  partial class LoginForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.NameLabel = new System.Windows.Forms.Label();
      this.PasswordLabel = new System.Windows.Forms.Label();
      this.EmailTextBox = new System.Windows.Forms.TextBox();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.LoginButton = new System.Windows.Forms.Button();
      this.RegistrationLink = new System.Windows.Forms.LinkLabel();
      this.RegistrationLabel = new System.Windows.Forms.Label();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.SuspendLayout();
      // 
      // NameLabel
      // 
      this.NameLabel.AutoSize = true;
      this.NameLabel.Location = new System.Drawing.Point(237, 119);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(32, 13);
      this.NameLabel.TabIndex = 0;
      this.NameLabel.Text = "Email";
      this.NameLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // PasswordLabel
      // 
      this.PasswordLabel.AutoSize = true;
      this.PasswordLabel.Location = new System.Drawing.Point(237, 166);
      this.PasswordLabel.Name = "PasswordLabel";
      this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
      this.PasswordLabel.TabIndex = 1;
      this.PasswordLabel.Text = "Пароль";
      // 
      // EmailTextBox
      // 
      this.EmailTextBox.Location = new System.Drawing.Point(342, 116);
      this.EmailTextBox.Name = "EmailTextBox";
      this.EmailTextBox.Size = new System.Drawing.Size(199, 20);
      this.EmailTextBox.TabIndex = 2;
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(342, 163);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.Size = new System.Drawing.Size(199, 20);
      this.PasswordTextBox.TabIndex = 3;
      this.PasswordTextBox.UseSystemPasswordChar = true;
      // 
      // LoginButton
      // 
      this.LoginButton.Location = new System.Drawing.Point(342, 224);
      this.LoginButton.Name = "LoginButton";
      this.LoginButton.Size = new System.Drawing.Size(94, 23);
      this.LoginButton.TabIndex = 4;
      this.LoginButton.Text = "Войти";
      this.LoginButton.UseVisualStyleBackColor = true;
      this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
      // 
      // RegistrationLink
      // 
      this.RegistrationLink.AutoSize = true;
      this.RegistrationLink.Location = new System.Drawing.Point(428, 281);
      this.RegistrationLink.Name = "RegistrationLink";
      this.RegistrationLink.Size = new System.Drawing.Size(113, 13);
      this.RegistrationLink.TabIndex = 5;
      this.RegistrationLink.TabStop = true;
      this.RegistrationLink.Text = "Зарегистрироваться";
      this.RegistrationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationLink_LinkClicked);
      // 
      // RegistrationLabel
      // 
      this.RegistrationLabel.AutoSize = true;
      this.RegistrationLabel.Location = new System.Drawing.Point(212, 281);
      this.RegistrationLabel.Name = "RegistrationLabel";
      this.RegistrationLabel.Size = new System.Drawing.Size(144, 13);
      this.RegistrationLabel.TabIndex = 6;
      this.RegistrationLabel.Text = "У Вас нет учетной записи?";
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-9H28KO5;Integrated Security=SSPI;Initial C" +
    "atalog=Library";
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.RegistrationLabel);
      this.Controls.Add(this.RegistrationLink);
      this.Controls.Add(this.LoginButton);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.EmailTextBox);
      this.Controls.Add(this.PasswordLabel);
      this.Controls.Add(this.NameLabel);
      this.Name = "LoginForm";
      this.Text = "Авторизация";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel RegistrationLink;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Data.OleDb.OleDbConnection cn;
    }
}

