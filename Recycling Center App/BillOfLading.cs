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

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument docPrint = new PrintDocument();

            //This allows the user to select the page rank to print
            printDiag.AllowSomePages = true;

            //shows help button
            printDiag.ShowHelp = true;

            ///Sets the document property PrintDocument object, docPrint.
            printDiag.Document = docPrint;

            DialogResult result = printDiag.ShowDialog();

            //Tells it to print doc if result is OK
            if(result == DialogResult.OK)
            {
                docPrint.Print();
            }

        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Renders the message on the printed document
            string text = "This is a test.";
            Font printFont = new Font("Arial", 35, FontStyle.Regular);

            //Draws the content
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
        }
    }
}
