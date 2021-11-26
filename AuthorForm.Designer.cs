namespace LibraryCourseWork
{
  partial class AuthorForm
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
      this.AuthorMyProfileLabel = new System.Windows.Forms.Label();
      this.AuthorUpdateButton = new System.Windows.Forms.Button();
      this.AuthorEmailTextBox = new System.Windows.Forms.TextBox();
      this.AuthorSurenameTextBox = new System.Windows.Forms.TextBox();
      this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
      this.AuthorSurnameLabel = new System.Windows.Forms.Label();
      this.AuthorEmailLabel = new System.Windows.Forms.Label();
      this.AuthorNameLabel = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.AuthorBookYearTextBox = new System.Windows.Forms.TextBox();
      this.AuthorBookNameTextBox = new System.Windows.Forms.TextBox();
      this.AuthorAddBookButton = new System.Windows.Forms.Button();
      this.AuthorGenreComboBox = new System.Windows.Forms.ComboBox();
      this.AuthorPublisherComboBox = new System.Windows.Forms.ComboBox();
      this.AuthorBooksDG = new System.Windows.Forms.DataGrid();
      this.AuthorMyBooksLabel = new System.Windows.Forms.Label();
      this.AuthorGenreLabel = new System.Windows.Forms.Label();
      this.AuthorPublisherLabel = new System.Windows.Forms.Label();
      this.AuthorYearLabel = new System.Windows.Forms.Label();
      this.AuthorAddBookLabel = new System.Windows.Forms.Label();
      this.AuthorBookNameLabel = new System.Windows.Forms.Label();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.CompilationsAddBookLabel = new System.Windows.Forms.Label();
      this.CompilationsBookNameLabel = new System.Windows.Forms.Label();
      this.CompilationsBookNameComboBox = new System.Windows.Forms.ComboBox();
      this.CompilationNameComboBox = new System.Windows.Forms.ComboBox();
      this.CompilationNameLabel = new System.Windows.Forms.Label();
      this.AddBookToCompilationButton = new System.Windows.Forms.Button();
      this.NewCompilationLabel = new System.Windows.Forms.Label();
      this.NewCompilationNameLabel = new System.Windows.Forms.Label();
      this.AddCompilationTextBox = new System.Windows.Forms.TextBox();
      this.createNewCompilationButton = new System.Windows.Forms.Button();
      this.AuthorBooksDS = new System.Data.DataSet();
      this.NewCompilationGenreLabel = new System.Windows.Forms.Label();
      this.NewCompilationGenreComboBox = new System.Windows.Forms.ComboBox();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AuthorBooksDG)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AuthorBooksDS)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(800, 450);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.AuthorMyProfileLabel);
      this.tabPage1.Controls.Add(this.AuthorUpdateButton);
      this.tabPage1.Controls.Add(this.AuthorEmailTextBox);
      this.tabPage1.Controls.Add(this.AuthorSurenameTextBox);
      this.tabPage1.Controls.Add(this.AuthorNameTextBox);
      this.tabPage1.Controls.Add(this.AuthorSurnameLabel);
      this.tabPage1.Controls.Add(this.AuthorEmailLabel);
      this.tabPage1.Controls.Add(this.AuthorNameLabel);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 424);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Мой профиль";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
      // 
      // AuthorMyProfileLabel
      // 
      this.AuthorMyProfileLabel.AutoSize = true;
      this.AuthorMyProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AuthorMyProfileLabel.Location = new System.Drawing.Point(336, 65);
      this.AuthorMyProfileLabel.Name = "AuthorMyProfileLabel";
      this.AuthorMyProfileLabel.Size = new System.Drawing.Size(116, 18);
      this.AuthorMyProfileLabel.TabIndex = 22;
      this.AuthorMyProfileLabel.Text = "Мой профиль";
      // 
      // AuthorUpdateButton
      // 
      this.AuthorUpdateButton.Location = new System.Drawing.Point(339, 242);
      this.AuthorUpdateButton.Name = "AuthorUpdateButton";
      this.AuthorUpdateButton.Size = new System.Drawing.Size(109, 23);
      this.AuthorUpdateButton.TabIndex = 21;
      this.AuthorUpdateButton.Text = "Обновить данные";
      this.AuthorUpdateButton.UseVisualStyleBackColor = true;
      this.AuthorUpdateButton.Click += new System.EventHandler(this.AuthorUpdateButton_Click);
      // 
      // AuthorEmailTextBox
      // 
      this.AuthorEmailTextBox.Location = new System.Drawing.Point(393, 189);
      this.AuthorEmailTextBox.Name = "AuthorEmailTextBox";
      this.AuthorEmailTextBox.Size = new System.Drawing.Size(131, 20);
      this.AuthorEmailTextBox.TabIndex = 20;
      // 
      // AuthorSurenameTextBox
      // 
      this.AuthorSurenameTextBox.Location = new System.Drawing.Point(393, 159);
      this.AuthorSurenameTextBox.Name = "AuthorSurenameTextBox";
      this.AuthorSurenameTextBox.Size = new System.Drawing.Size(131, 20);
      this.AuthorSurenameTextBox.TabIndex = 19;
      // 
      // AuthorNameTextBox
      // 
      this.AuthorNameTextBox.Location = new System.Drawing.Point(393, 129);
      this.AuthorNameTextBox.Name = "AuthorNameTextBox";
      this.AuthorNameTextBox.Size = new System.Drawing.Size(131, 20);
      this.AuthorNameTextBox.TabIndex = 18;
      // 
      // AuthorSurnameLabel
      // 
      this.AuthorSurnameLabel.AutoSize = true;
      this.AuthorSurnameLabel.Location = new System.Drawing.Point(261, 162);
      this.AuthorSurnameLabel.Name = "AuthorSurnameLabel";
      this.AuthorSurnameLabel.Size = new System.Drawing.Size(56, 13);
      this.AuthorSurnameLabel.TabIndex = 17;
      this.AuthorSurnameLabel.Text = "Фамилия";
      // 
      // AuthorEmailLabel
      // 
      this.AuthorEmailLabel.AutoSize = true;
      this.AuthorEmailLabel.Location = new System.Drawing.Point(261, 192);
      this.AuthorEmailLabel.Name = "AuthorEmailLabel";
      this.AuthorEmailLabel.Size = new System.Drawing.Size(32, 13);
      this.AuthorEmailLabel.TabIndex = 16;
      this.AuthorEmailLabel.Text = "Email";
      // 
      // AuthorNameLabel
      // 
      this.AuthorNameLabel.AutoSize = true;
      this.AuthorNameLabel.Location = new System.Drawing.Point(261, 132);
      this.AuthorNameLabel.Name = "AuthorNameLabel";
      this.AuthorNameLabel.Size = new System.Drawing.Size(29, 13);
      this.AuthorNameLabel.TabIndex = 15;
      this.AuthorNameLabel.Text = "Имя";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.AuthorBookYearTextBox);
      this.tabPage2.Controls.Add(this.AuthorBookNameTextBox);
      this.tabPage2.Controls.Add(this.AuthorAddBookButton);
      this.tabPage2.Controls.Add(this.AuthorGenreComboBox);
      this.tabPage2.Controls.Add(this.AuthorPublisherComboBox);
      this.tabPage2.Controls.Add(this.AuthorBooksDG);
      this.tabPage2.Controls.Add(this.AuthorMyBooksLabel);
      this.tabPage2.Controls.Add(this.AuthorGenreLabel);
      this.tabPage2.Controls.Add(this.AuthorPublisherLabel);
      this.tabPage2.Controls.Add(this.AuthorYearLabel);
      this.tabPage2.Controls.Add(this.AuthorAddBookLabel);
      this.tabPage2.Controls.Add(this.AuthorBookNameLabel);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 424);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Мои книги";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
      // 
      // AuthorBookYearTextBox
      // 
      this.AuthorBookYearTextBox.Location = new System.Drawing.Point(426, 106);
      this.AuthorBookYearTextBox.Name = "AuthorBookYearTextBox";
      this.AuthorBookYearTextBox.Size = new System.Drawing.Size(99, 20);
      this.AuthorBookYearTextBox.TabIndex = 33;
      // 
      // AuthorBookNameTextBox
      // 
      this.AuthorBookNameTextBox.Location = new System.Drawing.Point(426, 71);
      this.AuthorBookNameTextBox.Name = "AuthorBookNameTextBox";
      this.AuthorBookNameTextBox.Size = new System.Drawing.Size(238, 20);
      this.AuthorBookNameTextBox.TabIndex = 32;
      // 
      // AuthorAddBookButton
      // 
      this.AuthorAddBookButton.Location = new System.Drawing.Point(354, 226);
      this.AuthorAddBookButton.Name = "AuthorAddBookButton";
      this.AuthorAddBookButton.Size = new System.Drawing.Size(75, 23);
      this.AuthorAddBookButton.TabIndex = 31;
      this.AuthorAddBookButton.Text = "Добавить";
      this.AuthorAddBookButton.UseVisualStyleBackColor = true;
      this.AuthorAddBookButton.Click += new System.EventHandler(this.AuthorAddBookButton_Click);
      // 
      // AuthorGenreComboBox
      // 
      this.AuthorGenreComboBox.FormattingEnabled = true;
      this.AuthorGenreComboBox.Location = new System.Drawing.Point(426, 177);
      this.AuthorGenreComboBox.Name = "AuthorGenreComboBox";
      this.AuthorGenreComboBox.Size = new System.Drawing.Size(189, 21);
      this.AuthorGenreComboBox.TabIndex = 30;
      // 
      // AuthorPublisherComboBox
      // 
      this.AuthorPublisherComboBox.FormattingEnabled = true;
      this.AuthorPublisherComboBox.Location = new System.Drawing.Point(426, 140);
      this.AuthorPublisherComboBox.Name = "AuthorPublisherComboBox";
      this.AuthorPublisherComboBox.Size = new System.Drawing.Size(189, 21);
      this.AuthorPublisherComboBox.TabIndex = 29;
      // 
      // AuthorBooksDG
      // 
      this.AuthorBooksDG.DataMember = "";
      this.AuthorBooksDG.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.AuthorBooksDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.AuthorBooksDG.Location = new System.Drawing.Point(3, 313);
      this.AuthorBooksDG.Name = "AuthorBooksDG";
      this.AuthorBooksDG.Size = new System.Drawing.Size(786, 108);
      this.AuthorBooksDG.TabIndex = 28;
      // 
      // AuthorMyBooksLabel
      // 
      this.AuthorMyBooksLabel.AutoSize = true;
      this.AuthorMyBooksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AuthorMyBooksLabel.Location = new System.Drawing.Point(351, 279);
      this.AuthorMyBooksLabel.Name = "AuthorMyBooksLabel";
      this.AuthorMyBooksLabel.Size = new System.Drawing.Size(89, 18);
      this.AuthorMyBooksLabel.TabIndex = 27;
      this.AuthorMyBooksLabel.Text = "Мои книги";
      // 
      // AuthorGenreLabel
      // 
      this.AuthorGenreLabel.AutoSize = true;
      this.AuthorGenreLabel.Location = new System.Drawing.Point(232, 180);
      this.AuthorGenreLabel.Name = "AuthorGenreLabel";
      this.AuthorGenreLabel.Size = new System.Drawing.Size(36, 13);
      this.AuthorGenreLabel.TabIndex = 26;
      this.AuthorGenreLabel.Text = "Жанр";
      // 
      // AuthorPublisherLabel
      // 
      this.AuthorPublisherLabel.AutoSize = true;
      this.AuthorPublisherLabel.Location = new System.Drawing.Point(232, 143);
      this.AuthorPublisherLabel.Name = "AuthorPublisherLabel";
      this.AuthorPublisherLabel.Size = new System.Drawing.Size(79, 13);
      this.AuthorPublisherLabel.TabIndex = 25;
      this.AuthorPublisherLabel.Text = "Издательство";
      // 
      // AuthorYearLabel
      // 
      this.AuthorYearLabel.AutoSize = true;
      this.AuthorYearLabel.Location = new System.Drawing.Point(232, 109);
      this.AuthorYearLabel.Name = "AuthorYearLabel";
      this.AuthorYearLabel.Size = new System.Drawing.Size(25, 13);
      this.AuthorYearLabel.TabIndex = 24;
      this.AuthorYearLabel.Text = "Год";
      // 
      // AuthorAddBookLabel
      // 
      this.AuthorAddBookLabel.AutoSize = true;
      this.AuthorAddBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AuthorAddBookLabel.Location = new System.Drawing.Point(326, 36);
      this.AuthorAddBookLabel.Name = "AuthorAddBookLabel";
      this.AuthorAddBookLabel.Size = new System.Drawing.Size(132, 18);
      this.AuthorAddBookLabel.TabIndex = 23;
      this.AuthorAddBookLabel.Text = "Добавить книгу";
      this.AuthorAddBookLabel.Click += new System.EventHandler(this.AuthorAddBookLabel_Click);
      // 
      // AuthorBookNameLabel
      // 
      this.AuthorBookNameLabel.AutoSize = true;
      this.AuthorBookNameLabel.Location = new System.Drawing.Point(232, 74);
      this.AuthorBookNameLabel.Name = "AuthorBookNameLabel";
      this.AuthorBookNameLabel.Size = new System.Drawing.Size(57, 13);
      this.AuthorBookNameLabel.TabIndex = 0;
      this.AuthorBookNameLabel.Text = "Название";
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.NewCompilationGenreComboBox);
      this.tabPage3.Controls.Add(this.NewCompilationGenreLabel);
      this.tabPage3.Controls.Add(this.createNewCompilationButton);
      this.tabPage3.Controls.Add(this.AddCompilationTextBox);
      this.tabPage3.Controls.Add(this.NewCompilationNameLabel);
      this.tabPage3.Controls.Add(this.NewCompilationLabel);
      this.tabPage3.Controls.Add(this.AddBookToCompilationButton);
      this.tabPage3.Controls.Add(this.CompilationNameComboBox);
      this.tabPage3.Controls.Add(this.CompilationNameLabel);
      this.tabPage3.Controls.Add(this.CompilationsBookNameComboBox);
      this.tabPage3.Controls.Add(this.CompilationsBookNameLabel);
      this.tabPage3.Controls.Add(this.CompilationsAddBookLabel);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(792, 424);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Мои сборники";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-9H28KO5;Integrated Security=SSPI;Initial C" +
    "atalog=Library";
      // 
      // CompilationsAddBookLabel
      // 
      this.CompilationsAddBookLabel.AutoSize = true;
      this.CompilationsAddBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CompilationsAddBookLabel.Location = new System.Drawing.Point(290, 38);
      this.CompilationsAddBookLabel.Name = "CompilationsAddBookLabel";
      this.CompilationsAddBookLabel.Size = new System.Drawing.Size(216, 18);
      this.CompilationsAddBookLabel.TabIndex = 24;
      this.CompilationsAddBookLabel.Text = "Добавить книгу в сборник";
      this.CompilationsAddBookLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // CompilationsBookNameLabel
      // 
      this.CompilationsBookNameLabel.AutoSize = true;
      this.CompilationsBookNameLabel.Location = new System.Drawing.Point(230, 89);
      this.CompilationsBookNameLabel.Name = "CompilationsBookNameLabel";
      this.CompilationsBookNameLabel.Size = new System.Drawing.Size(57, 13);
      this.CompilationsBookNameLabel.TabIndex = 25;
      this.CompilationsBookNameLabel.Text = "Название";
      // 
      // CompilationsBookNameComboBox
      // 
      this.CompilationsBookNameComboBox.FormattingEnabled = true;
      this.CompilationsBookNameComboBox.Location = new System.Drawing.Point(404, 86);
      this.CompilationsBookNameComboBox.Name = "CompilationsBookNameComboBox";
      this.CompilationsBookNameComboBox.Size = new System.Drawing.Size(229, 21);
      this.CompilationsBookNameComboBox.TabIndex = 26;
      // 
      // CompilationNameComboBox
      // 
      this.CompilationNameComboBox.FormattingEnabled = true;
      this.CompilationNameComboBox.Location = new System.Drawing.Point(404, 124);
      this.CompilationNameComboBox.Name = "CompilationNameComboBox";
      this.CompilationNameComboBox.Size = new System.Drawing.Size(229, 21);
      this.CompilationNameComboBox.TabIndex = 28;
      // 
      // CompilationNameLabel
      // 
      this.CompilationNameLabel.AutoSize = true;
      this.CompilationNameLabel.Location = new System.Drawing.Point(230, 127);
      this.CompilationNameLabel.Name = "CompilationNameLabel";
      this.CompilationNameLabel.Size = new System.Drawing.Size(50, 13);
      this.CompilationNameLabel.TabIndex = 27;
      this.CompilationNameLabel.Text = "Сборник";
      this.CompilationNameLabel.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // AddBookToCompilationButton
      // 
      this.AddBookToCompilationButton.Location = new System.Drawing.Point(361, 171);
      this.AddBookToCompilationButton.Name = "AddBookToCompilationButton";
      this.AddBookToCompilationButton.Size = new System.Drawing.Size(75, 23);
      this.AddBookToCompilationButton.TabIndex = 29;
      this.AddBookToCompilationButton.Text = "Добавить";
      this.AddBookToCompilationButton.UseVisualStyleBackColor = true;
      this.AddBookToCompilationButton.Click += new System.EventHandler(this.AddBookToCompilationButton_Click);
      // 
      // NewCompilationLabel
      // 
      this.NewCompilationLabel.AutoSize = true;
      this.NewCompilationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.NewCompilationLabel.Location = new System.Drawing.Point(336, 237);
      this.NewCompilationLabel.Name = "NewCompilationLabel";
      this.NewCompilationLabel.Size = new System.Drawing.Size(130, 18);
      this.NewCompilationLabel.TabIndex = 30;
      this.NewCompilationLabel.Text = "Новый сборник";
      // 
      // NewCompilationNameLabel
      // 
      this.NewCompilationNameLabel.AutoSize = true;
      this.NewCompilationNameLabel.Location = new System.Drawing.Point(230, 275);
      this.NewCompilationNameLabel.Name = "NewCompilationNameLabel";
      this.NewCompilationNameLabel.Size = new System.Drawing.Size(57, 13);
      this.NewCompilationNameLabel.TabIndex = 31;
      this.NewCompilationNameLabel.Text = "Название";
      // 
      // AddCompilationTextBox
      // 
      this.AddCompilationTextBox.Location = new System.Drawing.Point(404, 272);
      this.AddCompilationTextBox.Name = "AddCompilationTextBox";
      this.AddCompilationTextBox.Size = new System.Drawing.Size(229, 20);
      this.AddCompilationTextBox.TabIndex = 32;
      // 
      // createNewCompilationButton
      // 
      this.createNewCompilationButton.Location = new System.Drawing.Point(361, 357);
      this.createNewCompilationButton.Name = "createNewCompilationButton";
      this.createNewCompilationButton.Size = new System.Drawing.Size(75, 23);
      this.createNewCompilationButton.TabIndex = 33;
      this.createNewCompilationButton.Text = "Создать";
      this.createNewCompilationButton.UseVisualStyleBackColor = true;
      this.createNewCompilationButton.Click += new System.EventHandler(this.createNewCompilationButton_Click);
      // 
      // AuthorBooksDS
      // 
      this.AuthorBooksDS.DataSetName = "NewDataSet";
      // 
      // NewCompilationGenreLabel
      // 
      this.NewCompilationGenreLabel.AutoSize = true;
      this.NewCompilationGenreLabel.Location = new System.Drawing.Point(230, 311);
      this.NewCompilationGenreLabel.Name = "NewCompilationGenreLabel";
      this.NewCompilationGenreLabel.Size = new System.Drawing.Size(57, 13);
      this.NewCompilationGenreLabel.TabIndex = 34;
      this.NewCompilationGenreLabel.Text = "Тематика";
      // 
      // NewCompilationGenreComboBox
      // 
      this.NewCompilationGenreComboBox.FormattingEnabled = true;
      this.NewCompilationGenreComboBox.Location = new System.Drawing.Point(404, 308);
      this.NewCompilationGenreComboBox.Name = "NewCompilationGenreComboBox";
      this.NewCompilationGenreComboBox.Size = new System.Drawing.Size(229, 21);
      this.NewCompilationGenreComboBox.TabIndex = 35;
      // 
      // AuthorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "AuthorForm";
      this.Text = "Я - Автор";
      this.Load += new System.EventHandler(this.AuthorForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AuthorBooksDG)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.AuthorBooksDS)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label AuthorMyProfileLabel;
        private System.Windows.Forms.Button AuthorUpdateButton;
        private System.Windows.Forms.TextBox AuthorEmailTextBox;
        private System.Windows.Forms.TextBox AuthorSurenameTextBox;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.Label AuthorSurnameLabel;
        private System.Windows.Forms.Label AuthorEmailLabel;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label AuthorAddBookLabel;
        private System.Windows.Forms.Label AuthorBookNameLabel;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.DataGrid AuthorBooksDG;
        private System.Windows.Forms.Label AuthorMyBooksLabel;
        private System.Windows.Forms.Label AuthorGenreLabel;
        private System.Windows.Forms.Label AuthorPublisherLabel;
        private System.Windows.Forms.Label AuthorYearLabel;
        private System.Windows.Forms.TextBox AuthorBookYearTextBox;
        private System.Windows.Forms.TextBox AuthorBookNameTextBox;
        private System.Windows.Forms.Button AuthorAddBookButton;
        private System.Windows.Forms.ComboBox AuthorGenreComboBox;
        private System.Windows.Forms.ComboBox AuthorPublisherComboBox;
        private System.Windows.Forms.Label CompilationsAddBookLabel;
        private System.Windows.Forms.ComboBox CompilationNameComboBox;
        private System.Windows.Forms.Label CompilationNameLabel;
        private System.Windows.Forms.ComboBox CompilationsBookNameComboBox;
        private System.Windows.Forms.Label CompilationsBookNameLabel;
        private System.Windows.Forms.Button AddBookToCompilationButton;
        private System.Windows.Forms.Button createNewCompilationButton;
        private System.Windows.Forms.TextBox AddCompilationTextBox;
        private System.Windows.Forms.Label NewCompilationNameLabel;
        private System.Windows.Forms.Label NewCompilationLabel;
        private System.Data.DataSet AuthorBooksDS;
        private System.Windows.Forms.ComboBox NewCompilationGenreComboBox;
        private System.Windows.Forms.Label NewCompilationGenreLabel;
    }
}