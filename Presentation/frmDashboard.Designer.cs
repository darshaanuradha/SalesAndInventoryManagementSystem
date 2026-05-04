namespace IMS.Presentation
{
    partial class frmDashboard
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
            btnExit = new Button();
            btnNewSale = new Button();
            btnInventory = new Button();
            btnCustomers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(463, 5);
            label1.Name = "label1";
            label1.Padding = new Padding(100, 5, 100, 5);
            label1.Size = new Size(264, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(756, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "x";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnNewSale
            // 
            btnNewSale.Location = new Point(12, 7);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(75, 25);
            btnNewSale.TabIndex = 2;
            btnNewSale.Text = "New Sale";
            btnNewSale.UseVisualStyleBackColor = true;
            btnNewSale.Click += btnNewSale_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(93, 7);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(75, 25);
            btnInventory.TabIndex = 3;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(174, 8);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(75, 23);
            btnCustomers.TabIndex = 4;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCustomers);
            Controls.Add(btnInventory);
            Controls.Add(btnNewSale);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnExit;
        private Button btnNewSale;
        private Button btnInventory;
        private Button btnCustomers;
    }
}