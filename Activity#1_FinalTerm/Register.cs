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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (fullName == "" || username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all the fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = ?";

                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int userCount = (int)checkCmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another username.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string q = @"INSERT INTO Users (Username, PasswordHash, FullName, UserRole, isActive) VALUES (?, ?, ?, ?, ?)";

                        using (OleDbCommand cmd = new OleDbCommand(q, con))
                        {
                            string passwordHash = PasswordHelper.HashPassword(password);
                            cmd.Parameters.AddWithValue("@Username", username);
                            cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                            cmd.Parameters.AddWithValue("@FullName", fullName);
                            cmd.Parameters.AddWithValue("@UserRole", "User");
                            cmd.Parameters.AddWithValue("@isActive", true);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User registered successfully.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtFullName.Clear();
                                txtUsername.Clear();
                                txtPassword.Clear();
                                txtConfirmPassword.Clear();

                                Login login = new Login();
                                login.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Failed to register user. Please try again.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering the user: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
