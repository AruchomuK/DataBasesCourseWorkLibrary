namespace LibraryCourseWork
{
  partial class LibrarianForm
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
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.LibrarianMyProfileLabel = new System.Windows.Forms.Label();
      this.LibrarianUpdateButton = new System.Windows.Forms.Button();
      this.LibrarianEmailTextBox = new System.Windows.Forms.TextBox();
      this.LibrarianSurenameTextBox = new System.Windows.Forms.TextBox();
      this.LibrarianNameTextBox = new System.Windows.Forms.TextBox();
      this.LibrarianSurnameLabel = new System.Windows.Forms.Label();
      this.LibrarianEmailLabel = new System.Windows.Forms.Label();
      this.LibrarianNameLabel = new System.Windows.Forms.Label();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.NewCollectionYearLabel = new System.Windows.Forms.Label();
      this.NewCollectionNameTextBox = new System.Windows.Forms.TextBox();
      this.NewCollectionNameLabel = new System.Windows.Forms.Label();
      this.NewCollectionLabel = new System.Windows.Forms.Label();
      this.AddBookToCollectionButton = new System.Windows.Forms.Button();
      this.CollectionNameComboBox = new System.Windows.Forms.ComboBox();
      this.CollectionNameLabel = new System.Windows.Forms.Label();
      this.CollectionBookNameComboBox = new System.Windows.Forms.ComboBox();
      this.CollectionBookNameLabel = new System.Windows.Forms.Label();
      this.CollectionsAddBookLabel = new System.Windows.Forms.Label();
      this.createNewCollectionButton = new System.Windows.Forms.Button();
      this.PurchaseIDComboBox = new System.Windows.Forms.ComboBox();
      this.PurchaseIDLabel = new System.Windows.Forms.Label();
      this.PurchaseBookNameComboBox = new System.Windows.Forms.ComboBox();
      this.PurchaseBookNameLabel = new System.Windows.Forms.Label();
      this.AddBookToPurchasesLabel = new System.Windows.Forms.Label();
      this.PurchasePriceLabel = new System.Windows.Forms.Label();
      this.PurchasePriceTextBox = new System.Windows.Forms.TextBox();
      this.PurchasesLabel = new System.Windows.Forms.Label();
      this.PurchasesDS = new System.Data.DataSet();
      this.PurchasesDG = new System.Windows.Forms.DataGrid();
      this.NewCollectionYearTextBox = new System.Windows.Forms.TextBox();
      this.AddBookToPurchasesButton = new System.Windows.Forms.Button();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.AuthorInfoLabel = new System.Windows.Forms.Label();
      this.AuthorEmailTextBox = new System.Windows.Forms.TextBox();
      this.AuthorSurenameTextBox = new System.Windows.Forms.TextBox();
      this.AuthorNameTextBox = new System.Windows.Forms.TextBox();
      this.AuthorSurenameLabel = new System.Windows.Forms.Label();
      this.AuthorEmailLabel = new System.Windows.Forms.Label();
      this.AuthorNameLabel = new System.Windows.Forms.Label();
      this.AuthorBirthdayLabel = new System.Windows.Forms.Label();
      this.AuthorBirthdayDatePicker = new System.Windows.Forms.DateTimePicker();
      this.AuthorLabel = new System.Windows.Forms.Label();
      this.AuthorsComboBox = new System.Windows.Forms.ComboBox();
      this.AuthorInfoButton = new System.Windows.Forms.Button();
      this.ReaderInfoButton = new System.Windows.Forms.Button();
      this.ReadersComboBox = new System.Windows.Forms.ComboBox();
      this.ReaderLabel = new System.Windows.Forms.Label();
      this.ReaderBirthdayDatePicker = new System.Windows.Forms.DateTimePicker();
      this.ReaderBirthdayLabel = new System.Windows.Forms.Label();
      this.ReaderEmailTextBox = new System.Windows.Forms.TextBox();
      this.ReaderSurenameTextBox = new System.Windows.Forms.TextBox();
      this.ReaderNameTextBox = new System.Windows.Forms.TextBox();
      this.ReaderSurenameLabel = new System.Windows.Forms.Label();
      this.ReaderEmailLabel = new System.Windows.Forms.Label();
      this.ReaderNameLabel = new System.Windows.Forms.Label();
      this.ReaderInfoLabel = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PurchasesDS)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PurchasesDG)).BeginInit();
      this.tabPage4.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage5);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(800, 450);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.LibrarianMyProfileLabel);
      this.tabPage1.Controls.Add(this.LibrarianUpdateButton);
      this.tabPage1.Controls.Add(this.LibrarianEmailTextBox);
      this.tabPage1.Controls.Add(this.LibrarianSurenameTextBox);
      this.tabPage1.Controls.Add(this.LibrarianNameTextBox);
      this.tabPage1.Controls.Add(this.LibrarianSurnameLabel);
      this.tabPage1.Controls.Add(this.LibrarianEmailLabel);
      this.tabPage1.Controls.Add(this.LibrarianNameLabel);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 424);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Мой профиль";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.NewCollectionYearTextBox);
      this.tabPage2.Controls.Add(this.createNewCollectionButton);
      this.tabPage2.Controls.Add(this.NewCollectionYearLabel);
      this.tabPage2.Controls.Add(this.NewCollectionNameTextBox);
      this.tabPage2.Controls.Add(this.NewCollectionNameLabel);
      this.tabPage2.Controls.Add(this.NewCollectionLabel);
      this.tabPage2.Controls.Add(this.AddBookToCollectionButton);
      this.tabPage2.Controls.Add(this.CollectionNameComboBox);
      this.tabPage2.Controls.Add(this.CollectionNameLabel);
      this.tabPage2.Controls.Add(this.CollectionBookNameComboBox);
      this.tabPage2.Controls.Add(this.CollectionBookNameLabel);
      this.tabPage2.Controls.Add(this.CollectionsAddBookLabel);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 424);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Коллекции";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // LibrarianMyProfileLabel
      // 
      this.LibrarianMyProfileLabel.AutoSize = true;
      this.LibrarianMyProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.LibrarianMyProfileLabel.Location = new System.Drawing.Point(340, 78);
      this.LibrarianMyProfileLabel.Name = "LibrarianMyProfileLabel";
      this.LibrarianMyProfileLabel.Size = new System.Drawing.Size(116, 18);
      this.LibrarianMyProfileLabel.TabIndex = 38;
      this.LibrarianMyProfileLabel.Text = "Мой профиль";
      // 
      // LibrarianUpdateButton
      // 
      this.LibrarianUpdateButton.Location = new System.Drawing.Point(343, 255);
      this.LibrarianUpdateButton.Name = "LibrarianUpdateButton";
      this.LibrarianUpdateButton.Size = new System.Drawing.Size(109, 23);
      this.LibrarianUpdateButton.TabIndex = 37;
      this.LibrarianUpdateButton.Text = "Обновить данные";
      this.LibrarianUpdateButton.UseVisualStyleBackColor = true;
      this.LibrarianUpdateButton.Click += new System.EventHandler(this.LibrarianUpdateButton_Click);
      // 
      // LibrarianEmailTextBox
      // 
      this.LibrarianEmailTextBox.Location = new System.Drawing.Point(397, 202);
      this.LibrarianEmailTextBox.Name = "LibrarianEmailTextBox";
      this.LibrarianEmailTextBox.Size = new System.Drawing.Size(131, 20);
      this.LibrarianEmailTextBox.TabIndex = 36;
      // 
      // LibrarianSurenameTextBox
      // 
      this.LibrarianSurenameTextBox.Location = new System.Drawing.Point(397, 172);
      this.LibrarianSurenameTextBox.Name = "LibrarianSurenameTextBox";
      this.LibrarianSurenameTextBox.Size = new System.Drawing.Size(131, 20);
      this.LibrarianSurenameTextBox.TabIndex = 35;
      // 
      // LibrarianNameTextBox
      // 
      this.LibrarianNameTextBox.Location = new System.Drawing.Point(397, 142);
      this.LibrarianNameTextBox.Name = "LibrarianNameTextBox";
      this.LibrarianNameTextBox.Size = new System.Drawing.Size(131, 20);
      this.LibrarianNameTextBox.TabIndex = 34;
      // 
      // LibrarianSurnameLabel
      // 
      this.LibrarianSurnameLabel.AutoSize = true;
      this.LibrarianSurnameLabel.Location = new System.Drawing.Point(265, 175);
      this.LibrarianSurnameLabel.Name = "LibrarianSurnameLabel";
      this.LibrarianSurnameLabel.Size = new System.Drawing.Size(56, 13);
      this.LibrarianSurnameLabel.TabIndex = 33;
      this.LibrarianSurnameLabel.Text = "Фамилия";
      // 
      // LibrarianEmailLabel
      // 
      this.LibrarianEmailLabel.AutoSize = true;
      this.LibrarianEmailLabel.Location = new System.Drawing.Point(265, 205);
      this.LibrarianEmailLabel.Name = "LibrarianEmailLabel";
      this.LibrarianEmailLabel.Size = new System.Drawing.Size(32, 13);
      this.LibrarianEmailLabel.TabIndex = 32;
      this.LibrarianEmailLabel.Text = "Email";
      // 
      // LibrarianNameLabel
      // 
      this.LibrarianNameLabel.AutoSize = true;
      this.LibrarianNameLabel.Location = new System.Drawing.Point(265, 145);
      this.LibrarianNameLabel.Name = "LibrarianNameLabel";
      this.LibrarianNameLabel.Size = new System.Drawing.Size(29, 13);
      this.LibrarianNameLabel.TabIndex = 31;
      this.LibrarianNameLabel.Text = "Имя";
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.AddBookToPurchasesButton);
      this.tabPage3.Controls.Add(this.PurchasesDG);
      this.tabPage3.Controls.Add(this.PurchasesLabel);
      this.tabPage3.Controls.Add(this.PurchasePriceTextBox);
      this.tabPage3.Controls.Add(this.PurchasePriceLabel);
      this.tabPage3.Controls.Add(this.PurchaseIDComboBox);
      this.tabPage3.Controls.Add(this.PurchaseIDLabel);
      this.tabPage3.Controls.Add(this.PurchaseBookNameComboBox);
      this.tabPage3.Controls.Add(this.PurchaseBookNameLabel);
      this.tabPage3.Controls.Add(this.AddBookToPurchasesLabel);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(792, 424);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = " Закупки";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-9H28KO5;Integrated Security=SSPI;Initial C" +
    "atalog=Library";
      // 
      // NewCollectionYearLabel
      // 
      this.NewCollectionYearLabel.AutoSize = true;
      this.NewCollectionYearLabel.Location = new System.Drawing.Point(232, 330);
      this.NewCollectionYearLabel.Name = "NewCollectionYearLabel";
      this.NewCollectionYearLabel.Size = new System.Drawing.Size(25, 13);
      this.NewCollectionYearLabel.TabIndex = 45;
      this.NewCollectionYearLabel.Text = "Год";
      // 
      // NewCollectionNameTextBox
      // 
      this.NewCollectionNameTextBox.Location = new System.Drawing.Point(394, 291);
      this.NewCollectionNameTextBox.Name = "NewCollectionNameTextBox";
      this.NewCollectionNameTextBox.Size = new System.Drawing.Size(229, 20);
      this.NewCollectionNameTextBox.TabIndex = 44;
      // 
      // NewCollectionNameLabel
      // 
      this.NewCollectionNameLabel.AutoSize = true;
      this.NewCollectionNameLabel.Location = new System.Drawing.Point(220, 294);
      this.NewCollectionNameLabel.Name = "NewCollectionNameLabel";
      this.NewCollectionNameLabel.Size = new System.Drawing.Size(57, 13);
      this.NewCollectionNameLabel.TabIndex = 43;
      this.NewCollectionNameLabel.Text = "Название";
      // 
      // NewCollectionLabel
      // 
      this.NewCollectionLabel.AutoSize = true;
      this.NewCollectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.NewCollectionLabel.Location = new System.Drawing.Point(325, 251);
      this.NewCollectionLabel.Name = "NewCollectionLabel";
      this.NewCollectionLabel.Size = new System.Drawing.Size(146, 18);
      this.NewCollectionLabel.TabIndex = 42;
      this.NewCollectionLabel.Text = "Новая коллекция";
      this.NewCollectionLabel.Click += new System.EventHandler(this.NewCompilationLabel_Click);
      // 
      // AddBookToCollectionButton
      // 
      this.AddBookToCollectionButton.Location = new System.Drawing.Point(362, 189);
      this.AddBookToCollectionButton.Name = "AddBookToCollectionButton";
      this.AddBookToCollectionButton.Size = new System.Drawing.Size(75, 23);
      this.AddBookToCollectionButton.TabIndex = 41;
      this.AddBookToCollectionButton.Text = "Добавить";
      this.AddBookToCollectionButton.UseVisualStyleBackColor = true;
      this.AddBookToCollectionButton.Click += new System.EventHandler(this.AddBookToCollectionButton_Click);
      // 
      // CollectionNameComboBox
      // 
      this.CollectionNameComboBox.FormattingEnabled = true;
      this.CollectionNameComboBox.Location = new System.Drawing.Point(394, 143);
      this.CollectionNameComboBox.Name = "CollectionNameComboBox";
      this.CollectionNameComboBox.Size = new System.Drawing.Size(229, 21);
      this.CollectionNameComboBox.TabIndex = 40;
      // 
      // CollectionNameLabel
      // 
      this.CollectionNameLabel.AutoSize = true;
      this.CollectionNameLabel.Location = new System.Drawing.Point(220, 146);
      this.CollectionNameLabel.Name = "CollectionNameLabel";
      this.CollectionNameLabel.Size = new System.Drawing.Size(62, 13);
      this.CollectionNameLabel.TabIndex = 39;
      this.CollectionNameLabel.Text = "Коллекция";
      // 
      // CollectionBookNameComboBox
      // 
      this.CollectionBookNameComboBox.FormattingEnabled = true;
      this.CollectionBookNameComboBox.Location = new System.Drawing.Point(394, 105);
      this.CollectionBookNameComboBox.Name = "CollectionBookNameComboBox";
      this.CollectionBookNameComboBox.Size = new System.Drawing.Size(229, 21);
      this.CollectionBookNameComboBox.TabIndex = 38;
      // 
      // CollectionBookNameLabel
      // 
      this.CollectionBookNameLabel.AutoSize = true;
      this.CollectionBookNameLabel.Location = new System.Drawing.Point(220, 108);
      this.CollectionBookNameLabel.Name = "CollectionBookNameLabel";
      this.CollectionBookNameLabel.Size = new System.Drawing.Size(57, 13);
      this.CollectionBookNameLabel.TabIndex = 37;
      this.CollectionBookNameLabel.Text = "Название";
      // 
      // CollectionsAddBookLabel
      // 
      this.CollectionsAddBookLabel.AutoSize = true;
      this.CollectionsAddBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.CollectionsAddBookLabel.Location = new System.Drawing.Point(280, 57);
      this.CollectionsAddBookLabel.Name = "CollectionsAddBookLabel";
      this.CollectionsAddBookLabel.Size = new System.Drawing.Size(238, 18);
      this.CollectionsAddBookLabel.TabIndex = 36;
      this.CollectionsAddBookLabel.Text = "Добавить книгу в коллекцию";
      // 
      // createNewCollectionButton
      // 
      this.createNewCollectionButton.Location = new System.Drawing.Point(362, 373);
      this.createNewCollectionButton.Name = "createNewCollectionButton";
      this.createNewCollectionButton.Size = new System.Drawing.Size(75, 23);
      this.createNewCollectionButton.TabIndex = 47;
      this.createNewCollectionButton.Text = "Создать";
      this.createNewCollectionButton.UseVisualStyleBackColor = true;
      this.createNewCollectionButton.Click += new System.EventHandler(this.createNewCollectionButton_Click);
      // 
      // PurchaseIDComboBox
      // 
      this.PurchaseIDComboBox.FormattingEnabled = true;
      this.PurchaseIDComboBox.Location = new System.Drawing.Point(381, 121);
      this.PurchaseIDComboBox.Name = "PurchaseIDComboBox";
      this.PurchaseIDComboBox.Size = new System.Drawing.Size(100, 21);
      this.PurchaseIDComboBox.TabIndex = 45;
      // 
      // PurchaseIDLabel
      // 
      this.PurchaseIDLabel.AutoSize = true;
      this.PurchaseIDLabel.Location = new System.Drawing.Point(207, 124);
      this.PurchaseIDLabel.Name = "PurchaseIDLabel";
      this.PurchaseIDLabel.Size = new System.Drawing.Size(38, 13);
      this.PurchaseIDLabel.TabIndex = 44;
      this.PurchaseIDLabel.Text = "Заказ";
      // 
      // PurchaseBookNameComboBox
      // 
      this.PurchaseBookNameComboBox.FormattingEnabled = true;
      this.PurchaseBookNameComboBox.Location = new System.Drawing.Point(381, 92);
      this.PurchaseBookNameComboBox.Name = "PurchaseBookNameComboBox";
      this.PurchaseBookNameComboBox.Size = new System.Drawing.Size(229, 21);
      this.PurchaseBookNameComboBox.TabIndex = 43;
      // 
      // PurchaseBookNameLabel
      // 
      this.PurchaseBookNameLabel.AutoSize = true;
      this.PurchaseBookNameLabel.Location = new System.Drawing.Point(207, 95);
      this.PurchaseBookNameLabel.Name = "PurchaseBookNameLabel";
      this.PurchaseBookNameLabel.Size = new System.Drawing.Size(57, 13);
      this.PurchaseBookNameLabel.TabIndex = 42;
      this.PurchaseBookNameLabel.Text = "Название";
      // 
      // AddBookToPurchasesLabel
      // 
      this.AddBookToPurchasesLabel.AutoSize = true;
      this.AddBookToPurchasesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddBookToPurchasesLabel.Location = new System.Drawing.Point(299, 54);
      this.AddBookToPurchasesLabel.Name = "AddBookToPurchasesLabel";
      this.AddBookToPurchasesLabel.Size = new System.Drawing.Size(213, 18);
      this.AddBookToPurchasesLabel.TabIndex = 41;
      this.AddBookToPurchasesLabel.Text = "Добавить книгу в закупки";
      // 
      // PurchasePriceLabel
      // 
      this.PurchasePriceLabel.AutoSize = true;
      this.PurchasePriceLabel.Location = new System.Drawing.Point(207, 155);
      this.PurchasePriceLabel.Name = "PurchasePriceLabel";
      this.PurchasePriceLabel.Size = new System.Drawing.Size(33, 13);
      this.PurchasePriceLabel.TabIndex = 46;
      this.PurchasePriceLabel.Text = "Цена";
      // 
      // PurchasePriceTextBox
      // 
      this.PurchasePriceTextBox.Location = new System.Drawing.Point(381, 152);
      this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
      this.PurchasePriceTextBox.Size = new System.Drawing.Size(100, 20);
      this.PurchasePriceTextBox.TabIndex = 47;
      // 
      // PurchasesLabel
      // 
      this.PurchasesLabel.AutoSize = true;
      this.PurchasesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.PurchasesLabel.Location = new System.Drawing.Point(378, 264);
      this.PurchasesLabel.Name = "PurchasesLabel";
      this.PurchasesLabel.Size = new System.Drawing.Size(72, 18);
      this.PurchasesLabel.TabIndex = 61;
      this.PurchasesLabel.Text = "Закупки";
      this.PurchasesLabel.Click += new System.EventHandler(this.label7_Click);
      // 
      // PurchasesDS
      // 
      this.PurchasesDS.DataSetName = "NewDataSet";
      // 
      // PurchasesDG
      // 
      this.PurchasesDG.DataMember = "";
      this.PurchasesDG.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.PurchasesDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.PurchasesDG.Location = new System.Drawing.Point(0, 295);
      this.PurchasesDG.Name = "PurchasesDG";
      this.PurchasesDG.Size = new System.Drawing.Size(792, 129);
      this.PurchasesDG.TabIndex = 62;
      // 
      // NewCollectionYearTextBox
      // 
      this.NewCollectionYearTextBox.Location = new System.Drawing.Point(394, 327);
      this.NewCollectionYearTextBox.Name = "NewCollectionYearTextBox";
      this.NewCollectionYearTextBox.Size = new System.Drawing.Size(100, 20);
      this.NewCollectionYearTextBox.TabIndex = 48;
      // 
      // AddBookToPurchasesButton
      // 
      this.AddBookToPurchasesButton.Location = new System.Drawing.Point(375, 198);
      this.AddBookToPurchasesButton.Name = "AddBookToPurchasesButton";
      this.AddBookToPurchasesButton.Size = new System.Drawing.Size(75, 23);
      this.AddBookToPurchasesButton.TabIndex = 63;
      this.AddBookToPurchasesButton.Text = "Добавить";
      this.AddBookToPurchasesButton.UseVisualStyleBackColor = true;
      this.AddBookToPurchasesButton.Click += new System.EventHandler(this.AddBookToPurchasesButton_Click);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.AuthorInfoButton);
      this.tabPage4.Controls.Add(this.AuthorsComboBox);
      this.tabPage4.Controls.Add(this.AuthorLabel);
      this.tabPage4.Controls.Add(this.AuthorBirthdayDatePicker);
      this.tabPage4.Controls.Add(this.AuthorBirthdayLabel);
      this.tabPage4.Controls.Add(this.AuthorEmailTextBox);
      this.tabPage4.Controls.Add(this.AuthorSurenameTextBox);
      this.tabPage4.Controls.Add(this.AuthorNameTextBox);
      this.tabPage4.Controls.Add(this.AuthorSurenameLabel);
      this.tabPage4.Controls.Add(this.AuthorEmailLabel);
      this.tabPage4.Controls.Add(this.AuthorNameLabel);
      this.tabPage4.Controls.Add(this.AuthorInfoLabel);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(792, 424);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Авторы";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.ReaderInfoButton);
      this.tabPage5.Controls.Add(this.ReadersComboBox);
      this.tabPage5.Controls.Add(this.ReaderLabel);
      this.tabPage5.Controls.Add(this.ReaderBirthdayDatePicker);
      this.tabPage5.Controls.Add(this.ReaderBirthdayLabel);
      this.tabPage5.Controls.Add(this.ReaderEmailTextBox);
      this.tabPage5.Controls.Add(this.ReaderSurenameTextBox);
      this.tabPage5.Controls.Add(this.ReaderNameTextBox);
      this.tabPage5.Controls.Add(this.ReaderSurenameLabel);
      this.tabPage5.Controls.Add(this.ReaderEmailLabel);
      this.tabPage5.Controls.Add(this.ReaderNameLabel);
      this.tabPage5.Controls.Add(this.ReaderInfoLabel);
      this.tabPage5.Location = new System.Drawing.Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new System.Drawing.Size(792, 424);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Читатели";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // AuthorInfoLabel
      // 
      this.AuthorInfoLabel.AutoSize = true;
      this.AuthorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AuthorInfoLabel.Location = new System.Drawing.Point(292, 81);
      this.AuthorInfoLabel.Name = "AuthorInfoLabel";
      this.AuthorInfoLabel.Size = new System.Drawing.Size(194, 18);
      this.AuthorInfoLabel.TabIndex = 62;
      this.AuthorInfoLabel.Text = "Информация об авторе";
      // 
      // AuthorEmailTextBox
      // 
      this.AuthorEmailTextBox.Location = new System.Drawing.Point(389, 236);
      this.AuthorEmailTextBox.Name = "AuthorEmailTextBox";
      this.AuthorEmailTextBox.Size = new System.Drawing.Size(147, 20);
      this.AuthorEmailTextBox.TabIndex = 68;
      // 
      // AuthorSurenameTextBox
      // 
      this.AuthorSurenameTextBox.Location = new System.Drawing.Point(389, 206);
      this.AuthorSurenameTextBox.Name = "AuthorSurenameTextBox";
      this.AuthorSurenameTextBox.Size = new System.Drawing.Size(147, 20);
      this.AuthorSurenameTextBox.TabIndex = 67;
      // 
      // AuthorNameTextBox
      // 
      this.AuthorNameTextBox.Location = new System.Drawing.Point(389, 176);
      this.AuthorNameTextBox.Name = "AuthorNameTextBox";
      this.AuthorNameTextBox.Size = new System.Drawing.Size(147, 20);
      this.AuthorNameTextBox.TabIndex = 66;
      // 
      // AuthorSurenameLabel
      // 
      this.AuthorSurenameLabel.AutoSize = true;
      this.AuthorSurenameLabel.Location = new System.Drawing.Point(257, 209);
      this.AuthorSurenameLabel.Name = "AuthorSurenameLabel";
      this.AuthorSurenameLabel.Size = new System.Drawing.Size(56, 13);
      this.AuthorSurenameLabel.TabIndex = 65;
      this.AuthorSurenameLabel.Text = "Фамилия";
      // 
      // AuthorEmailLabel
      // 
      this.AuthorEmailLabel.AutoSize = true;
      this.AuthorEmailLabel.Location = new System.Drawing.Point(257, 239);
      this.AuthorEmailLabel.Name = "AuthorEmailLabel";
      this.AuthorEmailLabel.Size = new System.Drawing.Size(32, 13);
      this.AuthorEmailLabel.TabIndex = 64;
      this.AuthorEmailLabel.Text = "Email";
      // 
      // AuthorNameLabel
      // 
      this.AuthorNameLabel.AutoSize = true;
      this.AuthorNameLabel.Location = new System.Drawing.Point(257, 179);
      this.AuthorNameLabel.Name = "AuthorNameLabel";
      this.AuthorNameLabel.Size = new System.Drawing.Size(29, 13);
      this.AuthorNameLabel.TabIndex = 63;
      this.AuthorNameLabel.Text = "Имя";
      // 
      // AuthorBirthdayLabel
      // 
      this.AuthorBirthdayLabel.AutoSize = true;
      this.AuthorBirthdayLabel.Location = new System.Drawing.Point(257, 273);
      this.AuthorBirthdayLabel.Name = "AuthorBirthdayLabel";
      this.AuthorBirthdayLabel.Size = new System.Drawing.Size(86, 13);
      this.AuthorBirthdayLabel.TabIndex = 69;
      this.AuthorBirthdayLabel.Text = "Дата рождения";
      // 
      // AuthorBirthdayDatePicker
      // 
      this.AuthorBirthdayDatePicker.Location = new System.Drawing.Point(389, 267);
      this.AuthorBirthdayDatePicker.Name = "AuthorBirthdayDatePicker";
      this.AuthorBirthdayDatePicker.Size = new System.Drawing.Size(147, 20);
      this.AuthorBirthdayDatePicker.TabIndex = 70;
      // 
      // AuthorLabel
      // 
      this.AuthorLabel.AutoSize = true;
      this.AuthorLabel.Location = new System.Drawing.Point(199, 122);
      this.AuthorLabel.Name = "AuthorLabel";
      this.AuthorLabel.Size = new System.Drawing.Size(37, 13);
      this.AuthorLabel.TabIndex = 71;
      this.AuthorLabel.Text = "Автор";
      // 
      // AuthorsComboBox
      // 
      this.AuthorsComboBox.FormattingEnabled = true;
      this.AuthorsComboBox.Location = new System.Drawing.Point(304, 119);
      this.AuthorsComboBox.Name = "AuthorsComboBox";
      this.AuthorsComboBox.Size = new System.Drawing.Size(232, 21);
      this.AuthorsComboBox.TabIndex = 72;
      // 
      // AuthorInfoButton
      // 
      this.AuthorInfoButton.Location = new System.Drawing.Point(568, 117);
      this.AuthorInfoButton.Name = "AuthorInfoButton";
      this.AuthorInfoButton.Size = new System.Drawing.Size(75, 23);
      this.AuthorInfoButton.TabIndex = 73;
      this.AuthorInfoButton.Text = "Найти";
      this.AuthorInfoButton.UseVisualStyleBackColor = true;
      this.AuthorInfoButton.Click += new System.EventHandler(this.AuthorInfoButton_Click);
      // 
      // ReaderInfoButton
      // 
      this.ReaderInfoButton.Location = new System.Drawing.Point(562, 127);
      this.ReaderInfoButton.Name = "ReaderInfoButton";
      this.ReaderInfoButton.Size = new System.Drawing.Size(75, 23);
      this.ReaderInfoButton.TabIndex = 85;
      this.ReaderInfoButton.Text = "Найти";
      this.ReaderInfoButton.UseVisualStyleBackColor = true;
      this.ReaderInfoButton.Click += new System.EventHandler(this.ReaderInfoButton_Click);
      // 
      // ReadersComboBox
      // 
      this.ReadersComboBox.FormattingEnabled = true;
      this.ReadersComboBox.Location = new System.Drawing.Point(298, 129);
      this.ReadersComboBox.Name = "ReadersComboBox";
      this.ReadersComboBox.Size = new System.Drawing.Size(232, 21);
      this.ReadersComboBox.TabIndex = 84;
      // 
      // ReaderLabel
      // 
      this.ReaderLabel.AutoSize = true;
      this.ReaderLabel.Location = new System.Drawing.Point(193, 132);
      this.ReaderLabel.Name = "ReaderLabel";
      this.ReaderLabel.Size = new System.Drawing.Size(55, 13);
      this.ReaderLabel.TabIndex = 83;
      this.ReaderLabel.Text = "Читатель";
      // 
      // ReaderBirthdayDatePicker
      // 
      this.ReaderBirthdayDatePicker.Location = new System.Drawing.Point(383, 277);
      this.ReaderBirthdayDatePicker.Name = "ReaderBirthdayDatePicker";
      this.ReaderBirthdayDatePicker.Size = new System.Drawing.Size(147, 20);
      this.ReaderBirthdayDatePicker.TabIndex = 82;
      // 
      // ReaderBirthdayLabel
      // 
      this.ReaderBirthdayLabel.AutoSize = true;
      this.ReaderBirthdayLabel.Location = new System.Drawing.Point(251, 283);
      this.ReaderBirthdayLabel.Name = "ReaderBirthdayLabel";
      this.ReaderBirthdayLabel.Size = new System.Drawing.Size(86, 13);
      this.ReaderBirthdayLabel.TabIndex = 81;
      this.ReaderBirthdayLabel.Text = "Дата рождения";
      // 
      // ReaderEmailTextBox
      // 
      this.ReaderEmailTextBox.Location = new System.Drawing.Point(383, 246);
      this.ReaderEmailTextBox.Name = "ReaderEmailTextBox";
      this.ReaderEmailTextBox.Size = new System.Drawing.Size(147, 20);
      this.ReaderEmailTextBox.TabIndex = 80;
      // 
      // ReaderSurenameTextBox
      // 
      this.ReaderSurenameTextBox.Location = new System.Drawing.Point(383, 216);
      this.ReaderSurenameTextBox.Name = "ReaderSurenameTextBox";
      this.ReaderSurenameTextBox.Size = new System.Drawing.Size(147, 20);
      this.ReaderSurenameTextBox.TabIndex = 79;
      // 
      // ReaderNameTextBox
      // 
      this.ReaderNameTextBox.Location = new System.Drawing.Point(383, 186);
      this.ReaderNameTextBox.Name = "ReaderNameTextBox";
      this.ReaderNameTextBox.Size = new System.Drawing.Size(147, 20);
      this.ReaderNameTextBox.TabIndex = 78;
      // 
      // ReaderSurenameLabel
      // 
      this.ReaderSurenameLabel.AutoSize = true;
      this.ReaderSurenameLabel.Location = new System.Drawing.Point(251, 219);
      this.ReaderSurenameLabel.Name = "ReaderSurenameLabel";
      this.ReaderSurenameLabel.Size = new System.Drawing.Size(56, 13);
      this.ReaderSurenameLabel.TabIndex = 77;
      this.ReaderSurenameLabel.Text = "Фамилия";
      // 
      // ReaderEmailLabel
      // 
      this.ReaderEmailLabel.AutoSize = true;
      this.ReaderEmailLabel.Location = new System.Drawing.Point(251, 249);
      this.ReaderEmailLabel.Name = "ReaderEmailLabel";
      this.ReaderEmailLabel.Size = new System.Drawing.Size(32, 13);
      this.ReaderEmailLabel.TabIndex = 76;
      this.ReaderEmailLabel.Text = "Email";
      // 
      // ReaderNameLabel
      // 
      this.ReaderNameLabel.AutoSize = true;
      this.ReaderNameLabel.Location = new System.Drawing.Point(251, 189);
      this.ReaderNameLabel.Name = "ReaderNameLabel";
      this.ReaderNameLabel.Size = new System.Drawing.Size(29, 13);
      this.ReaderNameLabel.TabIndex = 75;
      this.ReaderNameLabel.Text = "Имя";
      // 
      // ReaderInfoLabel
      // 
      this.ReaderInfoLabel.AutoSize = true;
      this.ReaderInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ReaderInfoLabel.Location = new System.Drawing.Point(286, 91);
      this.ReaderInfoLabel.Name = "ReaderInfoLabel";
      this.ReaderInfoLabel.Size = new System.Drawing.Size(201, 18);
      this.ReaderInfoLabel.TabIndex = 74;
      this.ReaderInfoLabel.Text = "Информация о читателе";
      // 
      // LibrarianForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "LibrarianForm";
      this.Text = "Я - сотрудник";
      this.Load += new System.EventHandler(this.LibrarianForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PurchasesDS)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PurchasesDG)).EndInit();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LibrarianMyProfileLabel;
        private System.Windows.Forms.Button LibrarianUpdateButton;
        private System.Windows.Forms.TextBox LibrarianEmailTextBox;
        private System.Windows.Forms.TextBox LibrarianSurenameTextBox;
        private System.Windows.Forms.TextBox LibrarianNameTextBox;
        private System.Windows.Forms.Label LibrarianSurnameLabel;
        private System.Windows.Forms.Label LibrarianEmailLabel;
        private System.Windows.Forms.Label LibrarianNameLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label NewCollectionYearLabel;
        private System.Windows.Forms.TextBox NewCollectionNameTextBox;
        private System.Windows.Forms.Label NewCollectionNameLabel;
        private System.Windows.Forms.Label NewCollectionLabel;
        private System.Windows.Forms.Button AddBookToCollectionButton;
        private System.Windows.Forms.ComboBox CollectionNameComboBox;
        private System.Windows.Forms.Label CollectionNameLabel;
        private System.Windows.Forms.ComboBox CollectionBookNameComboBox;
        private System.Windows.Forms.Label CollectionBookNameLabel;
        private System.Windows.Forms.Label CollectionsAddBookLabel;
        private System.Windows.Forms.Button createNewCollectionButton;
        private System.Windows.Forms.TextBox PurchasePriceTextBox;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.ComboBox PurchaseIDComboBox;
        private System.Windows.Forms.Label PurchaseIDLabel;
        private System.Windows.Forms.ComboBox PurchaseBookNameComboBox;
        private System.Windows.Forms.Label PurchaseBookNameLabel;
        private System.Windows.Forms.Label AddBookToPurchasesLabel;
        private System.Windows.Forms.Label PurchasesLabel;
        private System.Data.DataSet PurchasesDS;
        private System.Windows.Forms.DataGrid PurchasesDG;
        private System.Windows.Forms.TextBox NewCollectionYearTextBox;
        private System.Windows.Forms.Button AddBookToPurchasesButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button AuthorInfoButton;
        private System.Windows.Forms.ComboBox AuthorsComboBox;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.DateTimePicker AuthorBirthdayDatePicker;
        private System.Windows.Forms.Label AuthorBirthdayLabel;
        private System.Windows.Forms.TextBox AuthorEmailTextBox;
        private System.Windows.Forms.TextBox AuthorSurenameTextBox;
        private System.Windows.Forms.TextBox AuthorNameTextBox;
        private System.Windows.Forms.Label AuthorSurenameLabel;
        private System.Windows.Forms.Label AuthorEmailLabel;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label AuthorInfoLabel;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button ReaderInfoButton;
        private System.Windows.Forms.ComboBox ReadersComboBox;
        private System.Windows.Forms.Label ReaderLabel;
        private System.Windows.Forms.DateTimePicker ReaderBirthdayDatePicker;
        private System.Windows.Forms.Label ReaderBirthdayLabel;
        private System.Windows.Forms.TextBox ReaderEmailTextBox;
        private System.Windows.Forms.TextBox ReaderSurenameTextBox;
        private System.Windows.Forms.TextBox ReaderNameTextBox;
        private System.Windows.Forms.Label ReaderSurenameLabel;
        private System.Windows.Forms.Label ReaderEmailLabel;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.Label ReaderInfoLabel;
    }
}