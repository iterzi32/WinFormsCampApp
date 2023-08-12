using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCampApp.Default;
using WinFormsCampApp.DTO;
using WinFormsCampApp.Entities;

namespace WinFormsCampApp.Forms
{
    public partial class ProductForm : Form
    {
        UserLoginResponseDto responseDto;
        Product selectedProduct;
        public ProductForm(UserLoginResponseDto responseDto)
        {
            InitializeComponent();
            this.responseDto = responseDto;
            Refresh();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (responseDto.Id != 0)
            {
                txtUserFullName.Text = responseDto.FullName;
            }
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProduct.SelectedItem != null)
            {
                selectedProduct = (Product)listProduct.SelectedItem;
                txtProduct.Text = selectedProduct.Name;
                txtProductStock.Text = Convert.ToString(selectedProduct.Stock);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduct.Text) && !string.IsNullOrEmpty(txtProductStock.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Products(Name , Stock) values(@name , @stock)";
                command.Parameters.AddWithValue("@name", txtProduct.Text);
                command.Parameters.AddWithValue("@stock", txtProductStock.Text);

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (affectedRows != 0)
                {
                    Refresh();
                    ClearText();
                    MessageBox.Show(MessageDefault.SUCCESSFUL);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduct.Text) && !string.IsNullOrEmpty(txtProductStock.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "update Products set Name = @name , Stock = @stock where Id = @id";
                command.Parameters.AddWithValue("@name", txtProduct.Text);
                command.Parameters.AddWithValue("@stock", Convert.ToInt32(txtProductStock.Text));
                command.Parameters.AddWithValue("@id", selectedProduct.Id);

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (affectedRows != 0)
                {
                    Refresh();
                    ClearText();
                    MessageBox.Show(MessageDefault.SUCCESSFUL);
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
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduct.Text) && !string.IsNullOrEmpty(txtProductStock.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "delete from Products where Id = @id";
                command.Parameters.AddWithValue("@id", selectedProduct.Id);

                connection.Open();
                int affectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (affectedRows != 0)
                {
                    Refresh();
                    ClearText();
                    MessageBox.Show(MessageDefault.SUCCESSFUL);
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
       
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProduct.Text) && !string.IsNullOrEmpty(txtProductStock.Text))
            {
                ClearText();
            }
            else
            {
                MessageBox.Show(MessageDefault.WARNING);
            }
        }

        public void Refresh()
        {
            listProduct.DataSource = null;
            listProduct.DataSource = GetProductList();
            listProduct.DisplayMember = "Name";
            listProduct.ValueMember = "Id";
        }

        private void ClearText()
        {
            txtProduct.Text = null;
            txtProductStock.Text = null;
            selectedProduct = null;

        }

        private List<Product> GetProductList()
        {
            List<Product> productList = new List<Product>();

            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Product product = new Product();
                product.Id = Convert.ToInt32(reader["Id"]);
                product.Stock = Convert.ToInt32(reader["Stock"]);
                product.Name = Convert.ToString(reader["Name"]);
                productList.Add(product);
            }
            reader.Close();
            connection.Close();

            return productList;
        }


    }
}
