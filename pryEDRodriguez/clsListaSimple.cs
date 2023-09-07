using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryEDRodriguez
{
    internal class clsListaSimple
    {
        //Campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {

            if (pri == null)
            {
                pri = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < pri.Codigo)
                {
                    Nuevo.Siguiente = pri;
                    pri = Nuevo;
                }
                else
                {
                    clsNodo aux = pri;
                    clsNodo ant = pri;
                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null)
                        {
                            break;
                        }
                    }
                    ant.Siguiente = Nuevo;
                    Nuevo.Siguiente = aux;
                }

            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = pri;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = pri;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = pri;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo aux = pri;
            StreamWriter AD = new StreamWriter("ListaSimple.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de Personas ordenado por codigo\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();

        }
        public void Eliminar(Int32 Codigo)
        {
            if (pri.Codigo==Codigo)
            {
                pri = pri.Siguiente;
            }
            else
            {
                clsNodo aux = Primero;
                clsNodo ant = Primero;
                while (aux.Codigo!= Codigo)
                {
                    ant = aux;
                    aux=aux.Siguiente;
                    if (aux==null)
                    {
                        break;
                    }
                }
                ant.Siguiente = aux.Siguiente;
            }
        }
    }
}
