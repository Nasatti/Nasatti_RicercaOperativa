using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nasatti_RicercaOperativa
{
    public partial class Costo : Form
    {
        Queue<int> l = new Queue<int>();
        int row;
        int col;
        int scelta;
        Thread t;
        public Costo(Queue<int> ll, int row, int col, int s)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.l = ll;
            this.row = row;
            this.col = col;
            scelta = s;
            tab.AllowUserToAddRows = false;
            tab.AllowUserToDeleteRows = false;
            tab.AllowUserToResizeColumns = false;
            tab.AllowUserToResizeRows = false;
            this.DoubleBuffered = true;
        }
        public int aggiornamento(int n1, int n2, int tot, bool scelta)
        {
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
            for (int j = 1; j < row; j++)
            {
                tab.Rows.Add("U" + j, "");
            }
            tab.Rows.Add("Totale", "");
            tab.Columns[0].ReadOnly = true;
            foreach (DataGridViewColumn t in tab.Columns)
            {
                t.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 1; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    tab[i, j].Value = l.Dequeue();
                }
            }
        }
        public void NordOvest()
        {
            int t = 0;
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
                    t = aggiornamento(n, row, t, true);
                    tab.Columns.Remove(tab.Columns[1]);

                }
                else
                {
                    row -= col;
                    tot -= col;
                    tab[1, tab.RowCount - 1].Value = row;
                    tab[tab.ColumnCount - 1, tab.RowCount - 1].Value = tot;
                    t = aggiornamento(n, col, t, true);
                    tab.Rows.Remove(tab.Rows[0]);
                }
                Thread.Sleep(1000);
            }
            aggiornamento(1, 1, t, false);
        }
        public void MinCosti()
        {
            int col = 0;
            int row = 0;
            int n_c = 1;
            int n_r = 1;
            int tot = int.Parse(tab[tab.ColumnCount - 1, tab.RowCount - 1].Value.ToString());
            int t = 0;
            while (tab.Rows.Count > 1 && tab.RowCount > 1)
            {
                int min = 100000;
                for (int i = 1; i < tab.ColumnCount - 1; i++)
                {
                    for (int j = 0; j < tab.RowCount - 1; j++)
                    {
                        if (int.Parse(tab[i, j].Value.ToString()) < min)
                        {
                            n_c = i;
                            n_r = j;
                            min = int.Parse(tab[i, j].Value.ToString());
                            row = int.Parse(tab[i, tab.RowCount - 1].Value.ToString());
                            col = int.Parse(tab[tab.ColumnCount - 1, j].Value.ToString());
                        }
                        else if (int.Parse(tab[i, j].Value.ToString()) == min)
                        {
                            if (int.Parse(tab[i, tab.RowCount - 1].Value.ToString()) > row)
                            {
                                n_c = i;
                                n_r = j;
                                min = int.Parse(tab[i, j].Value.ToString());
                                row = int.Parse(tab[i, tab.RowCount - 1].Value.ToString());
                                col = int.Parse(tab[tab.ColumnCount - 1, j].Value.ToString());
                            }
                        }
                    }
                }
                if (col > row)
                {
                    col -= row;
                    tot -= row;
                    tab[tab.ColumnCount - 1, n_r].Value = col;
                    tab[tab.ColumnCount - 1, tab.RowCount - 1].Value = tot;
                    t = aggiornamento(min, row, t, true);
                    tab.Columns.Remove(tab.Columns[n_c]);
                }
                else
                {
                    row -= col;
                    tot -= col;
                    tab[n_c, tab.RowCount - 1].Value = row;
                    tab[tab.ColumnCount - 1, tab.RowCount - 1].Value = tot;

                    t = aggiornamento(min, col, t, true);

                    tab.Rows.Remove(tab.Rows[n_r]);
                }
                Thread.Sleep(1000);
            }
            aggiornamento(1, 1, t, false);
        }
        private void Costo_Load(object sender, EventArgs e)
        {
            restore();
            switch (scelta)
            {
                case 1:
                    label1.Text = "Nord Ovest";
                    break;
                case 2:
                    label1.Text = "Minimi Costi";
                    break;
            }
        }

        private void risolvi_btn_Click(object sender, EventArgs e)
        {
            Thread t;
            risolvi_btn.Enabled = false;
            switch (scelta)
            {
                case 1:
                    t = new Thread(new ThreadStart(NordOvest));
                    t.Start();
                    break;
                case 2:
                    t = new Thread(new ThreadStart(MinCosti));
                    t.Start();
                    break;
            }
            
        }
    }
}
