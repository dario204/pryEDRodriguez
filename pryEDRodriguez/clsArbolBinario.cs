using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDRodriguez
{
    internal class clsArbolBinario
    {
        private clsNodo Inicio;

        public clsNodo Raiz
        {
            get { return Inicio; }
            set { Inicio = value; }
        }

        public void Agregar(clsNodo nvo)
        {
            nvo.Izquierda = null;
            nvo.Derecha = null;
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    NodoPadre = aux;
                    if (nvo.Codigo < aux.Codigo)
                    {
                        aux = aux.Izquierda;
                    }
                    else
                    {
                        aux = aux.Derecha;
                    }
                }
                if (nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = nvo;
                }
                else
                {
                    NodoPadre.Derecha = nvo;
                }
            }
        }
        private void InOrderAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) InOrderAsc(Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrderAsc(Dgv, R.Derecha);
        }
        public void RecorrerIn(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);
        }

        private void PreOrderAsc(DataGridView Dgv, clsNodo R)
        {
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null) PreOrderAsc(Dgv, R.Izquierda);
            if (R.Derecha != null) PreOrderAsc(Dgv, R.Derecha);
        }

        private void PostOrderAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierda != null) PostOrderAsc(Dgv, R.Izquierda);
            if (R.Derecha != null) PostOrderAsc(Dgv, R.Derecha);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrderAsc(Grilla, Raiz);
        }
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrderAsc(Grilla, Raiz);
        }

        public void Exportar()
        {
            clsNodo aux = Raiz;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de personas\n");
            AD.WriteLine("Codigo;Nombre;Tramite\n");
            while (aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.WriteLine(";");
                AD.WriteLine(aux.Nombre);
                AD.WriteLine(";");
                AD.Write(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();
        }
    }
}
