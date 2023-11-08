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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        clsPila FilaDePersonas = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvPila);
            FilaDePersonas.Recorrer(lstPila);
            FilaDePersonas.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCod.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNom.Text = FilaDePersonas.Primero.Nombre;
                lblTra.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvPila);
                FilaDePersonas.Recorrer(lstPila);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTra.Text = "";
            }
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
        

        private void txtTramite_TextChanged_1(object sender, EventArgs e)
        {

            if (txtCodigo.Text != null && txtNombre.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
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
