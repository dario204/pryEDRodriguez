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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble Doble = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Doble.Primero != null)
            {
                Int32 x = Convert.ToInt32(cboEliminar.Text);
                Doble.Eliminar(x);
                Doble.Recorrer(dgvLista);
                Doble.Recorrer(lstLista);
                Doble.Recorrer(cboEliminar);
                Doble.Recorrer();
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
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
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

            Doble.Agregar(objNodo);
            Doble.Recorrer(dgvLista);
            Doble.Recorrer(lstLista);
            Doble.Recorrer();
            Doble.Recorrer(cboEliminar);
            Doble.RecorrerDes(dgvLista);
            Doble.RecorrerDes(lstLista);
            Doble.RecorrerDes(cboEliminar);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAscendente.Checked)
            {
                Doble.Recorrer(dgvLista);
                Doble.Recorrer(lstLista);
                Doble.Recorrer();
                Doble.Recorrer(cboEliminar);
            }
           
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDescendente.Checked)
            {
                Doble.RecorrerDes(dgvLista);
                Doble.RecorrerDes(lstLista);
                Doble.RecorrerDes(cboEliminar);
            }
        }
    }
}
