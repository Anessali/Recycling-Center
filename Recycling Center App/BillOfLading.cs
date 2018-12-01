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
using System.Data.SqlClient;

/* ******************************************************************* *
 * Contact Tj Liggett if you have any questions about the BillOfLading *
 * Email: liggetttj@gmail.com                                          *
 * Github: https://github.com/ShiroNya                                 *
 * ******************************************************************* */

namespace Recycling_Center_App
{
    public partial class BillOfLading : Form
    {
        CIS260_recycleDataContext dc;

        public BillOfLading()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region Set variables
            int fontSize = 14;
            int xCoordOne = 120,
                xCoordTwo = xCoordOne + 310,
                yCoordOne = 200;
            int borderDistance = 20;
            string fromText = "",
                toText = "";
            Pen pen = new Pen(Brushes.Black);
            DateTime currentDate = DateTime.Now;
            int locationId = 1;
            GetTableInfo getAllData = new GetTableInfo(dGridPackages);
            #endregion

            #region Sets up and prints page
            //Aligns text on page
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;

            //DrawBorders(e, borderDistance, pen);

            //Company logo
            Bitmap getLogo = new Bitmap(Properties.Resources.logo);
            Bitmap logo = new Bitmap(getLogo, new Size(Convert.ToInt32(getLogo.Width / 1.4), Convert.ToInt32(getLogo.Height / 1.4)));
            e.Graphics.DrawImage(logo, borderDistance + 10, borderDistance + 10);

            //From text
            foreach (ComputerRecyclingLocation location in GetTableInfo.GetLocation(locationId))
            {
                //MessageBox.Show($"{location.City}");
                fromText = $"Name:\t{location.LocationName}\n\t{location.StreetAddress1}\n" +
                    $"\t{location.City}, {location.State} {location.Zip}\nDate:\t{currentDate}";
            }
            e.Graphics.DrawString("From", GetFont(24), Brushes.Black, new PointF(xCoordOne + 120, yCoordOne));
            e.Graphics.DrawString(fromText, GetFont(fontSize), Brushes.Black, xCoordOne, yCoordOne + 40);


            //To text
            e.Graphics.DrawString("To", GetFont(24), Brushes.Black, new PointF(xCoordTwo + 120, yCoordOne));
            e.Graphics.DrawString(toText, GetFont(fontSize), Brushes.Black, new PointF(xCoordTwo + 10, yCoordOne + 40));

            //Prints info from selected box
            //Setup
            e.Graphics.DrawString("Number", GetFont(16), Brushes.Black, new PointF(xCoordOne, yCoordOne + 200));
            e.Graphics.DrawString("Of", GetFont(16), Brushes.Black, new PointF(xCoordOne, yCoordOne + 225));
            e.Graphics.DrawString("Items", GetFont(16), Brushes.Black, new PointF(xCoordOne, yCoordOne + 250));
            e.Graphics.DrawString("Kind of Package,", GetFont(16), Brushes.Black, new PointF(xCoordOne + 170, yCoordOne + 200));
            e.Graphics.DrawString("Description of Articles,", GetFont(16), Brushes.Black, new PointF(xCoordOne + 150, yCoordOne + 225));
            e.Graphics.DrawString("Special Marks, and Exceptions,", GetFont(16), Brushes.Black, new PointF(xCoordOne + 120, yCoordOne + 250));
            e.Graphics.DrawString("Weight in Lbs.", GetFont(16), Brushes.Black, new PointF(xCoordOne + 450, yCoordOne + 200));
            e.Graphics.DrawString("(Subject", GetFont(16), Brushes.Black, new PointF(xCoordOne + 450, yCoordOne + 225));
            e.Graphics.DrawString("to Change)", GetFont(16), Brushes.Black, new PointF(xCoordOne + 450, yCoordOne + 250));


            e.Graphics.DrawLine(pen, xCoordOne - 30, yCoordOne + 280, xCoordTwo + 320, yCoordOne + 280);
            //Info from AllData table
            e.Graphics.DrawString($"{getAllData.GridInfoList()[7]}", GetFont(16), Brushes.Black, new PointF(xCoordOne, yCoordOne + 300));
            //e.Graphics.DrawString($"{getAllData.GridInfoList()[7]}", GetFont(16), Brushes.Black, new PointF(xCoordOne, yCoordOne + 300));
            e.Graphics.DrawString($"{getAllData.GridInfoList()[6]}", GetFont(16), Brushes.Black, new PointF(xCoordOne + 450, yCoordOne + 300));
            e.Graphics.DrawString($"{(Convert.ToInt32(getAllData.GridInfoList()[6]) * Convert.ToInt32(getAllData.GridInfoList()[7]))}", GetFont(16), Brushes.Black, new PointF(xCoordOne + 570, yCoordOne + 300));
            #endregion
        }



        private void printBtn_Click(object sender, EventArgs e)
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
            this.WindowState = FormWindowState.Maximized;
            dGridPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //pulls boxes into datagrid
            dc = new CIS260_recycleDataContext();
            dGridPackages.DataSource = dc.AllDatas;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGridPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
