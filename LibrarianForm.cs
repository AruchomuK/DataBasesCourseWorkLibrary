using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCourseWork
{
  public partial class LibrarianForm : Form
  {
    String currentUserName;
    String currentUserSurname;
    String currentUserEmail;

    public LibrarianForm(String userName, String userSurname, String userEmail)
    {
      InitializeComponent();

      try
      {
        cn.Open();
        //MessageBox.Show("Connected!", "Connection", MessageBoxButtons.OK);
      }
      catch (Exception)
      {
        MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
      }

      LibrarianNameTextBox.Text = userName;
      this.currentUserName = userName;

      LibrarianSurenameTextBox.Text = userSurname;
      this.currentUserSurname = userSurname;

      LibrarianEmailTextBox.Text = userEmail;
      this.currentUserEmail = userEmail;


      // Заполнение ComboBox с книгами на странице "Коллекции"
      String sqlAddBooksToComboBox = "SELECT [Name] FROM Book";

      OleDbCommand cmdAddBooksToComboBox = new OleDbCommand(sqlAddBooksToComboBox, cn);

      OleDbDataReader reader = cmdAddBooksToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          CollectionBookNameComboBox.Items.Add(reader["Name"].ToString());
        }
      }


      // Заполнение ComboBox с книгами на странице "Закупки"
      reader.Close();

      reader = cmdAddBooksToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          PurchaseBookNameComboBox.Items.Add(reader["Name"].ToString());
        }
      }


      // Заполнение ComboBox с коллекциями на странице "Коллекции"
      String sqlAddCollectionsToComboBox = "SELECT NameCollection FROM Collection";

      OleDbCommand cmdAddCollectionsToComboBox = new OleDbCommand(sqlAddCollectionsToComboBox, cn);

      reader = cmdAddCollectionsToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          CollectionNameComboBox.Items.Add(reader["NameCollection"].ToString());
        }
      }


      // Заполнение ComboBox с номерами заказов
      String sqlAddIDPurchasesToComboBox = "SELECT DISTINCT IDPurchase FROM Purchase";

      OleDbCommand cmdAddIDPurchasesToComboBox = new OleDbCommand(sqlAddIDPurchasesToComboBox, cn);

      reader = cmdAddIDPurchasesToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          PurchaseIDComboBox.Items.Add(reader["IDPurchase"].ToString());
        }
      }

      PurchaseIDComboBox.Items.Add("Новый заказ");


      // Заполнение PurchasesDG
      String sqlGetPurchases = "SELECT Purchase.IDPurchase, Book.[Name], Purchase.Price, PurchaseStatus.NameStatus FROM Purchase"
        + " INNER JOIN Book ON Book.IDBook = Purchase.IDBook"
        + " INNER JOIN PurchaseStatus ON Purchase.IDStatus = PurchaseStatus.IDStatus"
        + " GROUP BY Purchase.IDPurchase, Book.[Name], Purchase.Price, PurchaseStatus.NameStatus";

      DataTable purchases;
      purchases = PurchasesDS.Tables.Add("Purchases");
      purchases.Columns.Add("IDPurchase", typeof(int));
      purchases.Columns.Add("Name", typeof(String));
      purchases.Columns.Add("Price", typeof(int));
      purchases.Columns.Add("NameStatus", typeof(String));

      PurchasesDG.SetDataBinding(PurchasesDS, "Purchases");

      OleDbCommand cmdGetPurchases = new OleDbCommand(sqlGetPurchases, cn);

      OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdGetPurchases);

      dataAdapter.Fill(PurchasesDS, "Purchases");


      // Заполнение ComboBox с Авторами
      String sqlAddAuthorsToComboBox = "SELECT NameAuthor FROM Authors";

      OleDbCommand cmdAddAuthorsToComboBox = new OleDbCommand(sqlAddAuthorsToComboBox, cn);

      reader = cmdAddAuthorsToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          AuthorsComboBox.Items.Add(reader["NameAuthor"].ToString());
        }
      }


      // Заполнение ComboBox с Читателями
      String sqlAddReadersToComboBox = "SELECT NameReader FROM Readers";

      OleDbCommand cmdAddReadersToComboBox = new OleDbCommand(sqlAddReadersToComboBox, cn);

      reader = cmdAddReadersToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          ReadersComboBox.Items.Add(reader["NameReader"].ToString());
        }
      }
    }

    private void LibrarianForm_Load(object sender, EventArgs e)
        {

        }

    private void LibrarianUpdateButton_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Хотите изменить данные?", "Мой профиль", MessageBoxButtons.YesNo);

      if (dialog == DialogResult.Yes)
      {


        String sqlUpdateAuthorData = "UPDATE Users SET UserName = \'" + LibrarianNameTextBox.Text + " " + LibrarianSurenameTextBox.Text +
          "\', Email = \'" + LibrarianEmailTextBox.Text + "\' WHERE Email = \'" + currentUserEmail + "\'";

        OleDbCommand cmdUpdateAuthorData = new OleDbCommand(sqlUpdateAuthorData, cn);

        cmdUpdateAuthorData.ExecuteNonQuery();

        MessageBox.Show("Данные успешно изменены!", "Мой профиль", MessageBoxButtons.OK);


        currentUserName = LibrarianNameTextBox.Text;
        currentUserSurname = LibrarianSurenameTextBox.Text;
        currentUserEmail = LibrarianEmailTextBox.Text;
      } else {
        LibrarianNameTextBox.Text = currentUserName;
        LibrarianSurenameTextBox.Text = currentUserSurname;
        LibrarianEmailTextBox.Text = currentUserEmail;
      }      
    }


    private void NewCompilationLabel_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void tabPage3_Click(object sender, EventArgs e)
    {

    }

    private void AddBookToCollectionButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Collections
      int idCount = 0;

      String sqlGetCollectionsCount = "SELECT COUNT(ID) FROM Collections";

      OleDbCommand cmdGetCollectionsCount = new OleDbCommand(sqlGetCollectionsCount, cn);

      OleDbDataReader reader = cmdGetCollectionsCount.ExecuteReader();

      while (reader.Read())
      {
        idCount = reader.GetInt32(0);
      }


      // Вычисление IDCollection
      int idCollection = 0;

      String sqlGetIDCollection = "SELECT IDCollection FROM Collection WHERE NameCollection = \'" + CollectionNameComboBox.Text + "\'";

      OleDbCommand cmdGetIDCollection = new OleDbCommand(sqlGetIDCollection, cn);

      reader = cmdGetIDCollection.ExecuteReader();

      while (reader.Read())
      {
        idCollection = reader.GetInt32(0);
      }


      // Вычисление IDBook
      int idBook = 0;

      String sqlGetIDBook = "SELECT IDBook FROM Book WHERE [Name] = \'" + CollectionBookNameComboBox.Text + "\'";

      OleDbCommand cmdGetIDBook = new OleDbCommand(sqlGetIDBook, cn);

      reader = cmdGetIDBook.ExecuteReader();

      while (reader.Read())
      {
        idBook = reader.GetInt32(0);
      }


      // Вставка в Collections
      String sqlAddBookToCollection = "INSERT INTO Collections (ID, IDCollection, IDBook) VALUES (?, ?, ?)";

      OleDbCommand cmdAddBookToCollection = new OleDbCommand(sqlAddBookToCollection, cn);

      cmdAddBookToCollection.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddBookToCollection.Parameters.Add("@p2", OleDbType.Integer);
      cmdAddBookToCollection.Parameters.Add("@p3", OleDbType.Integer);

      cmdAddBookToCollection.Parameters[0].Value = idCount + 1;
      cmdAddBookToCollection.Parameters[1].Value = idCollection;
      cmdAddBookToCollection.Parameters[2].Value = idBook;

      try
      {
        cmdAddBookToCollection.ExecuteNonQuery();
        MessageBox.Show("Книга добавлена!", "Мои книга", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }

    }

    private void createNewCollectionButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Collection
      int collectionsCount = 0;

      String sqlGetCollectionsCount = "SELECT COUNT(IDCollection) FROM Collection";

      OleDbCommand cmdGetCollectionsCount = new OleDbCommand(sqlGetCollectionsCount, cn);

      OleDbDataReader reader = cmdGetCollectionsCount.ExecuteReader();

      while (reader.Read())
      {
        collectionsCount = reader.GetInt32(0);
      }


      // Вставка в Collection
      String sqlAddCollection = "INSERT INTO Collection (IDCollection, NameCollection, [Year]) VALUES (?, ?, ?)";

      OleDbCommand cmdAddCollection = new OleDbCommand(sqlAddCollection, cn);

      cmdAddCollection.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddCollection.Parameters.Add("@p2", OleDbType.VarChar, 50);
      cmdAddCollection.Parameters.Add("@p3", OleDbType.Integer);

      cmdAddCollection.Parameters[0].Value = collectionsCount + 1;
      cmdAddCollection.Parameters[1].Value = NewCollectionNameTextBox.Text;
      cmdAddCollection.Parameters[2].Value = NewCollectionYearTextBox.Text;

      try
      {
        cmdAddCollection.ExecuteNonQuery();
        MessageBox.Show("Коллекция добавлена!", "Мои книга", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }

      CollectionNameComboBox.Items.Add(NewCollectionNameTextBox.Text);
    }

    private void AddBookToPurchasesButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Purchase
      int idCount = 0;

      String sqlGetPurchasesCount = "SELECT COUNT(ID) FROM Purchase";

      OleDbCommand cmdGetPurchasesCount = new OleDbCommand(sqlGetPurchasesCount, cn);

      OleDbDataReader reader = cmdGetPurchasesCount.ExecuteReader();

      while (reader.Read())
      {
        idCount = reader.GetInt32(0);
      }


      // Вычисление idPurchase
      int idPurchase = 0;

      if (PurchaseIDComboBox.Text.Equals("Новый заказ")) {
        String sqlGetIDPurchase = "SELECT MAX(IDPurchase) FROM Purchase";

        OleDbCommand cmdGetIDPurchase = new OleDbCommand(sqlGetIDPurchase, cn);

        reader = cmdGetIDPurchase.ExecuteReader();

        while (reader.Read())
        {
          idPurchase = reader.GetInt32(0);
        }

        idPurchase++;
      }


      // Вычисление IDBook
      int idBook = 0;

      String sqlGetIDBook = "SELECT IDBook FROM Book WHERE [Name] = \'" + PurchaseBookNameComboBox.Text + "\'";

      OleDbCommand cmdGetIDBook = new OleDbCommand(sqlGetIDBook, cn);

      reader = cmdGetIDBook.ExecuteReader();

      while (reader.Read())
      {
        idBook = reader.GetInt32(0);
      }


      // Вставка в Purchase
      String sqlAddPurchase = "INSERT INTO Purchase (ID, IDPurchase, IDBook, IDStatus, Price) VALUES (?, ?, ?, ?, ?)";

      OleDbCommand cmdAddPurchase = new OleDbCommand(sqlAddPurchase, cn);

      cmdAddPurchase.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddPurchase.Parameters.Add("@p2", OleDbType.Integer);
      cmdAddPurchase.Parameters.Add("@p3", OleDbType.Integer);
      cmdAddPurchase.Parameters.Add("@p4", OleDbType.Integer);
      cmdAddPurchase.Parameters.Add("@p5", OleDbType.Integer);

      cmdAddPurchase.Parameters[0].Value = idCount + 1;

      if (idPurchase == 0)
      {
        cmdAddPurchase.Parameters[1].Value = PurchaseIDComboBox.Text;
      } else {
        cmdAddPurchase.Parameters[1].Value = idPurchase;
      }
      cmdAddPurchase.Parameters[2].Value = idBook;
      cmdAddPurchase.Parameters[3].Value = 1;
      cmdAddPurchase.Parameters[4].Value = PurchasePriceTextBox.Text;

      try
      {
        cmdAddPurchase.ExecuteNonQuery();
        MessageBox.Show("Заказ добавлен!", "Мои книга", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }
    }

    private void AuthorInfoButton_Click(object sender, EventArgs e)
    {
      String sqlGetAuthorInfo = "SELECT * FROM Authors WHERE NameAuthor = \'" + AuthorsComboBox.Text + "\'";
      
      OleDbCommand cmdGetAuthorInfo = new OleDbCommand(sqlGetAuthorInfo, cn);

      OleDbDataReader reader = cmdGetAuthorInfo.ExecuteReader();

      while (reader.Read())
      {
        String[] authorNameAndSurename = reader["NameAuthor"].ToString().Split(' ');

        AuthorNameTextBox.Text = authorNameAndSurename[0];
        AuthorSurenameTextBox.Text = authorNameAndSurename[1];
        AuthorEmailTextBox.Text = reader["Email"].ToString();
        AuthorBirthdayDatePicker.Value = (System.DateTime)reader["BirthdayAuthor"];
      }
    }

    private void ReaderInfoButton_Click(object sender, EventArgs e)
    {
      String sqlGetReaderInfo = "SELECT * FROM Readers WHERE NameReader = \'" + ReadersComboBox.Text + "\'";

      OleDbCommand cmdGetReaderInfo = new OleDbCommand(sqlGetReaderInfo, cn);

      OleDbDataReader reader = cmdGetReaderInfo.ExecuteReader();

      while (reader.Read())
      {
        String[] readerNameAndSurename = reader["NameReader"].ToString().Split(' ');

        ReaderNameTextBox.Text = readerNameAndSurename[0];
        ReaderSurenameTextBox.Text = readerNameAndSurename[1];
        ReaderEmailTextBox.Text = reader["Email"].ToString();
        ReaderBirthdayDatePicker.Value = (System.DateTime)reader["BirthdayReader"];
      }
    }
  }
}
