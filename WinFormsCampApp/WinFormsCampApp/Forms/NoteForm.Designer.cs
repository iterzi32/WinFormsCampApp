namespace WinFormsCampApp.Forms
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listNote = new ListBox();
            label1 = new Label();
            txtUserFullName = new TextBox();
            txtNote = new RichTextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // listNote
            // 
            listNote.FormattingEnabled = true;
            listNote.ItemHeight = 24;
            listNote.Location = new Point(12, 59);
            listNote.Name = "listNote";
            listNote.Size = new Size(290, 364);
            listNote.TabIndex = 0;
            listNote.SelectedIndexChanged += listNote_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(390, 59);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı :";
            // 
            // txtUserFullName
            // 
            txtUserFullName.Location = new Point(538, 56);
            txtUserFullName.Name = "txtUserFullName";
            txtUserFullName.Size = new Size(244, 32);
            txtUserFullName.TabIndex = 0;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(390, 114);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(392, 168);
            txtNote.TabIndex = 1;
            txtNote.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(390, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(612, 317);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(390, 371);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 37);
            btnClear.TabIndex = 4;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(612, 371);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(170, 37);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Font = new Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 34);
            label2.TabIndex = 6;
            label2.Text = "Note Formu";
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(794, 462);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtNote);
            Controls.Add(txtUserFullName);
            Controls.Add(label1);
            Controls.Add(listNote);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "NoteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteForm";
            FormClosed += NoteForm_FormClosed;
            Load += NoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listNote;
        private Label label1;
        private TextBox txtUserFullName;
        private RichTextBox txtNote;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnEdit;
        private Label label2;
    }
}