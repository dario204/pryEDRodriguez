using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            Arbol.Agregar(Persona);
            Arbol.RecorrerIn(dgvLista);
            Arbol.Recorrer(tvArchivos);
            Arbol.Recorrer(cboEliminar);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnAgregar.Enabled = false;
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
            if (rbIn.Checked)
            {
                Arbol.ExportarIn(dgvLista);
            }
            else
            {
                if (rbPre.Checked)
                {
                    Arbol.ExportarPre(dgvLista);
                }
                else
                {
                    if (rbPost.Checked)
                    {
                        Arbol.ExportarPost(dgvLista);
                    }
                }
            }
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Arbol.Eliminar(Convert.ToInt32(cboEliminar.Text));
            Arbol.RecorrerIn(dgvLista);
            Arbol.Recorrer(tvArchivos);
            Arbol.Recorrer(cboEliminar);
            btnEliminar.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboEliminar.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtNombre.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
        }
    } 
}

