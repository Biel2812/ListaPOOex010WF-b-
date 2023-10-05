using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ10
{
    public partial class frmTerreno : Form
    {
        public frmTerreno()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            terreno t;
            t = new terreno();
            t.setVbase(int.Parse(txtbase.Text));
            t.setValtura(int.Parse(txtaltura.Text));
            t.calcularValores();

            lblResultado.Text = t.calcularValores();
        }
    }
}
