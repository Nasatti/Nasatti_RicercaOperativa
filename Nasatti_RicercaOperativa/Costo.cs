using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nasatti_Ricerca_operativa
{
    public partial class Costo : Form
    {
        public Costo()
        {
            InitializeComponent();
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

        private void Costo_Load(object sender, EventArgs e)
        {

        }
    }
}
