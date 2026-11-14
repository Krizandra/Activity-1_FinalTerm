using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1_FinalTerm
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            SetActiveButton(button6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            ShowPage(new ucDashboard());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SetActiveButton(Button activeButton)
        {
            Color activeColor = SystemColors.GradientActiveCaption;
            Color defaultColor = Color.MidnightBlue;
            Color activeText = Color.MidnightBlue;
            Color defaultText = SystemColors.GradientInactiveCaption;
            Color mouseDownOver = Color.LightSteelBlue;
            Color defaultMouseDownOver = Color.RoyalBlue;

            foreach (Control control in panel3.Controls)
            {
                if (control is Button btn)
                {
                    if (btn == btnLogout) continue;

                    if (btn == activeButton)
                    {
                        btn.BackColor = activeColor;
                        btn.ForeColor = activeText;
                        btn.FlatAppearance.MouseDownBackColor = mouseDownOver;
                        btn.FlatAppearance.MouseOverBackColor = mouseDownOver;
                    }
                    else
                    {
                        btn.BackColor = defaultColor;
                        btn.ForeColor = defaultText;
                        btn.FlatAppearance.MouseOverBackColor = defaultMouseDownOver;
                        btn.FlatAppearance.MouseDownBackColor = defaultMouseDownOver;
                    }
                }
            }
        }

        private void ShowPage(UserControl page)
        {
            mainPanel.Controls.Clear();

            page.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(page);
            page.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ucDashboard db = new ucDashboard();
            db.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(db);
            SetActiveButton(button6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ucProducts products = new ucProducts();
            products.Dock = DockStyle.Top;
            mainPanel.Controls.Add(products);
            SetActiveButton(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ucUsers users = new ucUsers();
            users.Dock = DockStyle.Top;
            mainPanel.Controls.Add(users);
            SetActiveButton(button7);
        }
    }
}
