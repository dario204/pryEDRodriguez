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
        clsListaSimple ListaPersonas = new clsListaSimple();

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ListaPersonas.Primero != null)
            {
                Int32 Codigo= Convert.ToInt32(cboEliminar.Text);
                ListaPersonas.Eliminar(Codigo);
                ListaPersonas.Recorrer(dgvLista);
                ListaPersonas.Recorrer(lstLista);
                ListaPersonas.Recorrer();
            }
            else
            {
                MessageBox.Show("Lista vacia");
            }
            btnEliminar.Enabled= false;
        }

        private void cboEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEliminar.Text !=null)
            {

            }
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

            ListaPersonas.Agregar(objNodo);
            ListaPersonas.Recorrer(dgvLista);
            ListaPersonas.Recorrer(lstLista);
            ListaPersonas.Recorrer();
            ListaPersonas.Recorrer(cboEliminar);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
