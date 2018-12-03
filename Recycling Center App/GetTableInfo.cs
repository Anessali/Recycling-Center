using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ************************************************************* *
 * Contact Tj Liggett if you have any questions about this page  *
 * Email: liggetttj@gmail.com                                    *
 * Github: https://github.com/ShiroNya                           *
 * ************************************************************* */

namespace Recycling_Center_App
{
    /// <summary>
    /// Class used to get database information.
    /// </summary>
    class GetTableInfo
    {
        private DataGridView grid;
        public GetTableInfo(DataGridView grid)
        {
            this.grid = grid;
        }

        /// <summary>
        /// Runs select statement in ComputerRecyclingLocation table
        /// to get info at ID 1.
        /// </summary>
        /// <returns></returns>
        public static IQueryable<ComputerRecyclingLocation> GetLocation(int id)
        {
            CIS260_recycleDataContext dc = new CIS260_recycleDataContext();
            IQueryable<ComputerRecyclingLocation> query =
                 from loc in dc.ComputerRecyclingLocations
                 where loc.LocationID == 1
                 select loc;
            return query;
        }

        /// <summary>
        /// Returns a List of the selected row's values.
        /// </summary>
        /// <returns></returns>
        public List<string> GridInfoList()
        {
            List<string> data = new List<string>();
            for (int i = 0; i < grid.SelectedRows[0].Cells.Count; i++)
            {
                if (grid.SelectedRows[0].Cells[i].Value == null)
                {
                    data.Add("");
                }
                else
                {
                    data.Add(grid.SelectedRows[0].Cells[i].Value.ToString());
                }
            }
            return data;
        }
    }
}
