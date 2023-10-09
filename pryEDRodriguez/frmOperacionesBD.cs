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
    }
}
