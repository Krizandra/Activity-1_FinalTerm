using Activity1_FinalTerm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1_FinalTerm
{
    public partial class ucProducts : UserControl
    {

        private int selectedProductID = 0;

        public ucProducts()
        {
            InitializeComponent();

            txtSearch.SetPlaceholder("Search Product...", showWhenFocused: true);

            loadProducts();
        }

        private void loadProducts(string searchKeyword = "")
        {

            if (searchKeyword == "Search Product...")
            {
                searchKeyword = "";
            }

            try
            {

                using (OleDbConnection conn = Database.GetConnection())
                {

                    conn.Open();

                    string q = @"SELECT * FROM Products";

                    if (!string.IsNullOrWhiteSpace(searchKeyword))
                    {

                        q += " WHERE ProductName LIKE ? OR Category LIKE ? OR Description LIKE ?";

                    }

                    q += " ORDER BY ProductID DESC";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {

                        if (!string.IsNullOrWhiteSpace(searchKeyword))
                        {

                            string pattern = "%" + searchKeyword + "%";
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = pattern;
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = pattern;
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = pattern;

                        }

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {

                            DataTable dt = new DataTable();

                            adapter.Fill(dt);

                            dgvProducts.DataSource = null;
                            dgvProducts.Columns.Clear();
                            dgvProducts.AutoGenerateColumns = true;

                            dgvProducts.DataSource = dt;

                        }


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Unable to load products: " + ex.Message, "Unable to load products", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void loadStats()
        {

            try
            {

                using (OleDbConnection conn = Database.GetConnection())
                {

                    conn.Open();

                    string q = @"SELECT 
                                    COUNT(*) AS TotalProducts, 
                                    SUM(IIF(Quantity > ReorderLevel, 1, 0)) AS InStock, 
                                    SUM(IIF(Quantity > 0 AND Quantity <= ReorderLevel, 1, 0)) AS LowStock, 
                                    SUM(IIF(Quantity <= 0, 1, 0)) AS OutOfStock 
                                    FROM Products";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {

                        if (rdr.Read())
                        {
                            lblTotal.Text = rdr["TotalProducts"].ToString();
                            lblInStock.Text = rdr["InStock"] != DBNull.Value ? rdr["InStock"].ToString() : "0";
                            lblLowStock.Text = rdr["LowStock"] != DBNull.Value ? rdr["LowStock"].ToString() : "0";
                            lblOutOfStock.Text = rdr["OutOfStock"] != DBNull.Value ? rdr["OutOfStock"].ToString() : "0";
                        }

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Statistic Error: " + ex.Message, "Statistics Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ucProducts_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                loadStats();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Product...")
            {
                loadProducts("");
                return;
            }

            loadProducts(txtSearch.Text);
        }

        private bool ValidateProduct()
        {

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
                return false;
            }

            if (txtCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a category.");
                txtCategory.Focus();
                return false;
            }

            decimal price;

            if (!decimal.TryParse(txtUnitPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a product price.");
                txtUnitPrice.Focus();
                return false;
            }

            int quantity;

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter quantity.");
                txtQuantity.Focus();
                return false;
            }

            int reorder;

            if (!int.TryParse(txtReorderLevel.Text, out reorder) || reorder < 0)
            {
                MessageBox.Show("Please enter reorder level.");
                txtReorderLevel.Focus();
                return false;
            }

            return true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                return;
            }

            try
            {

                using (OleDbConnection conn = Database.GetConnection())
                {

                    conn.Open();

                    string q = @"INSERT INTO Products (ProductName, Category, Description, UnitPrice, Quantity, ReorderLevel, CreatedAt) VALUES (?, ?, ?, ?, ?, ?, Now())";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {

                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtProductName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtCategory.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = txtDescription.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(txtUnitPrice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtQuantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtReorderLevel.Text);

                        cmd.ExecuteNonQuery();

                    }

                }

                MessageBox.Show("Product added successfully!", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearField();
                loadProducts();
                loadStats();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding products: " + ex.Message, "Error adding products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearField()
        {
            txtProductName.Clear();
            txtCategory.SelectedIndex = -1;
            txtUnitPrice.SelectedIndex = -1;
            txtUnitPrice.Text = "";
            txtQuantity.Clear();
            txtReorderLevel.Clear();
            txtDescription.Clear();

            selectedProductID = 0;

            dgvProducts.ClearSelection();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);

                txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();

            }
        }

        private bool ValidateEditProduct()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.");
                txtProductName.Focus();
                return false;
            }

            if (txtCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                txtCategory.Focus();
                return false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid product price.");
                txtUnitPrice.Focus();
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtQuantity.Focus();
                return false;
            }

            if (!int.TryParse(txtReorderLevel.Text, out int reorder) || reorder < 0)
            {
                MessageBox.Show("Please enter a valid reorder level.");
                txtReorderLevel.Focus();
                return false;
            }

            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {

                MessageBox.Show("Please select a product row to update");
                return;

            }

            if (!ValidateEditProduct())
            {
                return;
            }

            try
            {

                using (OleDbConnection conn = Database.GetConnection())
                {

                    conn.Open();

                    string q = @"UPDATE Products SET ProductName=?, Category=?, Description=?, UnitPrice=?, Quantity=?, ReorderLevel=? WHERE ProductID=?";

                    using (OleDbCommand cmd = new OleDbCommand(q, conn))
                    {

                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtProductName.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtCategory.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = txtDescription.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(txtUnitPrice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtQuantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtReorderLevel.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductID;

                        cmd.ExecuteNonQuery();

                    }

                }

                MessageBox.Show("Product updated successfully!", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearField();
                loadProducts();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating products: " + ex.Message, "Error updating products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {

                MessageBox.Show("Please select a product row to delete.");
                return;

            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {

                try
                {

                    using (OleDbConnection conn = Database.GetConnection())
                    {

                        conn.Open();

                        string q = @"DELETE FROM Products WHERE ProductID=?";

                        using (OleDbCommand cmd = new OleDbCommand(q, conn))
                        {

                            cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductID;

                            cmd.ExecuteNonQuery();

                        }

                    }

                    MessageBox.Show("Product deleted successfully!", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearField();
                    loadProducts();
                    loadStats();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error deleting product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            loadStats();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
