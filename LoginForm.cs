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
  public partial class LoginForm : Form
  {
    public LoginForm()
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

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void LoginForm_Load(object sender, EventArgs e)
    {

    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      String userEmail = EmailTextBox.Text;
      String userPassword = PasswordTextBox.Text;

      String sqlAuthorization = "SELECT * FROM Users WHERE Email = \'" + userEmail + "\' AND Password = \'" + userPassword +"\'"; 

      OleDbCommand cmdCheckUser = new OleDbCommand(sqlAuthorization, cn);

      OleDbDataReader reader = cmdCheckUser.ExecuteReader();

      if (reader.HasRows) { 
        while (reader.Read()){
          String[] userNameFromTable = reader["UserName"].ToString().Split(' ');
          String userName = userNameFromTable[0];
          String userSurname = userNameFromTable[1];

          String userPosition = reader["Position"].ToString();

          switch (userPosition) {
            case "Читатель":
              ReaderForm readerForm = new ReaderForm(userName, userSurname, userEmail);
              readerForm.Show();

              break;

            case "Автор":
              AuthorForm authorForm = new AuthorForm(userName, userSurname, userEmail);
              authorForm.Show();

              break;

            case "Сотрудник":
              LibrarianForm librarianForm = new LibrarianForm();
              librarianForm.Show();

              break;
          }

          //this.Close();
          PasswordTextBox.Text = "";
        }
        
      } else {
        MessageBox.Show("Authorization failed!", "Authorization", MessageBoxButtons.OK);
      }
    }
      
    private void RegistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      RegistrationForm registration = new RegistrationForm();
      registration.Show();
    }
  }
}
