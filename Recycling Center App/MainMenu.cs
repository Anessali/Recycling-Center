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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillOfLading newBill = new BillOfLading();
            newBill.Show();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            MaterialsLabelF newLabel = new MaterialsLabelF();
            newLabel.Show();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            frmDatabase newData = new frmDatabase();
            newData.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPage newAdmin = new AdminPage();
            newAdmin.Show();
        }
    }
}
