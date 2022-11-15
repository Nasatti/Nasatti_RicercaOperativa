using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasatti_RicercaOperativa
{
    public partial class Temp : Form
    {
        Queue<int> l = new Queue<int>();
        int row;
        int col;
        public Temp(Queue<int> ll, int row, int col)
        {
            InitializeComponent();
            this.l = ll;
            this.row = row;
            this.col = col;
            foreach(int i in ll)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void restore()
        {
            tab.Columns.Clear();
            tab.RowHeadersVisible = false;
            tab.Columns.Add("", "");
            for (int i = 0; i < col - 2; i++)
            {
                tab.Columns.Add("d" + (i + 1), "Destinatario " + (i + 1));
            }
            for (int j = 0; j < row - 1; j++)
            {
                tab.Rows.Add("Produttore " + (j + 1), "");
            }
            tab.Columns.Add("tr", "Totale");
            tab.Rows.Add("Totale", "");
            tab.Columns[0].ReadOnly = true;
            foreach (DataGridViewColumn t in tab.Columns)
            {
                t.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            tab[1, 0].Value = 0;
            for (int i = 1; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    tab[i, j].Value = l.Dequeue();
                }
            }
        }

        private void Temp_Load(object sender, EventArgs e)
        {
            restore();
        }
    }
}
