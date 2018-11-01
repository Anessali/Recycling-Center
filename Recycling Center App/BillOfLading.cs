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
            int fontSize;
            //Determines what is printed
            string printedText; 
            

            fontSize = Convert.ToInt32(numFontSize.Text);

            //From text
            printedText = String.Format("Name:\t{0}\nAddress:\t{1}\nDate:\t{2}\n" +
                "Dept:\t{3}\nAccount:\t{4}", txtBxFromName.Text, txtBxFromAddress.Text, 
                txtBxFromDate.Text, txtBxFromDept.Text, txtBxFromAcct.Text);
            e.Graphics.DrawString("From", GetFont(24), Brushes.Black, new PointF(90, 100));
            e.Graphics.DrawString(printedText, GetFont(fontSize), Brushes.Black, new PointF(100, 140));

            //To text
            printedText = String.Format("Name:\t{0}\nCompany: {1}\nStreet:\t{2}\n" +
                "Location:\t{3}, {4}\nAcct:\t{5}",
                txtBxToName.Text, txtBxToCompany.Text, txtBxToStreet.Text, txtBxToCity.Text,
                txtBxToState.Text, txtBxToAccount.Text);
            e.Graphics.DrawString("To", GetFont(24), Brushes.Black, new PointF(90, 270));
            e.Graphics.DrawString(printedText, GetFont(fontSize), Brushes.Black, new PointF(100, 310));

        }

        /// <summary>
        /// Call GetFont(int) to set font
        /// </summary>
        /// <param name="fontSize"></param>
        /// <returns></returns>
        public Font GetFont(int fontSize)
        {
            Font setFont = new Font("Times New Roman", fontSize, FontStyle.Regular);
            return setFont;
        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            printDiag.ShowHelp = true;
            printDiag.Document = printDocument1;
            //MessageBox.Show("Test 1");
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Test 2");
                DialogResult result = printDiag.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Test 3");
                    printDocument1.Print();
                }
            }
        }

        private void BillOfLading_Load(object sender, EventArgs e)
        {
            DateTime dateTest = new DateTime();
            dateTest = DateTime.Now;
            txtBxFromName.Text = "Tj Liggett";
            txtBxFromAddress.Text = "Platform 9 and 3/4";
            txtBxFromDate.Text = dateTest.ToString("MM/dd/yyyy");
            txtBxFromAddress.Text = "Test Address";
            txtBxFromDept.Text = "Some department name";
            txtBxFromAcct.Text = "This tests account";
            txtBxToName.Text = "Bob Ross";
            txtBxToCompany.Text = "Bob Ross Inc";
            txtBxToStreet.Text = "271 N Briar Lane";
            txtBxToCity.Text = "Springfield";
            txtBxToState.Text = "MO";
            txtBxToAccount.Text = 2524524.ToString();
        }
    }
}
