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


        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_CIS260_recycleDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this._CIS260_recycleDataSet.Vendors);

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._CIS260_recycleDataSet);

        }



        /* private void saveToolStripButton_Click(object sender, EventArgs e)
         {
             DataSet ds = new DataSet();

             string connetionString = null;
              connetionString = @"Data Source=stusql.ckwia8qkgyyj.us-east-1.rds.amazonaws.com;";
              SqlConnection cnn = new SqlConnection(connetionString);
              SqlCommand cmd = new SqlCommand();
              cmd.Connection = cnn;

             /* cmd.Parameters.AddWithValue("@VendorID", datView.row);
              cmd.Parameters.AddWithValue("@Hours", hours);

             SqlDataAdapter da = new SqlDataAdapter(cmd);

             try
             {
                 da.Update(ds, "Vendors");
                 MessageBox.Show("Saved");


             }
             catch (Exception ee)
             {
                 MessageBox.Show(ee.Message);
             }
         }*/
    }
}
