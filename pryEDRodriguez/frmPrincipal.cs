using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDRodriguez
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador Datos = new frmDatosDesarrollador();
            Datos.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola Cola = new frmCola();
            Cola.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila Pila = new frmPila();
            Pila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple Lista = new frmListaSimple();
            Lista.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble Doble = new frmListaDoble();
            Doble.ShowDialog();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario Binario = new frmArbolBinario();
            Binario.ShowDialog();
        }
    }
}
