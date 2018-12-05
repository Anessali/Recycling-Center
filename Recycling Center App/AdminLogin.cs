using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recycling_Center_App
{
    public partial class AdminLogin : Form
    {
        List<Administrator> admin;
        CIS260_recycleDataContext dc;
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            dc = new CIS260_recycleDataContext();
            admin = dc.Administrators.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == admin[0].AdministratorPassword)
            {
                lblPasswordMismatch.Text = "Password correct. Logging in.";
                lblPasswordMismatch.ForeColor = Color.Green;
                lblPasswordMismatch.Visible = true;
                AdminPage startPage = new AdminPage();
                this.Close();
                startPage.Show();
            }
            else
            {
                //Error message is thrown if user enters wrong password
                lblPasswordMismatch.Text = "Password mismatch. Please try again.";
                lblPasswordMismatch.ForeColor = Color.Red;
                lblPasswordMismatch.Visible = true;
            }
        }
    }
}
