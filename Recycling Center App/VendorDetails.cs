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
    public partial class VendorDetails : Form
    {
        bool isEdited = false;
        int vendorID;
        CIS260_recycleDataContext dc;
        public VendorDetails()
        {
            InitializeComponent();
        }

        public VendorDetails(bool isEdited, int vendorID)
        {
            this.isEdited = isEdited;
            this.vendorID = vendorID;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dc = new CIS260_recycleDataContext();

            if (isEdited == false)
            {
                Vendor obj = new Vendor();
                //Adds values from form
                obj.VendorName = txtName.Text;
                obj.StreetAddress1 = txtStreet.Text;
                obj.StreetAddress2 = txtStreet2.Text;
                obj.City = txtCity.Text;
                obj.State = txtState.Text;
                obj.Country = txtCountry.Text;
                obj.Zip = txtZip.Text;
                if (obj.StreetAddress2 == "")
                {
                    obj.StreetAddress2 = null;
                }
                dc.Vendors.InsertOnSubmit(obj);
                dc.SubmitChanges();
                MessageBox.Show("Inserted into the table");
            }
            else
            {
                //Code runs when entry is being updated
                Vendor obj = dc.Vendors.SingleOrDefault(E => E.VendorID == vendorID);
                obj.VendorName = txtName.Text;
                obj.StreetAddress1 = txtStreet.Text;
                obj.StreetAddress2 = txtStreet2.Text;
                obj.City = txtCity.Text;
                obj.State = txtState.Text;
                obj.Country = txtCountry.Text;
                obj.Zip = txtZip.Text;
                dc.SubmitChanges();
                MessageBox.Show("Record updated");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
