using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCampApp.Default;

namespace WinFormsCampApp.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void btnRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                string userName = txtUserName.Text;
                string password = Hash(txtPassword.Text);
                string fullName = txtFullName.Text;

                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Users(UserName , Password , FullName) values(@userName , @password , @fullName)";
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@fullName", fullName);

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (affectedRows != 0)
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(MessageDefault.SUCCESSFUL);
                }

            }
            else
            {
                MessageBox.Show(MessageDefault.WARNING);
            }
        }

        private string Hash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
