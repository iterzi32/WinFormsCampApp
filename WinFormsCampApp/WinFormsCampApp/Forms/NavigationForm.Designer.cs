namespace WinFormsCampApp.Forms
{
    partial class NavigationForm
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
            btnNoteList = new Button();
            btnProductList = new Button();
            SuspendLayout();
            // 
            // btnNoteList
            // 
            btnNoteList.BackColor = Color.Black;
            btnNoteList.ForeColor = Color.White;
            btnNoteList.Location = new Point(35, 50);
            btnNoteList.Name = "btnNoteList";
            btnNoteList.Size = new Size(401, 67);
            btnNoteList.TabIndex = 1;
            btnNoteList.Text = "Not Listesi";
            btnNoteList.UseVisualStyleBackColor = false;
            btnNoteList.Click += btnNoteList_Click;
            // 
            // btnProductList
            // 
            btnProductList.BackColor = Color.Black;
            btnProductList.ForeColor = Color.White;
            btnProductList.Location = new Point(35, 142);
            btnProductList.Name = "btnProductList";
            btnProductList.Size = new Size(401, 67);
            btnProductList.TabIndex = 2;
            btnProductList.Text = "Ürün Listesi";
            btnProductList.UseVisualStyleBackColor = false;
            btnProductList.Click += btnProductList_Click;
            // 
            // NavigationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(464, 261);
            Controls.Add(btnProductList);
            Controls.Add(btnNoteList);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "NavigationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NavigationForm";
            FormClosed += NavigationForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNoteList;
        private Button btnProductList;
    }
}