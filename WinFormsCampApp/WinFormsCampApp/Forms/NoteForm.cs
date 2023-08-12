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
    public partial class NoteForm : Form
    {
        UserLoginResponseDto responseDto;
        Note selectedNote;
        public NoteForm(UserLoginResponseDto responseDto)
        {
            InitializeComponent();
            this.responseDto = responseDto;
            Refresh();
        }


        private void NoteForm_Load(object sender, EventArgs e)
        {
            if (responseDto.Id != 0)
            {
                txtUserFullName.Text = responseDto.FullName;
            }
         
        }
        private void NoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNote.SelectedItem != null)
            {
                selectedNote = listNote.SelectedItem as Note;
                txtNote.Text = selectedNote.Description;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNote.Text) && responseDto.Id != 0)
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Notes(Description , UserId) values(@description , @userId)";
                command.Parameters.AddWithValue("@description", txtNote.Text);
                command.Parameters.AddWithValue("@userId", responseDto.Id);

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
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "update Notes set Description = @description where Id = @id";
                command.Parameters.AddWithValue("@description", txtNote.Text);
                command.Parameters.AddWithValue("@id", selectedNote.Id);

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
            if (!string.IsNullOrEmpty(txtNote.Text))
            {
                ClearText();
            }
            else
            {
                MessageBox.Show(MessageDefault.WARNING);
            }
        }

        private void Refresh()
        {
            listNote.DataSource = null;
            listNote.DataSource = GetNoteList();
            listNote.DisplayMember = "Description";
            listNote.ValueMember = "Id";
        }


        private void ClearText()
        {
            txtNote.Text = null;
            selectedNote = null;

        }

        private List<Note> GetNoteList()
        {
            List<Note> notes = new List<Note>();

            if (responseDto.Id != null)
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true");
                SqlCommand command = new SqlCommand();

                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "select * from Notes where UserId = @userId";
                command.Parameters.AddWithValue("@userId", responseDto.Id);

                connection.Open();
                var reader = command.ExecuteReader();
                command.Parameters.Clear();

                while (reader.Read())
                {
                    Note note = new Note();
                    note.Id = Convert.ToInt32(reader["Id"]);
                    note.Description = Convert.ToString(reader["Description"]);
                    note.UserId = Convert.ToInt32(reader["UserId"]);
                    notes.Add(note);
                }

                reader.Close();
                connection.Close();
            }

            else
            {
                MessageBox.Show(MessageDefault.UNSUCCESSFUL);
            }
            return notes;
        }
    }
}
