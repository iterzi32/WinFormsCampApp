namespace WinFormsCampApp.Forms
{
    partial class ProductForm
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
            label1 = new Label();
            listProduct = new ListBox();
            txtUserFullName = new TextBox();
            label2 = new Label();
            txtProduct = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            txtProductStock = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(263, 35);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 0;
            label1.Text = "Product Form";
            // 
            // listProduct
            // 
            listProduct.FormattingEnabled = true;
            listProduct.ItemHeight = 24;
            listProduct.Location = new Point(4, 95);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(222, 340);
            listProduct.TabIndex = 1;
            listProduct.SelectedIndexChanged += listProduct_SelectedIndexChanged;
            // 
            // txtUserFullName
            // 
            txtUserFullName.Location = new Point(437, 95);
            txtUserFullName.Name = "txtUserFullName";
            txtUserFullName.Size = new Size(272, 32);
            txtUserFullName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(289, 98);
            label2.Name = "label2";
            label2.Size = new Size(142, 24);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı :";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(437, 145);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(272, 32);
            txtProduct.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(349, 148);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 1;
            label3.Text = "Ürün :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(437, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Black;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(598, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(437, 321);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(598, 321);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 34);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Düzenle";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(437, 194);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(272, 32);
            txtProductStock.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(337, 197);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 0;
            label4.Text = "Stock :";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(713, 473);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtProductStock);
            Controls.Add(txtProduct);
            Controls.Add(txtUserFullName);
            Controls.Add(listProduct);
            Controls.Add(label1);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            FormClosed += ProductForm_FormClosed;
            Load += ProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listProduct;
        private TextBox txtUserFullName;
        private Label label2;
        private TextBox txtProduct;
        private Label label3;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnEdit;
        private TextBox txtProductStock;
        private Label label4;
    }
}