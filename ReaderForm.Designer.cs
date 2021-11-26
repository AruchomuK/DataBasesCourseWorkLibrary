namespace LibraryCourseWork
{
  partial class ReaderForm
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
      this.ReaderProfileTab = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.MyProfileLabel = new System.Windows.Forms.Label();
      this.ReaderUpdateButton = new System.Windows.Forms.Button();
      this.ReaderEmailTextBox = new System.Windows.Forms.TextBox();
      this.ReaderSurenameTextBox = new System.Windows.Forms.TextBox();
      this.ReaderNameTextBox = new System.Windows.Forms.TextBox();
      this.ReaderSurnameLabel = new System.Windows.Forms.Label();
      this.ReaderEmailLabel = new System.Windows.Forms.Label();
      this.ReaderNameLabel = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.ReaderOrdersDG = new System.Windows.Forms.DataGrid();
      this.AddOrderButton = new System.Windows.Forms.Button();
      this.OrdersHistoryLabel = new System.Windows.Forms.Label();
      this.ReturnDatePicker = new System.Windows.Forms.DateTimePicker();
      this.ReturnTimeLabel = new System.Windows.Forms.Label();
      this.BorrowDateLabel = new System.Windows.Forms.Label();
      this.BorrowDatePicker = new System.Windows.Forms.DateTimePicker();
      this.BookNameLabel = new System.Windows.Forms.Label();
      this.BookNameComboBox = new System.Windows.Forms.ComboBox();
      this.AddOrderLabel = new System.Windows.Forms.Label();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.AddReviewButton = new System.Windows.Forms.Button();
      this.ReviewComboBox = new System.Windows.Forms.ComboBox();
      this.ReviewLabel = new System.Windows.Forms.Label();
      this.ReviewBookNameLabel = new System.Windows.Forms.Label();
      this.ReviewBookNameComboBox = new System.Windows.Forms.ComboBox();
      this.AddReviewLabel = new System.Windows.Forms.Label();
      this.cn = new System.Data.OleDb.OleDbConnection();
      this.ReaderOrdersDS = new System.Data.DataSet();
      this.ReaderProfileTab.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ReaderOrdersDG)).BeginInit();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ReaderOrdersDS)).BeginInit();
      this.SuspendLayout();
      // 
      // ReaderProfileTab
      // 
      this.ReaderProfileTab.Controls.Add(this.tabPage1);
      this.ReaderProfileTab.Controls.Add(this.tabPage2);
      this.ReaderProfileTab.Controls.Add(this.tabPage3);
      this.ReaderProfileTab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ReaderProfileTab.Location = new System.Drawing.Point(0, 0);
      this.ReaderProfileTab.Name = "ReaderProfileTab";
      this.ReaderProfileTab.SelectedIndex = 0;
      this.ReaderProfileTab.Size = new System.Drawing.Size(800, 450);
      this.ReaderProfileTab.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.MyProfileLabel);
      this.tabPage1.Controls.Add(this.ReaderUpdateButton);
      this.tabPage1.Controls.Add(this.ReaderEmailTextBox);
      this.tabPage1.Controls.Add(this.ReaderSurenameTextBox);
      this.tabPage1.Controls.Add(this.ReaderNameTextBox);
      this.tabPage1.Controls.Add(this.ReaderSurnameLabel);
      this.tabPage1.Controls.Add(this.ReaderEmailLabel);
      this.tabPage1.Controls.Add(this.ReaderNameLabel);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 424);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Мой профиль";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
      // 
      // MyProfileLabel
      // 
      this.MyProfileLabel.AutoSize = true;
      this.MyProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MyProfileLabel.Location = new System.Drawing.Point(335, 50);
      this.MyProfileLabel.Name = "MyProfileLabel";
      this.MyProfileLabel.Size = new System.Drawing.Size(116, 18);
      this.MyProfileLabel.TabIndex = 14;
      this.MyProfileLabel.Text = "Мой профиль";
      // 
      // ReaderUpdateButton
      // 
      this.ReaderUpdateButton.Location = new System.Drawing.Point(338, 227);
      this.ReaderUpdateButton.Name = "ReaderUpdateButton";
      this.ReaderUpdateButton.Size = new System.Drawing.Size(109, 23);
      this.ReaderUpdateButton.TabIndex = 13;
      this.ReaderUpdateButton.Text = "Обновить данные";
      this.ReaderUpdateButton.UseVisualStyleBackColor = true;
      this.ReaderUpdateButton.Click += new System.EventHandler(this.ReaderUpdateButton_Click);
      // 
      // ReaderEmailTextBox
      // 
      this.ReaderEmailTextBox.Location = new System.Drawing.Point(392, 174);
      this.ReaderEmailTextBox.Name = "ReaderEmailTextBox";
      this.ReaderEmailTextBox.Size = new System.Drawing.Size(131, 20);
      this.ReaderEmailTextBox.TabIndex = 12;
      // 
      // ReaderSurenameTextBox
      // 
      this.ReaderSurenameTextBox.Location = new System.Drawing.Point(392, 144);
      this.ReaderSurenameTextBox.Name = "ReaderSurenameTextBox";
      this.ReaderSurenameTextBox.Size = new System.Drawing.Size(131, 20);
      this.ReaderSurenameTextBox.TabIndex = 11;
      // 
      // ReaderNameTextBox
      // 
      this.ReaderNameTextBox.Location = new System.Drawing.Point(392, 114);
      this.ReaderNameTextBox.Name = "ReaderNameTextBox";
      this.ReaderNameTextBox.Size = new System.Drawing.Size(131, 20);
      this.ReaderNameTextBox.TabIndex = 10;
      // 
      // ReaderSurnameLabel
      // 
      this.ReaderSurnameLabel.AutoSize = true;
      this.ReaderSurnameLabel.Location = new System.Drawing.Point(260, 147);
      this.ReaderSurnameLabel.Name = "ReaderSurnameLabel";
      this.ReaderSurnameLabel.Size = new System.Drawing.Size(56, 13);
      this.ReaderSurnameLabel.TabIndex = 9;
      this.ReaderSurnameLabel.Text = "Фамилия";
      // 
      // ReaderEmailLabel
      // 
      this.ReaderEmailLabel.AutoSize = true;
      this.ReaderEmailLabel.Location = new System.Drawing.Point(260, 177);
      this.ReaderEmailLabel.Name = "ReaderEmailLabel";
      this.ReaderEmailLabel.Size = new System.Drawing.Size(32, 13);
      this.ReaderEmailLabel.TabIndex = 8;
      this.ReaderEmailLabel.Text = "Email";
      // 
      // ReaderNameLabel
      // 
      this.ReaderNameLabel.AutoSize = true;
      this.ReaderNameLabel.Location = new System.Drawing.Point(260, 117);
      this.ReaderNameLabel.Name = "ReaderNameLabel";
      this.ReaderNameLabel.Size = new System.Drawing.Size(29, 13);
      this.ReaderNameLabel.TabIndex = 7;
      this.ReaderNameLabel.Text = "Имя";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.ReaderOrdersDG);
      this.tabPage2.Controls.Add(this.AddOrderButton);
      this.tabPage2.Controls.Add(this.OrdersHistoryLabel);
      this.tabPage2.Controls.Add(this.ReturnDatePicker);
      this.tabPage2.Controls.Add(this.ReturnTimeLabel);
      this.tabPage2.Controls.Add(this.BorrowDateLabel);
      this.tabPage2.Controls.Add(this.BorrowDatePicker);
      this.tabPage2.Controls.Add(this.BookNameLabel);
      this.tabPage2.Controls.Add(this.BookNameComboBox);
      this.tabPage2.Controls.Add(this.AddOrderLabel);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 424);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Мои заказы";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
      // 
      // ReaderOrdersDG
      // 
      this.ReaderOrdersDG.DataMember = "";
      this.ReaderOrdersDG.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ReaderOrdersDG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
      this.ReaderOrdersDG.Location = new System.Drawing.Point(3, 295);
      this.ReaderOrdersDG.Name = "ReaderOrdersDG";
      this.ReaderOrdersDG.Size = new System.Drawing.Size(786, 126);
      this.ReaderOrdersDG.TabIndex = 10;
      // 
      // AddOrderButton
      // 
      this.AddOrderButton.Location = new System.Drawing.Point(364, 206);
      this.AddOrderButton.Name = "AddOrderButton";
      this.AddOrderButton.Size = new System.Drawing.Size(75, 23);
      this.AddOrderButton.TabIndex = 9;
      this.AddOrderButton.Text = "Добавить";
      this.AddOrderButton.UseVisualStyleBackColor = true;
      this.AddOrderButton.Click += new System.EventHandler(this.AddOfferButton_Click);
      // 
      // OrdersHistoryLabel
      // 
      this.OrdersHistoryLabel.AutoSize = true;
      this.OrdersHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.OrdersHistoryLabel.Location = new System.Drawing.Point(336, 254);
      this.OrdersHistoryLabel.Name = "OrdersHistoryLabel";
      this.OrdersHistoryLabel.Size = new System.Drawing.Size(143, 18);
      this.OrdersHistoryLabel.TabIndex = 8;
      this.OrdersHistoryLabel.Text = "История заказов";
      this.OrdersHistoryLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // ReturnDatePicker
      // 
      this.ReturnDatePicker.Location = new System.Drawing.Point(380, 162);
      this.ReturnDatePicker.Name = "ReturnDatePicker";
      this.ReturnDatePicker.Size = new System.Drawing.Size(157, 20);
      this.ReturnDatePicker.TabIndex = 7;
      // 
      // ReturnTimeLabel
      // 
      this.ReturnTimeLabel.AutoSize = true;
      this.ReturnTimeLabel.Location = new System.Drawing.Point(199, 168);
      this.ReturnTimeLabel.Name = "ReturnTimeLabel";
      this.ReturnTimeLabel.Size = new System.Drawing.Size(83, 13);
      this.ReturnTimeLabel.TabIndex = 6;
      this.ReturnTimeLabel.Text = "Дата возврата";
      // 
      // BorrowDateLabel
      // 
      this.BorrowDateLabel.AutoSize = true;
      this.BorrowDateLabel.Location = new System.Drawing.Point(199, 118);
      this.BorrowDateLabel.Name = "BorrowDateLabel";
      this.BorrowDateLabel.Size = new System.Drawing.Size(71, 13);
      this.BorrowDateLabel.TabIndex = 5;
      this.BorrowDateLabel.Text = "Дата взятия";
      // 
      // BorrowDatePicker
      // 
      this.BorrowDatePicker.Location = new System.Drawing.Point(380, 112);
      this.BorrowDatePicker.Name = "BorrowDatePicker";
      this.BorrowDatePicker.Size = new System.Drawing.Size(157, 20);
      this.BorrowDatePicker.TabIndex = 4;
      // 
      // BookNameLabel
      // 
      this.BookNameLabel.AutoSize = true;
      this.BookNameLabel.Location = new System.Drawing.Point(199, 65);
      this.BookNameLabel.Name = "BookNameLabel";
      this.BookNameLabel.Size = new System.Drawing.Size(89, 13);
      this.BookNameLabel.TabIndex = 3;
      this.BookNameLabel.Text = "Название книги";
      // 
      // BookNameComboBox
      // 
      this.BookNameComboBox.FormattingEnabled = true;
      this.BookNameComboBox.Location = new System.Drawing.Point(380, 62);
      this.BookNameComboBox.Name = "BookNameComboBox";
      this.BookNameComboBox.Size = new System.Drawing.Size(299, 21);
      this.BookNameComboBox.TabIndex = 2;
      // 
      // AddOrderLabel
      // 
      this.AddOrderLabel.AutoSize = true;
      this.AddOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddOrderLabel.Location = new System.Drawing.Point(336, 23);
      this.AddOrderLabel.Name = "AddOrderLabel";
      this.AddOrderLabel.Size = new System.Drawing.Size(135, 18);
      this.AddOrderLabel.TabIndex = 1;
      this.AddOrderLabel.Text = "Добавить заказ";
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.AddReviewButton);
      this.tabPage3.Controls.Add(this.ReviewComboBox);
      this.tabPage3.Controls.Add(this.ReviewLabel);
      this.tabPage3.Controls.Add(this.ReviewBookNameLabel);
      this.tabPage3.Controls.Add(this.ReviewBookNameComboBox);
      this.tabPage3.Controls.Add(this.AddReviewLabel);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(792, 424);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Мои отзывы";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
      // 
      // AddReviewButton
      // 
      this.AddReviewButton.Location = new System.Drawing.Point(347, 229);
      this.AddReviewButton.Name = "AddReviewButton";
      this.AddReviewButton.Size = new System.Drawing.Size(75, 23);
      this.AddReviewButton.TabIndex = 8;
      this.AddReviewButton.Text = "Добавить";
      this.AddReviewButton.UseVisualStyleBackColor = true;
      this.AddReviewButton.Click += new System.EventHandler(this.AddReviewButton_Click);
      // 
      // ReviewComboBox
      // 
      this.ReviewComboBox.FormattingEnabled = true;
      this.ReviewComboBox.Location = new System.Drawing.Point(375, 162);
      this.ReviewComboBox.Name = "ReviewComboBox";
      this.ReviewComboBox.Size = new System.Drawing.Size(299, 21);
      this.ReviewComboBox.TabIndex = 7;
      // 
      // ReviewLabel
      // 
      this.ReviewLabel.AutoSize = true;
      this.ReviewLabel.Location = new System.Drawing.Point(199, 165);
      this.ReviewLabel.Name = "ReviewLabel";
      this.ReviewLabel.Size = new System.Drawing.Size(40, 13);
      this.ReviewLabel.TabIndex = 6;
      this.ReviewLabel.Text = "Отзыв";
      this.ReviewLabel.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // ReviewBookNameLabel
      // 
      this.ReviewBookNameLabel.AutoSize = true;
      this.ReviewBookNameLabel.Location = new System.Drawing.Point(178, 107);
      this.ReviewBookNameLabel.Name = "ReviewBookNameLabel";
      this.ReviewBookNameLabel.Size = new System.Drawing.Size(89, 13);
      this.ReviewBookNameLabel.TabIndex = 5;
      this.ReviewBookNameLabel.Text = "Название книги";
      // 
      // ReviewBookNameComboBox
      // 
      this.ReviewBookNameComboBox.FormattingEnabled = true;
      this.ReviewBookNameComboBox.Location = new System.Drawing.Point(375, 104);
      this.ReviewBookNameComboBox.Name = "ReviewBookNameComboBox";
      this.ReviewBookNameComboBox.Size = new System.Drawing.Size(299, 21);
      this.ReviewBookNameComboBox.TabIndex = 4;
      // 
      // AddReviewLabel
      // 
      this.AddReviewLabel.AutoSize = true;
      this.AddReviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.AddReviewLabel.Location = new System.Drawing.Point(319, 52);
      this.AddReviewLabel.Name = "AddReviewLabel";
      this.AddReviewLabel.Size = new System.Drawing.Size(138, 18);
      this.AddReviewLabel.TabIndex = 2;
      this.AddReviewLabel.Text = "Добавить отзыв";
      // 
      // cn
      // 
      this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-9H28KO5;Integrated Security=SSPI;Initial C" +
    "atalog=Library";
      // 
      // ReaderOrdersDS
      // 
      this.ReaderOrdersDS.DataSetName = "NewDataSet";
      // 
      // ReaderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ReaderProfileTab);
      this.Name = "ReaderForm";
      this.Text = "Я - Читатель";
      this.ReaderProfileTab.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ReaderOrdersDG)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ReaderOrdersDS)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.TabControl ReaderProfileTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox ReaderEmailTextBox;
        private System.Windows.Forms.TextBox ReaderSurenameTextBox;
        private System.Windows.Forms.TextBox ReaderNameTextBox;
        private System.Windows.Forms.Label ReaderSurnameLabel;
        private System.Windows.Forms.Label ReaderEmailLabel;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.Button ReaderUpdateButton;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.DateTimePicker ReturnDatePicker;
        private System.Windows.Forms.Label ReturnTimeLabel;
        private System.Windows.Forms.Label BorrowDateLabel;
        private System.Windows.Forms.DateTimePicker BorrowDatePicker;
        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.ComboBox BookNameComboBox;
        private System.Windows.Forms.Label AddOrderLabel;
        private System.Windows.Forms.Label OrdersHistoryLabel;
        private System.Windows.Forms.Label MyProfileLabel;
        private System.Windows.Forms.Label ReviewLabel;
        private System.Windows.Forms.Label ReviewBookNameLabel;
        private System.Windows.Forms.ComboBox ReviewBookNameComboBox;
        private System.Windows.Forms.Label AddReviewLabel;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button AddReviewButton;
        private System.Windows.Forms.ComboBox ReviewComboBox;
        private System.Data.DataSet ReaderOrdersDS;
        private System.Windows.Forms.DataGrid ReaderOrdersDG;
    }
}