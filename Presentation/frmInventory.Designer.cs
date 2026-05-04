namespace IMS.Presentation
{
    partial class frmInventory
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
            btnBackDash = new Button();
            txtProductName = new TextBox();
            cmbCategory = new ComboBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtReorder = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            productGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // btnBackDash
            // 
            btnBackDash.Location = new Point(676, 12);
            btnBackDash.Name = "btnBackDash";
            btnBackDash.Size = new Size(112, 23);
            btnBackDash.TabIndex = 1;
            btnBackDash.Text = "Back to Dashbord";
            btnBackDash.UseVisualStyleBackColor = true;
            btnBackDash.Click += btnBackDash_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(134, 61);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 23);
            txtProductName.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(134, 32);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(125, 23);
            cmbCategory.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(134, 90);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(134, 119);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 23);
            txtStock.TabIndex = 5;
            // 
            // txtReorder
            // 
            txtReorder.Location = new Point(134, 148);
            txtReorder.Name = "txtReorder";
            txtReorder.Size = new Size(125, 23);
            txtReorder.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 7;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 64);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 8;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 93);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 122);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 151);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 11;
            label5.Text = "Reorder";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(280, 33);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(280, 64);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 93);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(280, 122);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new Point(24, 184);
            productGridView.Name = "productGridView";
            productGridView.Size = new Size(747, 254);
            productGridView.TabIndex = 16;
            productGridView.CellContentClick += productGridView_CellContentClick;
            // 
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productGridView);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtReorder);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(cmbCategory);
            Controls.Add(txtProductName);
            Controls.Add(btnBackDash);
            Name = "frmInventory";
            Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackDash;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtReorder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView productGridView;
    }
}