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
using WinFormsCampApp.DTO;

namespace WinFormsCampApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                UserLoginResponseDto response = GetUser(txtUserName.Text, txtPassword.Text);
                if (response.FullName != null)
                {
                    NavigationForm navigationForm = new NavigationForm(response);
                    navigationForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(MessageDefault.UNSUCCESSFUL);
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

        private UserLoginResponseDto GetUser(string userName , string password)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Users where UserName = @userName and Password = @password";
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", Hash(password));

            connection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();
           
            UserLoginResponseDto responseDto = new UserLoginResponseDto();
            while (reader.Read())
            {
                responseDto.Id = Convert.ToInt32(reader["Id"]);
                responseDto.FullName = Convert.ToString(reader["FullName"]);
            }

            reader.Close();
            connection.Close();

            return responseDto;
        }
    }
}
