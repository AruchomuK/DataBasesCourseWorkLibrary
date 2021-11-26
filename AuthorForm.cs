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
  public partial class AuthorForm : Form
  {
    String currentUserName;
    String currentUserSurname;
    String currentUserEmail;

    public AuthorForm(String userName, String userSurname, String userEmail)
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

      AuthorNameTextBox.Text = userName;
      this.currentUserName = userName;

      AuthorSurenameTextBox.Text = userSurname;
      this.currentUserSurname = userSurname;

      AuthorEmailTextBox.Text = userEmail;
      this.currentUserEmail = userEmail;

      // Заполнение ComboBox с издательствами
      String sqlAddPublishersToComboBox = "SELECT [NamePublisher] FROM Publishers";

      OleDbCommand cmdAddPublishersToComboBox = new OleDbCommand(sqlAddPublishersToComboBox, cn);

      OleDbDataReader reader = cmdAddPublishersToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          AuthorPublisherComboBox.Items.Add(reader["NamePublisher"].ToString());
        }
      }


      // Заполнение ComboBox с жанрами на странице "Мои книги"
      reader.Close();

      String sqlAddGenresToComboBox = "SELECT [NameGenre] FROM Genres";

      OleDbCommand cmdAddGenresToComboBox = new OleDbCommand(sqlAddGenresToComboBox, cn);

      reader = cmdAddGenresToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          AuthorGenreComboBox.Items.Add(reader["NameGenre"].ToString());
        }
      }


      // Заполнение ComboBox с жанрами на странице "Мои сборники"
      reader.Close();

      reader = cmdAddGenresToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          NewCompilationGenreComboBox.Items.Add(reader["NameGenre"].ToString());
        }
      }

      // Заполнение ComboBox с книгами автора
      reader.Close();

      String sqlAddAuthorsBooksToComboBox = "SELECT [Name] FROM Book"
        + " INNER JOIN BookAuthors ON Book.IDBook = BookAuthors.IDBook"
        + " INNER JOIN Authors ON BookAuthors.IDAuthor = Authors.IDAuthor"
        + " GROUP BY Book.[Name], Authors.Email"
        + " HAVING Authors.Email = \'" + currentUserEmail + "\'";

      OleDbCommand cmdAddAuthorsBooksToComboBox = new OleDbCommand(sqlAddAuthorsBooksToComboBox, cn);

      reader = cmdAddAuthorsBooksToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          CompilationsBookNameComboBox.Items.Add(reader["Name"].ToString());
        }
      }


      // Заполнение ComboBox со сборниками автора
      reader.Close();

      String sqlAddCompilationsToComboBox = "SELECT NameCompilation FROM Compilation"
        + " INNER JOIN Compilations ON Compilations.IDCompilation = Compilation.IDCompilation"
        + " INNER JOIN BookAuthors ON Compilations.IDBook = BookAuthors.IDBook"
        + " INNER JOIN Authors ON BookAuthors.IDAuthor = Authors.IDAuthor"
        + " GROUP BY NameCompilation, Authors.Email"
        + " HAVING Authors.Email = \'" + currentUserEmail + "\'";

      OleDbCommand cmdAddCompilationsToComboBox = new OleDbCommand(sqlAddCompilationsToComboBox, cn);

      reader = cmdAddCompilationsToComboBox.ExecuteReader();

      while (reader.Read())
      {
        for (int i = 0; i < reader.FieldCount; i++)
        {
          CompilationNameComboBox.Items.Add(reader["NameCompilation"].ToString());
        }
      }

      String sqlGetAuthorBooks = "SELECT Book.[Name], [Year], Publishers.NamePublisher, Editions.NumEdition, Genres.NameGenre FROM Book" 
        + " INNER JOIN Genres ON Book.IDGenre = Genres.IDGenre"
        + " INNER JOIN Editions ON Book.IDEdition = Editions.IDEdition"
        + " INNER JOIN Publishers ON Publishers.IDPublisher = Editions.IDPublisher"
        + " INNER JOIN BookAuthors ON Book.IDBook = BookAuthors.IDBook"
        + " INNER JOIN Authors ON BookAuthors.IDAuthor = Authors.IDAuthor"
        + " GROUP BY Book.[Name], [Year], Publishers.NamePublisher, Editions.NumEdition, Genres.NameGenre, Authors.Email"
        + " HAVING Authors.Email = \'" + currentUserEmail + "\'";

      DataTable auhtorBooks;
      auhtorBooks = AuthorBooksDS.Tables.Add("AuthorBooks");
      auhtorBooks.Columns.Add("Name", typeof(String));
      auhtorBooks.Columns.Add("Year", typeof(int));
      auhtorBooks.Columns.Add("NamePublisher", typeof(String));
      auhtorBooks.Columns.Add("NumEdition", typeof(int));
      auhtorBooks.Columns.Add("NameGenre", typeof(String));

      AuthorBooksDG.SetDataBinding(AuthorBooksDS, "AuthorBooks");
     
      OleDbCommand cmdGetAuthorBooks = new OleDbCommand(sqlGetAuthorBooks, cn);

      OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdGetAuthorBooks);

      dataAdapter.Fill(AuthorBooksDS, "AuthorBooks");
    }

    private void AuthorForm_Load(object sender, EventArgs e)
        {

        }

    private void AuthorAddBookLabel_Click(object sender, EventArgs e)
    {

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void tabPage3_Click(object sender, EventArgs e)
    {

    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }

    private void AuthorUpdateButton_Click(object sender, EventArgs e)
    {
      DialogResult dialog = MessageBox.Show("Хотите изменить данные?", "Мой профиль", MessageBoxButtons.YesNo);

      if (dialog == DialogResult.Yes)
      {


        String sqlUpdateAuthorData = "UPDATE Users SET UserName = \'" + AuthorNameTextBox.Text + " " + AuthorSurenameTextBox.Text +
          "\', Email = \'" + AuthorEmailTextBox.Text + "\' WHERE Email = \'" + currentUserEmail + "\'";

        OleDbCommand cmdUpdateAuthorData = new OleDbCommand(sqlUpdateAuthorData, cn);

        cmdUpdateAuthorData.ExecuteNonQuery();

        MessageBox.Show("Данные успешно изменены!", "Мой профиль", MessageBoxButtons.OK);


        currentUserName = AuthorNameTextBox.Text;
        currentUserSurname = AuthorSurenameTextBox.Text;
        currentUserEmail = AuthorEmailTextBox.Text;
      } else {
        AuthorNameTextBox.Text = currentUserName;
        AuthorSurenameTextBox.Text = currentUserSurname;
        AuthorEmailTextBox.Text = currentUserEmail;
      }
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {

    }

    private void AuthorAddBookButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Book
      int booksCount = 0;

      String sqlGetBooksCount = "SELECT COUNT(IDBook) FROM Book";

      OleDbCommand cmdGetBooksCount = new OleDbCommand(sqlGetBooksCount, cn);

      OleDbDataReader reader = cmdGetBooksCount.ExecuteReader();

      while (reader.Read())
      {
        booksCount = reader.GetInt32(0);
      }


      // Вычисление IDEdition 
      int idEdition = 0;

      String sqlGetIDEdition = "SELECT IDEdition FROM Editions"
        + " INNER JOIN Publishers ON Editions.IDPublisher = Publishers.IDPublisher"
        + " GROUP BY Editions.IDEdition, Publishers.NamePublisher"
        + " HAVING Publishers.NamePublisher = \'" + AuthorPublisherComboBox.Text + "\'";

      OleDbCommand cmdGetIDEdition = new OleDbCommand(sqlGetIDEdition, cn);

      reader = cmdGetIDEdition.ExecuteReader();

      while (reader.Read())
      {
        idEdition = reader.GetInt32(0);
      }


      // Вычисление IDGenre 
      int idGenre = 0;

      String sqlGetIDGenre = "SELECT IDGenre FROM Genres WHERE NameGenre = \'" + AuthorGenreComboBox.Text + "\'";

      OleDbCommand cmdGetIDGenre = new OleDbCommand(sqlGetIDGenre, cn);

      reader = cmdGetIDGenre.ExecuteReader();

      while (reader.Read())
      {
        idGenre = reader.GetInt32(0);
      }


      // Вычисление количества записей в BookAuthors
      int bookAuthorsCount = 0;

      String sqlGetBookAuthorsCount = "SELECT COUNT(ID) FROM BookAuthors";

      OleDbCommand cmdGetBookAuthorsCount = new OleDbCommand(sqlGetBookAuthorsCount, cn);

      reader = cmdGetBookAuthorsCount.ExecuteReader();

      while (reader.Read())
      {
        bookAuthorsCount = reader.GetInt32(0);
      }


      // Вычисление IDAuthor 
      int idAuthor = 0;

      String sqlGetIDAuthor = "SELECT IDAuthor FROM Authors WHERE Email = \'" + currentUserEmail + "\'";

      OleDbCommand cmdGetIDAuthor = new OleDbCommand(sqlGetIDAuthor, cn);

      reader = cmdGetIDAuthor.ExecuteReader();

      while (reader.Read())
      {
        idAuthor = reader.GetInt32(0);
      }


      // Вставка в Book и BookAuthors 
      String sqlAddAuthorsBook = "INSERT INTO Book (IDBook, [Name], Year, IDEdition, IDGenre) VALUES (?, ?, ?, ?, ?)"
        + "INSERT INTO BookAuthors (ID, IDBook, IDAuthor) VALUES (?, ?, ?)";

      OleDbCommand cmdAddAuthorsBook = new OleDbCommand(sqlAddAuthorsBook, cn);

      cmdAddAuthorsBook.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddAuthorsBook.Parameters.Add("@p2", OleDbType.VarChar, 50);
      cmdAddAuthorsBook.Parameters.Add("@p3", OleDbType.Integer);
      cmdAddAuthorsBook.Parameters.Add("@p4", OleDbType.Integer);
      cmdAddAuthorsBook.Parameters.Add("@p5", OleDbType.Integer);
      cmdAddAuthorsBook.Parameters.Add("@p6", OleDbType.Integer);
      cmdAddAuthorsBook.Parameters.Add("@p7", OleDbType.Integer);
      cmdAddAuthorsBook.Parameters.Add("@p8", OleDbType.Integer);

      cmdAddAuthorsBook.Parameters[0].Value = booksCount + 1;
      cmdAddAuthorsBook.Parameters[1].Value = AuthorBookNameTextBox.Text;
      cmdAddAuthorsBook.Parameters[2].Value = AuthorBookYearTextBox.Text;
      cmdAddAuthorsBook.Parameters[3].Value = idEdition;
      cmdAddAuthorsBook.Parameters[4].Value = idGenre;
      cmdAddAuthorsBook.Parameters[5].Value = bookAuthorsCount + 1;
      cmdAddAuthorsBook.Parameters[6].Value = booksCount + 1;
      cmdAddAuthorsBook.Parameters[7].Value = idAuthor;


      try
      {
        cmdAddAuthorsBook.ExecuteNonQuery();
        MessageBox.Show("Книга добавлена!", "Мои книга", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }


      // Добавление книги в CompilationsBookNameComboBox
      CompilationsBookNameComboBox.Items.Add(AuthorBookNameTextBox.Text);

    }

    private void AddBookToCompilationButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Compilations
      int compilationsCount = 0;

      String sqlGetCompilationsCount = "SELECT COUNT(ID) FROM Compilations";

      OleDbCommand cmdGetCompilationsCount = new OleDbCommand(sqlGetCompilationsCount, cn);

      OleDbDataReader reader = cmdGetCompilationsCount.ExecuteReader();

      while (reader.Read())
      {
        compilationsCount = reader.GetInt32(0);
      }


      // Вычисление IDCompilation
      int idCompilation = 0;

      String sqlGetIDCompilation = "SELECT IDCompilation FROM Compilation WHERE NameCompilation = \'" + CompilationNameComboBox.Text + "\'";

      OleDbCommand cmdGetIDCompilation = new OleDbCommand(sqlGetIDCompilation, cn);

      reader = cmdGetIDCompilation.ExecuteReader();

      while (reader.Read())
      {
        idCompilation = reader.GetInt32(0);
      }


      // Вычисление IDBook
      int idBook = 0;

      String sqlGetIDBook = "SELECT IDBook FROM Book WHERE [Name] = \'" + CompilationsBookNameComboBox.Text + "\'";

      OleDbCommand cmdGetIDBook = new OleDbCommand(sqlGetIDBook, cn);

      reader = cmdGetIDBook.ExecuteReader();

      while (reader.Read())
      {
        idBook = reader.GetInt32(0);
      }


      // Вставка в Compilations
      String sqlAddBookToCompilation = "INSERT INTO Compilations (ID, IDCompilation, IDBook) VALUES (?, ?, ?)";

      OleDbCommand cmdAddBookToCompilation = new OleDbCommand(sqlAddBookToCompilation, cn);

      cmdAddBookToCompilation.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddBookToCompilation.Parameters.Add("@p2", OleDbType.Integer);
      cmdAddBookToCompilation.Parameters.Add("@p3", OleDbType.Integer);

      cmdAddBookToCompilation.Parameters[0].Value = compilationsCount + 1;
      cmdAddBookToCompilation.Parameters[1].Value = idCompilation;
      cmdAddBookToCompilation.Parameters[2].Value = idBook;

      try
      {
        cmdAddBookToCompilation.ExecuteNonQuery();
        MessageBox.Show("Книга добавлена в сборник!", "Мои сборники", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }
    }

    private void createNewCompilationButton_Click(object sender, EventArgs e)
    {
      // Вычисление количества записей в Compilation
      int compilationsCount = 0;

      String sqlGetCompilationsCount = "SELECT COUNT(IDCompilation) FROM Compilation";

      OleDbCommand cmdGetCompilationsCount = new OleDbCommand(sqlGetCompilationsCount, cn);

      OleDbDataReader reader = cmdGetCompilationsCount.ExecuteReader();

      while (reader.Read())
      {
        compilationsCount = reader.GetInt32(0);
      }

      // Вычисление IDGenre 
      int idGenre = 0;

      String sqlGetIDGenre = "SELECT IDGenre FROM Genres WHERE NameGenre = \'" + NewCompilationGenreComboBox.Text + "\'";

      OleDbCommand cmdGetIDGenre = new OleDbCommand(sqlGetIDGenre, cn);

      reader = cmdGetIDGenre.ExecuteReader();

      while (reader.Read())
      {
        idGenre = reader.GetInt32(0);
      }


      // Вставка в Compilation
      String sqlAddNewCompilation = "INSERT INTO Compilation (IDCompilation, IDGenre, NameCompilation) VALUES (?, ?, ?)";

      OleDbCommand cmdAddNewCompilation = new OleDbCommand(sqlAddNewCompilation, cn);

      cmdAddNewCompilation.Parameters.Add("@p1", OleDbType.Integer);
      cmdAddNewCompilation.Parameters.Add("@p2", OleDbType.Integer);
      cmdAddNewCompilation.Parameters.Add("@p3", OleDbType.VarChar, 50);

      cmdAddNewCompilation.Parameters[0].Value = compilationsCount + 1;
      cmdAddNewCompilation.Parameters[1].Value = idGenre;
      cmdAddNewCompilation.Parameters[2].Value = AddCompilationTextBox.Text;

      try
      {
        cmdAddNewCompilation.ExecuteNonQuery();
        MessageBox.Show("Новый сборник создан!", "Мои сборники", MessageBoxButtons.OK);
      }
      catch (OleDbException exc)
      {
        MessageBox.Show(exc.ToString());
      }

      CompilationNameComboBox.Items.Add(AddCompilationTextBox.Text);
    }
  }
}
