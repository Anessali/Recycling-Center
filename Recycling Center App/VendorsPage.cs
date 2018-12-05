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
    public partial class VendorsPage : Form
    {
        CIS260_recycleDataContext dc;
        public VendorsPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VendorsPage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            dc = new CIS260_recycleDataContext();
            dGridVendors.DataSource = dc.Vendors;
            dGridVendors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            VendorDetails f = new VendorDetails();
            f.ShowDialog();

            //reloads data on form3
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                VendorDetails f = new VendorDetails(true, Convert.ToInt32(dGridVendors.SelectedRows[0].Cells[0].Value));
                f.btnClear.Enabled = false;
                f.btnSave.Text = "Update";
                f.txtName.Text = dGridVendors.SelectedRows[0].Cells[1].Value.ToString();
                f.txtStreet.Text = dGridVendors.SelectedRows[0].Cells[2].Value.ToString();
                if (dGridVendors.SelectedRows[0].Cells[3].Value == null)
                {
                    f.txtStreet2.Text = "";
                }
                else
                {
                    f.txtStreet2.Text = dGridVendors.SelectedRows[0].Cells[3].Value.ToString();
                }

                f.txtCity.Text = dGridVendors.SelectedRows[0].Cells[4].Value.ToString();
                f.txtState.Text = dGridVendors.SelectedRows[0].Cells[5].Value.ToString();
                f.txtZip.Text = dGridVendors.SelectedRows[0].Cells[6].Value.ToString();
                f.txtCountry.Text = dGridVendors.SelectedRows[0].Cells[7].Value.ToString();
                f.ShowDialog();
                LoadData();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select entire row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGridVendors.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you wish to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int vendorID = Convert.ToInt32(dGridVendors.SelectedRows[0].Cells[0].Value);
                    Vendor obj = dc.Vendors.SingleOrDefault(E => E.VendorID == vendorID);
                    dc.Vendors.DeleteOnSubmit(obj);
                    dc.SubmitChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select entire row to delete record.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadData()
        {
            dc = new CIS260_recycleDataContext();
            dGridVendors.DataSource = dc.Vendors;
            
        }
    }
}
