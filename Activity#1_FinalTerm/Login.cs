using Activity1_FinalTerm;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string q = "SELECT * FROM Users WHERE Username = ?";

                    using (OleDbCommand cmd = new OleDbCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string storedHash = reader["PasswordHash"].ToString();
                            string fullName = reader["FullName"].ToString();
                            string role = reader["UserRole"].ToString();
                            bool isActive = Convert.ToBoolean(reader["IsActive"]);
                            int userId = Convert.ToInt32(reader["UserID"]);

                            if (!PasswordHelper.VerifyPassword(password, storedHash))
                            {
                                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!isActive)
                            {
                                MessageBox.Show("Your account is inactive. Please contact the administrator.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show($"Welcome {fullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            reader.Close();

                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while signing in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
