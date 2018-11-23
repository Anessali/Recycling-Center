using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Recycling_Center_App
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
           // fillTable();
            
        }

       /* private void fillTable()
        {
            string getVendor = "Select VendorName from Vendors";
            string getMaterial = "Select * from Materials";

            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString =
                "Data Source=stusql.ckwia8qkgyyj.us-east-1.rds.amazonaws.com;" +
                "Initial Catalog=CIS260-recycle;" +
                "User id= ph0859241;" +
                "Password=0859241;";
                conn.Open();
                SqlCommand cmd = new SqlCommand(getVendor, conn);
                SqlDataReader  reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtBoxData.Text = txtBoxData.Text + reader.GetValue(0) + "\n";
                }

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //throw;
            } 

            
        }*/

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CIS260_recycleDataSet1.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this._CIS260_recycleDataSet1.AllData);

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.allDataTableAdapter.Update(this._CIS260_recycleDataSet1.AllData);
        }
    }
}
