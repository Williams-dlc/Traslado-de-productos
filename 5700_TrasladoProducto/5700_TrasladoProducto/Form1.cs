using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5700_TrasladoProducto
{
    public partial class Traslado_Producto : Form
    {
        public Traslado_Producto()
        {
            InitializeComponent();
        }

        private void Gpb_Conductor_Enter(object sender, EventArgs e)
        {

        }

        private void Traslado_Producto_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "D:/Octavo semestre/Analisis de sistemas 2/traslado producto/Primera fase/Ayuda traslado producto/ayuda_traslado.chm", "ayuda.html");
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "D:/Octavo semestre/Analisis de sistemas 2/traslado producto/Primera fase/Ayuda traslado producto/ayuda_traslado.chm", "ayuda.html");
        }
    }
}
