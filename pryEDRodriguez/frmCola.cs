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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        clsCola FilaDePersonas= new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo= new clsNodo();
            objNodo.Codigo= Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre=txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            
            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvGrilla);
            FilaDePersonas.Recorrer(lstCola);
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
                FilaDePersonas.Recorrer(dgvGrilla);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTra.Text = "";
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtNombre.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
        }
    }
}
