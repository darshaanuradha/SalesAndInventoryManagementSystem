using IMS.AppLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMS.Presentation
{
    public partial class frmInventory : Form
    {
        int selectedProductId = 0;
        InventoryService inventoryService = new InventoryService();
        public frmInventory()
        {
            InitializeComponent();
            LoadCategories();
            LoadProducts();
        }

        private void btnBackDash_Click(object sender, EventArgs e)
        {
            frmDashboard frmDashboard = new frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }
        private void LoadCategories()
        {
            DataTable dt = inventoryService.GetCategories();

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        private void LoadProducts()
        {
            productGridView.DataSource = inventoryService.GetProducts();
        }


        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productGridView.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                cmbCategory.Text = row.Cells["CategoryName"].Value.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtStock.Text = row.Cells["UnitsInStock"].Value.ToString();
                txtReorder.Text = row.Cells["ReorderLevel"].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            bool result = inventoryService.InsertProduct(
                Convert.ToInt32(cmbCategory.SelectedValue),
                txtProductName.Text,
                Convert.ToDecimal(txtPrice.Text),
                Convert.ToInt32(txtStock.Text),
                Convert.ToInt32(txtReorder.Text)
            );

            if (result)
            {
                MessageBox.Show("Product Added Successfully");
                LoadProducts();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Error inserting product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Select a product first");
                return;
            }


            bool result = inventoryService.UpdateProduct(
                selectedProductId,
                Convert.ToInt32(cmbCategory.SelectedValue),
                txtProductName.Text,
                Convert.ToDecimal(txtPrice.Text),
                Convert.ToInt32(txtStock.Text),
                Convert.ToInt32(txtReorder.Text)
            );

            if (result)
            {
                MessageBox.Show("Product Updated Successfully");
                ClearForm();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void ClearForm()
        {
            // Reset fields
            txtProductName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtReorder.Clear();

            // Reset ComboBox (go to first item)
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            // Reset selected product ID
            selectedProductId = 0;

            // Optional: remove selection from grid
            productGridView.ClearSelection();

            // Focus first input
            txtProductName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Select a product first");
                return;
            }

            // Confirmation dialog (IMPORTANT)
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                bool isDeleted = inventoryService.DeleteProduct(selectedProductId);

                if (isDeleted)
                {
                    MessageBox.Show("Product Deleted Successfully");
                    LoadProducts();
                    ClearForm(); 
                }
                else
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }
    }
}
