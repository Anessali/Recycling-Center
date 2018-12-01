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
            //Sets up printed area
            string printedText = String.Format("Name:\t{0}\nAddress:\t{1}\nDate:\t{2}\n" +
                "Dept:\t{3}\nAccount:\t{4}", 
            txtBxFromName.Text, txtBxFromAddress.Text, txtBxFromDate.Text, 
            txtBxFromDept.Text, txtBxFromAcct.Text);

            //Sets up the font used
            int fontSize = Convert.ToInt32(numFontSize.Text);
            Font setFont = new Font("Times New Roman", fontSize, FontStyle.Regular);

            e.Graphics.DrawString(printedText, setFont, Brushes.Black, new PointF(100, 100));
        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            /** Currently unused print dialog. Will allow user to select printer
            PrintDocument docPrint = new PrintDocument();

            //This allows the user to select the page rank to print
            printDiag.AllowSomePages = true;

            //shows help button
            printDiag.ShowHelp = true;

            ///Sets the document property PrintDocument object, docPrint.
            printDiag.Document = docPrint;

            DialogResult result = printDiag.ShowDialog();

            //Tells it to print doc if result is OK
            if (result == DialogResult.OK)
            {
                docPrint.Print();
            }
            */
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
