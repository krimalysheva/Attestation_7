using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramLogic;

namespace L1_Form
{
    class CompositionsDGVConvert
    {
        public static List<Composition> DGVToCompositionsList(DataGridView dgv)
        {
            List<Composition> compositions = new List<Composition>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                string name = row.Cells["InputCompositionsDGV_Name"].Value.ToString();
                double time = (double)Convert.ChangeType(row.Cells["InputCompositionsDGV_Points"].Value, typeof(double));
                string genre = row.Cells["InputCompositionsDGV_Genre"].Value.ToString();


                Composition composition = new Composition(name, time, genre);

                compositions.Add(composition);
            }

            return compositions;
        }

        public static void CompositionsListToDGV(DataGridView dgv, List<Composition> compositions)
        {
            dgv.Rows.Clear();

            foreach (Composition composition in compositions)
            {
                dgv.Rows.Add();

                DataGridViewRow lastRow = dgv.Rows[dgv.RowCount - 1];
                lastRow.Cells["InputCompositionsDGV_Name"].Value = composition.Name;
                lastRow.Cells["InputCompositionsDGV_Points"].Value = composition.Time;
                lastRow.Cells["InputCompositionsDGV_Genre"].Value = composition.Genre;

            }
        }
    }
}
