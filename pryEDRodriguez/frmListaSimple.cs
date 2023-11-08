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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple FilaDePersonas = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboEliminar.Text);
                FilaDePersonas.Eliminar(x);
                FilaDePersonas.Recorrer(dgvLista);
                FilaDePersonas.Recorrer(lstLista);
                FilaDePersonas.Recorrer(cboEliminar);
                FilaDePersonas.Recorrer();
            }
            else
            {
                MessageBox.Show("La lista está vacía");
            }
            btnEliminar.Enabled = false;


        }

        private void cboEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
        public void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text!="" && txtTramite.Text!="")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvLista);
            FilaDePersonas.Recorrer(lstLista);
            FilaDePersonas.Recorrer();
            FilaDePersonas.Recorrer(cboEliminar);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
