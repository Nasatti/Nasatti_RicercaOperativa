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
    public partial class RicercaOperativa : Form
    {
        //non poter scrivere negli indici delle tabelle
        //inserisci sia manualmente che casuale(non necessario)
        //controllare se entrambi i totali coincidono
        //risultati su altra form

        Queue<int>temp = new Queue<int>();
        bool crea = false;
        public RicercaOperativa()
        {

            InitializeComponent();
            tabella.AllowUserToAddRows = false;
            tabella.AllowUserToDeleteRows = false;
            tabella.AllowUserToResizeColumns = false;
            tabella.AllowUserToResizeRows = false;
            this.DoubleBuffered = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (crea)
            {
                DialogResult d = MessageBox.Show("cancellare i dati per creare una nuova tabella?", "avvertimento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(d == DialogResult.Yes)
                {
                    generaTabella();
                    random_btn.Enabled = true;
                    crea = false;
                }
            }
            else
            {
                generaTabella();
                tabella.Visible = true;
                NordOvest_btn.Visible = true;
                minCosti_btn.Visible = true;
                random_btn.Visible = true;
                random_btn.Enabled = true;
            }
            /*tabella[1, 0].Value = 10;
            tabella[1, 1].Value = 15;
            tabella[1, 2].Value = 20;
            tabella[1, 3].Value = 100;

            tabella[2, 0].Value = 12;
            tabella[2, 1].Value = 30;
            tabella[2, 2].Value = 35;
            tabella[2, 3].Value = 120;

            tabella[3, 0].Value = 80;
            tabella[3, 1].Value = 40;
            tabella[3, 2].Value = 30;
            tabella[3, 3].Value = 90;

            tabella[4, 0].Value = 30;
            tabella[4, 1].Value = 45;
            tabella[4, 2].Value = 20;
            tabella[4, 3].Value = 50;

            tabella[5, 0].Value = 50;
            tabella[5, 1].Value = 60;
            tabella[5, 2].Value = 50;
            tabella[5, 3].Value = 150;

            tabella[6, 0].Value = 200;
            tabella[6, 1].Value = 150;
            tabella[6, 2].Value = 160;
            tabella[6, 3].Value = 510;*/
        }
        private void generaTabella()
        {
                tabella.Columns.Clear();
                tabella.RowHeadersVisible = false;
                tabella.Columns.Add("", "");
                for (int i = 1; i < int.Parse(destinatari.Text) + 1; i++)
                {
                    tabella.Columns.Add("D" + i, "D" + i);
                }
                tabella.Columns.Add("tot colonne", "tot colonne");
                for (int i = 1; i < int.Parse(produttori.Text) + 1; i++)
                {
                    tabella.Rows.Add("U" + i, "");
                }
                tabella.Rows.Add("tot righe", "");
                tabella.Columns[0].ReadOnly = true;

                foreach (DataGridViewColumn t in tabella.Columns)
                {
                    t.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
                }
            
        }

        private void NordOvest_btn_Click(object sender, EventArgs e)
        {
            int t = 0;

            if (controllo_celle())
            {
                if (controllo_tot())
                {
                    save();
                    random_btn.Enabled = false;
                    Costo c = new Costo(temp, tabella.RowCount, tabella.ColumnCount, 1);
                    c.Show();
                }
                else
                    MessageBox.Show("Le somme non coincidono");
            }
            else
                MessageBox.Show("mancano dei numeri");
        }

        private bool controllo_tot()
        {
            int y = tabella.RowCount - 1;
            int x = tabella.ColumnCount - 1;
            int somma_row = 0;
            for (int i = 0; i < y; i++)
            {
                somma_row += int.Parse(tabella[x, i].Value.ToString());
            }
            int somma_col = 0;
            for (int i = 1; i < x; i++)
            {
                somma_col += int.Parse(tabella[i, y].Value.ToString());
            }
            if (somma_col == somma_row && somma_row == int.Parse(tabella[x, y].Value.ToString()))
                return true;
            else
                return false;
        }
        private bool controllo_celle()
        {
            for (int i = 1; i < tabella.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tabella.RowCount - 1; j++)
                {
                    if (tabella[i, j].Value.ToString() == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void tabella_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(tabella_KeyPress);
            TextBox tb = e.Control as TextBox;
            tb.ShortcutsEnabled = false;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(tabella_KeyPress);
            }
        }

        private void tabella_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void minCosti_btn_Click(object sender, EventArgs e)
        {
            if (controllo_celle())
            {
                if (controllo_tot())
                { 
                    save();
                    random_btn.Enabled = false;
                    Costo c = new Costo(temp, tabella.RowCount, tabella.ColumnCount, 2);
                    c.Show();
                }
                else
                    MessageBox.Show("Le somme non coincidono");
            }
            else
                MessageBox.Show("mancano dei numeri");
        }
        private void random_btn_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            crea = true;
            //tabella
            for (int i = 1; i < tabella.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tabella.RowCount - 1; j++)
                {
                    tabella[i, j].Value = r.Next(1, 100);
                }
            }

            //colonne
            int tot = 0;
            int n;
            for (int i = 1; i < tabella.ColumnCount - 1; i++)
            {
                n = r.Next(1, 100);
                tabella[i, tabella.RowCount - 1].Value = n;
                tot += n;
            }
            tabella[tabella.ColumnCount - 1, tabella.RowCount - 1].Value = tot;

            int p = tot / tabella.RowCount;
            //righe
            for (int j = 0; j < tabella.RowCount - 2; j++)
            {
                n = r.Next(p - 20, p + 20);
                tabella[tabella.ColumnCount - 1, j].Value = n;
                tot -= n;
            }
            int value = tot;
            tabella[tabella.ColumnCount - 1, tabella.RowCount - 2].Value = value;
        }
        private void save()
        {
            for (int i = 1; i < tabella.ColumnCount; i++)
            {
                for (int j = 0; j < tabella.RowCount; j++)
                {
                    temp.Enqueue(int.Parse(tabella[i, j].Value.ToString()));
                }
            }
        }
    }
}