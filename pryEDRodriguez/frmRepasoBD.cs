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
            String VarSQl = "SELECT * FROM LIBRO";
            switch (cboConsulta.SelectedIndex)
            {
                case 0:
                    lblRepaso.Text = cboConsulta.Text + "; " + "Paises que no tienen libros";
                    VarSQl = "SELECT * FROM PAIS WHERE" +
                        "IDPAIS NOT IN " +
                        "(SELECT IDPAIS FROM LIBRO)";
                    break;
                case 1:
                    lblRepaso.Text = cboConsulta.Text + "; " + "Tablas que aparecen en ambas relaciones ";
                    VarSQl = "SELECT NOMBRE FROM AUTOR " +
                              "INTERSECT" +
                              "SELECT NOMBRE FROM PAISES";
                    break;
                case 3:
                    lblRepaso.Text = cboConsulta.Text + "; " + "";
                    VarSQl= "SELECT * FROM Libro, Idioma " +
                    "WHERE Libro.IdIdioma = Idioma.IdIdioma";

                    break;
                 case 4:
                    lblRepaso.Text = cboConsulta.Text + "; " + "";
                    VarSQl = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC"; ;
                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;


            }

        }

        private void frmRepasoBD_Load(object sender, EventArgs e)
        {
            cboConsulta.SelectedIndex = 0;
        }
    }
}
