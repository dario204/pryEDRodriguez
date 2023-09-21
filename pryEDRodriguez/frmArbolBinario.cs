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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario Arbol = new clsArbolBinario();

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Arbol.Agregar(ObjNodo);
            Arbol.RecorrerIn(dgvLista);
        }

        private void rbIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIn.Checked)
            {
                Arbol.RecorrerIn(dgvLista);
               
            }
        }

        private void rbPre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPre.Checked)
            {
                Arbol.RecorrerPre(dgvLista);
            }
        }

        private void rbPost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPost.Checked)
            {
                Arbol.RecorrerPost(dgvLista);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
        }
    }
}
