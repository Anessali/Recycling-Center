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

        public AdminPage()
        {
            InitializeComponent();
            
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            /* --Unused code Preston had written--
            string sqlString = txtSql.Text;
           // Credentials cred = new Credentials();
           // cred.SqlString = sqlString;
            this.allDataTableAdapter.Connection.Close();
            this.allDataTableAdapter.Connection.ConnectionString = sqlString;
            */
        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            VendorsPage newTable = new VendorsPage();
            newTable.Show();
        }
    }
}
