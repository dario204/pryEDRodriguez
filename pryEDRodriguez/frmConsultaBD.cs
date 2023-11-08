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
    public partial class frmConsultaBD : Form
    {
        public frmConsultaBD()
        {
            InitializeComponent();
        }

        private void ConsultaBD_Load(object sender, EventArgs e)
        {

        }

        private void btnaListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvConsulta, txtConsulta.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
