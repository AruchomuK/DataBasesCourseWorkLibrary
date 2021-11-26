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
  public partial class ReaderForm : Form
  {
    String currentUserName;
    String currentUserSurname;
    String currentUserEmail;
    public ReaderForm(String userName, String userSurname, String userEmail)
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

      ReaderNameTextBox.Text = userName;
      this.currentUserName = userName;

      ReaderSurenameTextBox.Text = userSurname;
      this.currentUserSurname = userSurname;

      ReaderEmailTextBox.Text = userEmail;
      this.currentUserEmail = userEmail;


      // Заполнение ComboBox с книгами на странице "Мои заказы"
      String sqlAddBooksToComboBox = "SELECT [Name] FROM Book";

      OleDbCommand cmdAddBooksToComboBox = new OleDbCommand(sqlAddBooksToComboBox, cn);

      OleDbDataReader reader = cmdAddBooksToComboBox.ExecuteReader();

      while (reader.Read()) {
        for (int i = 0; i < reader.FieldCount; i++) {
          BookNameComboBox.Items.Add(reader["Name"].ToString());
        }
      }


      // Заполнение ComboBox с книгами на странице "Мои отзывы"
      reader.Close();

      reader = cmdAddBooksToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          ReviewBookNameComboBox.Items.Add(reader["Name"].ToString());
        }
      }


      String sqlAddRatingsToComboBox = "SELECT [Text] FROM Ratings";

      OleDbCommand cmdAddRatingsToComboBox = new OleDbCommand(sqlAddRatingsToComboBox, cn);

      reader = cmdAddRatingsToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          ReviewComboBox.Items.Add(reader["Text"].ToString());
        }
      }

      String sqlGetOrderedBooks = "SELECT Book.[Name], Orders.BorrowDate, Orders.ReturnDate FROM Book"
        + " INNER JOIN OrderDetails ON Book.IDBook = OrderDetails.IDBook"
        + " INNER JOIN Orders ON OrderDetails.IDOrder = Orders.IDOrder"
        + " INNER JOIN Readers ON Orders.IDReader = Readers.IDReader"
        + " GROUP BY Book.[Name], Readers.Email, Orders.BorrowDate, Orders.ReturnDate"
        + " HAVING Readers.Email = \'" + currentUserEmail + "\'";

      DataTable readerOffers;
      readerOffers = ReaderOrdersDS.Tables.Add("Offers");
      readerOffers.Columns.Add("Name", typeof(String));   
      readerOffers.Columns.Add("BorrowDate", typeof(DateTime));
      readerOffers.Columns.Add("ReturnDate", typeof(DateTime));

      ReaderOrdersDG.SetDataBinding(ReaderOrdersDS, "Offers");

      OleDbCommand cmdGetOrderedBooks = new OleDbCommand(sqlGetOrderedBooks, cn);

      OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdGetOrderedBooks);

      dataAdapter.Fill(ReaderOrdersDS, "Offers");      
    }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void setAllFieldsDisabled()
    {
      ReaderNameTextBox.Enabled = false;
      ReaderSurenameTextBox.Enabled = false;
      ReaderEmailTextBox.Enabled = false;

    }

    private void ReaderUpdateButton_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Хотите изменить данные?", "Мой профиль", MessageBoxButtons.YesNo);

      if (dialog == DialogResult.Yes) {


        String sqlUpdateReaderData = "UPDATE Users SET UserName = \'" + ReaderNameTextBox.Text + " " + ReaderSurenameTextBox.Text + 
          "\', Email = \'" + ReaderEmailTextBox.Text + "\' WHERE Email = \'" + currentUserEmail + "\'";

        OleDbCommand cmdUpdateReaderData = new OleDbCommand(sqlUpdateReaderData, cn);

        cmdUpdateReaderData.ExecuteNonQuery();

        MessageBox.Show("Данные успешно изменены!", "Мой профиль", MessageBoxButtons.OK);


        currentUserName = ReaderNameTextBox.Text;
        currentUserSurname = ReaderSurenameTextBox.Text;
        currentUserEmail = ReaderEmailTextBox.Text;
      } else {
        ReaderNameTextBox.Text = currentUserName;
        ReaderSurenameTextBox.Text = currentUserSurname;
        ReaderEmailTextBox.Text = currentUserEmail;
      }
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void AddOfferButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Orders
      int ordersCount = 0;

      String sqlGetOrdersCount = "SELECT COUNT(IDOrder) FROM Orders";

      OleDbCommand cmdGetOrdersCount = new OleDbCommand(sqlGetOrdersCount, cn);

      OleDbDataReader reader = cmdGetOrdersCount.ExecuteReader();

      while (reader.Read())
      {
        ordersCount = reader.GetInt32(0);
      }


      // Вычисление IDReader
      int idReader = 0;

      String sqlGetIDReader = "SELECT IDReader FROM Readers WHERE Readers.Email = \'" + currentUserEmail + "\'";

      OleDbCommand cmdGetIDReader = new OleDbCommand(sqlGetIDReader, cn);

      reader = cmdGetIDReader.ExecuteReader();

      while (reader.Read()) {
        idReader = reader.GetInt32(0);
      }


      // Вычисление количества записей в Order Details
      int ODCount = 0;

      String sqlGetODCount = "SELECT COUNT(ID) FROM OrderDetails";

      OleDbCommand cmdGetODCount = new OleDbCommand(sqlGetODCount, cn);

      reader = cmdGetODCount.ExecuteReader();

      while (reader.Read())
      {
        ODCount = reader.GetInt32(0);
      }


      // Вычисление IDBook
      int idBook = 0;

      String sqlGetBookID = "SELECT IDBook FROM Book WHERE [Name] = \'" + BookNameComboBox.Text + "\'";

      OleDbCommand cmdGetBookID = new OleDbCommand(sqlGetBookID, cn);

      reader = cmdGetBookID.ExecuteReader();

      while (reader.Read())
      {
        idBook = reader.GetInt32(0);
      }


      // Вставка в Orders
      String sqlAddOrder = "INSERT INTO Orders (IDOrder, IDReader, BorrowDate, ReturnDate) VALUES (?, ?, ?, ?)"
        + "INSERT INTO OrderDetails (ID, IDOrder, IDBook) VALUES (?, ?, ?)";

      OleDbCommand cmdAddOrder = new OleDbCommand(sqlAddOrder, cn);

      cmdAddOrder.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddOrder.Parameters.Add("@p2", OleDbType.Integer);
      cmdAddOrder.Parameters.Add("@p3", OleDbType.Date);
      cmdAddOrder.Parameters.Add("@p4", OleDbType.Date);
      cmdAddOrder.Parameters.Add("@p5", OleDbType.Integer);
      cmdAddOrder.Parameters.Add("@p6", OleDbType.Integer);
      cmdAddOrder.Parameters.Add("@p7", OleDbType.Integer);

      cmdAddOrder.Parameters[0].Value = ordersCount + 1;
      cmdAddOrder.Parameters[1].Value = idReader;
      cmdAddOrder.Parameters[2].Value = BorrowDatePicker.Value;
      cmdAddOrder.Parameters[3].Value = ReturnDatePicker.Value;
      cmdAddOrder.Parameters[4].Value = ODCount + 1;
      cmdAddOrder.Parameters[5].Value = ordersCount + 1;
      cmdAddOrder.Parameters[6].Value = idBook;


      try
      {
        cmdAddOrder.ExecuteNonQuery();
        MessageBox.Show("Заказ добавлен!", "Мои заказы", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }
    }

    private void AddReviewButton_Click(object sender, EventArgs e)
    {
      // Считает количество записей
      int reviewsCount = 0;
      String sqlGetReviewsCount = "SELECT COUNT(IdReview) FROM Reviews";

      OleDbCommand cmdGetReviewsCount = new OleDbCommand(sqlGetReviewsCount, cn);

      OleDbDataReader reader = cmdGetReviewsCount.ExecuteReader();

      while (reader.Read())
      {
        reviewsCount = reader.GetInt32(0);
      }

      
      // Вычисление IDReader
      int idReader = 0;

      String sqlGetIDReader = "SELECT IDReader FROM Readers WHERE Readers.Email = \'" + currentUserEmail + "\'";

      OleDbCommand cmdGetIDReader = new OleDbCommand(sqlGetIDReader, cn);

      reader = cmdGetIDReader.ExecuteReader();

      while (reader.Read())
      {
        idReader = reader.GetInt32(0);
      }


      // Вычисление IDBook
      int idBook = 0;

      String sqlGetBookID = "SELECT IDBook FROM Book WHERE [Name] = \'" + ReviewBookNameComboBox.Text + "\'";

      OleDbCommand cmdGetBookID = new OleDbCommand(sqlGetBookID, cn);

      reader = cmdGetBookID.ExecuteReader();

      while (reader.Read()) {
        idBook = reader.GetInt32(0);
      }


      // Вычисление IDRating
      int idRating = 0;

      String sqlGetRatingID = "SELECT IDRating FROM Ratings WHERE [Text] = \'" + ReviewComboBox.Text + "\'";

      OleDbCommand cmdGetRatingID = new OleDbCommand(sqlGetRatingID, cn);

      reader = cmdGetRatingID.ExecuteReader();

      while (reader.Read())
      {
        idRating = reader.GetInt32(0);
      }


      // Вставка в Reviews
      String sqlAddReview = "INSERT INTO Reviews (IDReview, IDReader, IDBook, IDRating) VALUES (?, ?, ?, ?)";

      OleDbCommand cmdAddReview = new OleDbCommand(sqlAddReview, cn);

      cmdAddReview.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddReview.Parameters.Add("@p2", OleDbType.Integer);
      cmdAddReview.Parameters.Add("@p3", OleDbType.Integer);
      cmdAddReview.Parameters.Add("@p4", OleDbType.Integer);

      cmdAddReview.Parameters[0].Value = reviewsCount + 1;
      cmdAddReview.Parameters[1].Value = idReader;
      cmdAddReview.Parameters[2].Value = idBook;
      cmdAddReview.Parameters[3].Value = idRating;

      try
      {
        cmdAddReview.ExecuteNonQuery();
        MessageBox.Show("Отзыв добавлен!", "Мои отзывы", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }
    }

    private void tabPage3_Click(object sender, EventArgs e)
    {

    }
  }
}
