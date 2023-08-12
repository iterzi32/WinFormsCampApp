using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCampApp.DTO;

namespace WinFormsCampApp.Forms
{
    public partial class NavigationForm : Form
    {
        UserLoginResponseDto responseDto;
        public NavigationForm(UserLoginResponseDto responseDto)
        {
            InitializeComponent();
            this.responseDto = responseDto;
        }

        private void NavigationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNoteList_Click(object sender, EventArgs e)
        {
            NoteForm noteForm = new NoteForm(responseDto);
            noteForm.Show();
            this.Hide();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(responseDto);
            productForm.Show();
            this.Hide();
        }
    }
}
