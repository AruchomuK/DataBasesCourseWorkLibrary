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
  public partial class RegistrationForm : Form
  {
    public RegistrationForm()
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

    private void RNameLabel_Click(object sender, EventArgs e)
    {

    }

    private void RPasswordLabel_Click(object sender, EventArgs e)
    {

    }

    private void RegistrationForm_Load(object sender, EventArgs e)
    {

    }

    private void RegistrationButton_Click(object sender, EventArgs e)
    {
      String sqlRegistration = "INSERT INTO Users (UserName, Email, Position, Password) VALUES (?, ?, ?, ?)";

      OleDbCommand cmdRegistration = new OleDbCommand(sqlRegistration, cn);

      cmdRegistration.Parameters.Add("@p1", OleDbType.VarChar, 50);
      cmdRegistration.Parameters.Add("@p2", OleDbType.VarChar, 50);
      cmdRegistration.Parameters.Add("@p3", OleDbType.VarChar, 30);
      cmdRegistration.Parameters.Add("@p4", OleDbType.VarChar, 50);

      cmdRegistration.Parameters[0].Value = RNameTextBox.Text + " " + RSurenameTextBox.Text;
      cmdRegistration.Parameters[1].Value = REmailTextBox.Text;
      cmdRegistration.Parameters[2].Value = RPositionComboBox.Text;
      cmdRegistration.Parameters[3].Value = RPasswordTextBox.Text;

      try {
        cmdRegistration.ExecuteNonQuery();
        MessageBox.Show("Вы зарегистрированы!", "Регистрация", MessageBoxButtons.OK);
        this.Close();

      }
      catch (OleDbException exc) {  
        MessageBox.Show(exc.ToString());
      }
    }
  }
}
