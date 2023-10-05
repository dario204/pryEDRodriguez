using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryEDRodriguez
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adapatador = new OleDbDataAdapter();

        private string CadenaConexion= "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb";
        private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";
        //private string varSQL

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType=CommandType.Text;
                comando.CommandText = "SELECT * FROM LIBRO";

                DataSet DS = new DataSet();
                adapatador = new OleDbDataAdapter();
                adapatador.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource= DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
                
            }
        }

        public void Listar(DataGridView grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM LIBRO";

                DataSet DS = new DataSet();
                adapatador = new OleDbDataAdapter();
                adapatador.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();

            }
        }
    }
}
