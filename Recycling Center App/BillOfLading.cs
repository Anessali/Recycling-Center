using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Recycling_Center_App
{
    public partial class BillOfLading : Form
    {
        

        public BillOfLading()
        {
            InitializeComponent();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Determines what is printed
            string printedText = String.Format("Name:\t{0}\nAddress:\t{1}\nDate:\t{2}\n" +
                "Dept:\t{3}\nAccount:\t{4}", 
            txtBxFromName.Text, txtBxFromAddress.Text, txtBxFromDate.Text, 
            txtBxFromDept.Text, txtBxFromAcct.Text);

            //Blank page testing
            printedText = "";

            //Sets up the font
            int fontSize = Convert.ToInt32(numFontSize.Text);
            Font setFont = new Font("Times New Roman", fontSize, FontStyle.Regular);

            e.Graphics.DrawString(printedText, setFont, Brushes.Black, new PointF(100, 100));
        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            printDiag.ShowHelp = true;
            printDiag.Document = printDocument1;


            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = printDiag.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void BillOfLading_Load(object sender, EventArgs e)
        {
            DateTime dateTest = new DateTime();
            dateTest = DateTime.Now;
            //txtBxFromName.Text = "Tj Liggett";
            //txtBxFromAddress.Text = "Platform 9 and 3/4";
            //txtBxFromDate.Text = dateTest.ToString("MM/dd/yyyy");
            //txtBxFromAddress.Text = "Test Address";
            //txtBxFromDept.Text = "Some department name";
            //txtBxFromAcct.Text = "This tests account";
        }
    }
}
