using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1_FinalTerm
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
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

        private void lblInStock_Click(object sender, EventArgs e)
        {

        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                loadStats();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
