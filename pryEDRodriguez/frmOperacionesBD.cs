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
    public partial class frmOperacionesBD : Form
    {
        public frmOperacionesBD()
        {
            InitializeComponent();
        }

        private void frmBaseDatos_Load(object sender, EventArgs e)
        {

        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQl = "SELECT TITULO" +
                "FROM LIBRO" +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 2" +
                " AND IDLIBRO IN (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3)" +
                " ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
           String varSQl = "SELECT IDLIBRO,TITULO FROM LIBRO ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
           String varSQl = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
           String varSQl = "SELECT * FROM Libro WHERE Cantidad > 1";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
           String varSQl = "SELECT * FROM Libro WHERE Cantidad >= 1 AND Precio > 130";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {
           String varSQl = "SELECT * FROM (SELECT * FROM Libro WHERE IDAUTOR = 5) AS X WHERE IDIDIOMA = 3";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            
          String  varSQl = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " Union " +
                "SELECT * FROM Libro WHERE idIdioma = 7";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQl = "SELECT * FROM LIBRO WHERE IDIDIOMA " +
                "NOT IN (SELECT DISTINCT IDIDIOMA FROM LIBRO WHERE IDIDIOMA < 5)";
            objBaseDatos.Listar(dgvBaseDatos, varSQl);
        }
    }
}
