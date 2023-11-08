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
    public partial class frmRepasoBD : Form
    {
        public frmRepasoBD()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        clsBaseDatos ObjBD = new clsBaseDatos();
        private void btnListar_Click(object sender, EventArgs e)
        {
            String VarSQL = "SELECT * FROM LIBRO";
            switch (cboConsulta.SelectedIndex)
            {
                case 0:
                    lblRepaso.Text = cboConsulta.Text + ": " + "Paises que no tienen libros";
                    VarSQL = "SELECT * FROM PAIS WHERE IDPAIS NOT IN (SELECT IDPAIS FROM LIBRO)";
                    break;
                case 1:
                    lblRepaso.Text = cboConsulta.Text + ": " + "Libros con ID menores a 20 y con un precio menor a 600";
                    VarSQL = "SELECT * FROM LIBRO WHERE IDLIBRO < 20 " +
                        "INTERSECT " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 2:
                    VarSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 4 " +
                        "UNION " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 3:
                    VarSQL = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
                    break;
                case 4:
                    VarSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;
                case 5:
                    VarSQL = "SELECT IDLIBRO,TITULO FROM LIBRO ORDER BY 1 DESC";
                    break;

                    ObjBD.Listar(dgvOperaciones, VarSQL);

            }

        }

        private void frmRepasoBD_Load(object sender, EventArgs e)
        {
            cboConsulta.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
