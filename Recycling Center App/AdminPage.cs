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
    public partial class AdminPage : Form
    {
        /*
         * This was going to be an admin page that required a password and name to get into
         * on this page would have been a way to change the sql connection string and 
         * any other work that should be password protected. 
        */
        public AdminPage()
        {
            InitializeComponent();
            
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            string sqlString = txtSql.Text;
           // Credentials cred = new Credentials();
           // cred.SqlString = sqlString;
            this.allDataTableAdapter.Connection.Close();
            this.allDataTableAdapter.Connection.ConnectionString = sqlString;

        }
    }
}
