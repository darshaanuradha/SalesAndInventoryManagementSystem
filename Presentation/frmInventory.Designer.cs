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
            // frmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackDash);
            Name = "frmInventory";
            Text = "frmInventory";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBackDash;
    }
}