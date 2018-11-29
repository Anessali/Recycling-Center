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
            //This line of code loads data into the '_CIS260_recycleDataSet1.AllData' table. You can move, or remove it, as needed.
            this.allDataTableAdapter.Fill(this._CIS260_recycleDataSet1.AllData);

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // button that saves work into database
            this.allDataTableAdapter.Update(this._CIS260_recycleDataSet1.AllData);
        }
    }
}
