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
    public partial class Costo : Form
    {
        Queue<int> l = new Queue<int>();
        int row;
        int col;
        public Costo(Queue<int> ll, int row, int col)
        {
            InitializeComponent();
            this.l = ll;
            this.row = row;
            this.col = col;
            restore();
            //NordOvest();
        }
        public int aggiornamento(int n1, int n2, int tot, bool scelta, string text)
        {
            label1.Text = text;
            if (scelta)
            {
                int r = n1 * n2;
                string c = n1.ToString() + " x " + n2.ToString() + " = " + r.ToString();
                calcolo.Text += c + "\n";
                tot += r;
            }
            else
            {
                totale.Text = tot.ToString();
                return 0;
            }
            return tot;
        }

        public void restore()
        {
            tab.Columns.Clear();
            tab.Rows.Clear();
            tab.RowHeadersVisible = false;
            tab.Columns.Add("", "");
            for (int i = 1; i < col - 1; i++)
            {
                tab.Columns.Add("D" + i, "D" + i);
            }
            tab.Columns.Add("tr", "Totale");
            MessageBox.Show(row.ToString());
            /*tab.Rows.RemoveAt(0);
            for (int j = 1; j < row; j++)
            {
                tab.Rows.Add("U" + (j+1), "");
            }
            
            tab.Rows.Add("Totale", "");*/
            tab.Columns[0].ReadOnly = true;
            foreach (DataGridViewColumn t in tab.Columns)
            {
                t.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            /*for (int i = 1; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    tab[i, j].Value = l.Dequeue();
                }
            }*/
        }

        public void NordOvest()
        {
            int t = 0;
            MessageBox.Show(tab.ColumnCount.ToString());
            MessageBox.Show("row: " +tab.RowCount.ToString());
            int tot = int.Parse(tab[tab.ColumnCount - 1, tab.RowCount - 1].Value.ToString());
                    int col;
                    int row;
                    int n;
                    while (tab.Rows.Count > 1 && tab.RowCount > 1)
                    {
                        col = int.Parse(tab[tab.ColumnCount - 1, 0].Value.ToString());
                        row = int.Parse(tab[1, tab.RowCount - 1].Value.ToString());
                        n = int.Parse(tab[1, 0].Value.ToString());
                        if (col > row)
                        {
                            col -= row;
                            tot -= row;
                            tab[tab.ColumnCount - 1, 0].Value = col;
                            tab[tab.ColumnCount - 1, tab.RowCount - 1].Value = tot;
                            t = aggiornamento(n, row, t, true, "NordOvest");
                            tab.Columns.Remove(tab.Columns[1]);

                        }
                        else
                        {
                            row -= col;
                            tot -= col;
                            tab[1, tab.RowCount - 1].Value = row;
                            tab[tab.ColumnCount - 1, tab.RowCount - 1].Value = tot;
                            aggiornamento(n, col, t, true, "NordOvest");
                            tab.Rows.Remove(tab.Rows[0]);
                        }
                        var pause = Task.Delay(1000);
                        pause.Wait();
                    }
                    aggiornamento(1, 1, t, false, "NordOvest");
        
        }
    }
}
