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
            #region page setup variables
            int fontSize = 14;
            int xCoordOne = 120,
                xCoordTwo = xCoordOne + 310,
                yCoordOne = 200;
            int borderDistance = 10;
            Pen pen = new Pen(Brushes.Black);

            string city = "City",
                state = "State",
                zip = "ZipCode",
                address = "address",
                billOfLadingNumber = "2265";
            #endregion
            

            //Aligns text on page
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            
            DrawBorders(e, borderDistance, pen);

            //Company logo
            Bitmap getLogo = new Bitmap(Properties.Resources.logo);
            Bitmap logo = new Bitmap(getLogo, new Size(Convert.ToInt32(getLogo.Width/1.4), Convert.ToInt32(getLogo.Height/1.4)));
            e.Graphics.DrawImage(logo, borderDistance + 10, borderDistance + 10);

            //Adds other text
            e.Graphics.DrawString("Bill of Lading", GetFont(32), Brushes.Black, new PointF(500, 50));
            e.Graphics.DrawString("Bill of Lading", GetFont(fontSize), Brushes.Black, new PointF(50, 1040));
            e.Graphics.DrawString(address, GetFont(fontSize), Brushes.Black, new PointF(50, 100));
            e.Graphics.DrawString(city + ", " + state + " " + zip, GetFont(fontSize), Brushes.Black, new PointF(50, 120));
            e.Graphics.DrawString("No.:\t\t" + billOfLadingNumber, GetFont(fontSize), Brushes.Black, new PointF(520, 150));

            //From text
            string fromText = String.Format("Name:\t{0}\nAddress:\t{1}\nDate:\t{2}\n" +
                "Dept:\t{3}\nAccount:\t{4}", txtBxFromName.Text, txtBxFromAddress.Text,
                txtBxFromDate.Text, txtBxFromDept.Text, txtBxFromAcct.Text);
            e.Graphics.DrawString("From", GetFont(24), Brushes.Black, new PointF(xCoordOne, yCoordOne));
            e.Graphics.DrawString(fromText, GetFont(fontSize), Brushes.Black, xCoordOne + 10, yCoordOne + 40);


            //To text
            string toText = String.Format("Name:\t{0}\nCompany: {1}\nStreet:\t{2}\n" +
                "Location:\t{3}, {4}\nAcct:\t{5}",
                txtBxToName.Text, txtBxToCompany.Text, txtBxToStreet.Text, txtBxToCity.Text,
                txtBxToState.Text, txtBxToAccount.Text);
            e.Graphics.DrawString("To", GetFont(24), Brushes.Black, new PointF(xCoordTwo, yCoordOne));
            e.Graphics.DrawString(toText, GetFont(fontSize), Brushes.Black, new PointF(xCoordTwo + 10, yCoordOne + 40));

            //Shipped items
            e.Graphics.DrawString("Shipped items will go here", GetFont(16), Brushes.Black, new PointF(100, 470));
            e.Graphics.DrawString("Further delivery info", GetFont(16), Brushes.Black, new PointF(100, 800));

        }

        private void printBtn_Click_1(object sender, EventArgs e)
        {
            printDiag.ShowHelp = true;
            printDiag.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            //DialogResult result = printDiag.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
        }
        
        private Font GetFont(int fontSize)
        {
            Font setFont = new Font("Times New Roman", fontSize, FontStyle.Regular);
            return setFont;
        }
        
        private void DrawBorders(PrintPageEventArgs e, int borderDistance, Pen pen)
        {
            int xMargin = e.PageBounds.Width,
                yMargin = e.PageBounds.Height;
            int borderDistance2 = borderDistance + 3;
            bool doubleBorder = true;

            e.Graphics.DrawLine(pen, borderDistance, borderDistance, xMargin - borderDistance, borderDistance);
            e.Graphics.DrawLine(pen, xMargin - borderDistance, borderDistance, xMargin - borderDistance, yMargin - borderDistance);
            e.Graphics.DrawLine(pen, xMargin - borderDistance, yMargin - borderDistance, borderDistance, yMargin - borderDistance);
            e.Graphics.DrawLine(pen, borderDistance, yMargin - borderDistance, borderDistance, borderDistance);
            if (doubleBorder)
            {
                e.Graphics.DrawLine(pen, borderDistance2, borderDistance2, xMargin - borderDistance2, borderDistance2);
                e.Graphics.DrawLine(pen, xMargin - borderDistance2, borderDistance2, xMargin - borderDistance2, yMargin - borderDistance2);
                e.Graphics.DrawLine(pen, xMargin - borderDistance2, yMargin - borderDistance2, borderDistance2, yMargin - borderDistance2);
                e.Graphics.DrawLine(pen, borderDistance2, yMargin - borderDistance2, borderDistance2, borderDistance2);
            }
        }

        private void BillOfLading_Load(object sender, EventArgs e)
        {
            DateTime dateTest = new DateTime();
            dateTest = DateTime.Now;
            txtBxFromName.Text = "Tj Liggett";
            txtBxFromAddress.Text = "Platform 9 and 3/4";
            txtBxFromDate.Text = dateTest.ToString("MM/dd/yyyy");
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
