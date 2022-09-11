using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Dominio
{
    class Colas: ICollection
    {
      List<Object>ListaObjectos;
        int contador;


        public Colas()
        {
            ListaObjectos = new List<Object>();
        }
       
        public  string extraer()
        {
            string resultado = "";


            for (int i = 0; i < ListaObjectos.Count; i++)
            {
                
                if ( ListaObjectos[i]!=null)
                {
                    resultado = ListaObjectos[i].ToString();
                    ListaObjectos[i] = null;
                    break;
                }


            }

            return resultado;
        }
       public  string primero()
        {
            string resultado = "";
            
            for (int i = 0; i < ListaObjectos.Count; i++)
            {

                if (ListaObjectos[i] != null)
                {
                    resultado = ListaObjectos[i].ToString();
                    break;
                }

            }

            return resultado;

        }
      
        public bool estaVacia()
        {
            bool vacio = false;
            for (int i = 0; i < ListaObjectos.Count; i++)
            {

                if (ListaObjectos[i] == null)
                {
                    vacio = true;
                    break;
                }

            }


            return vacio;
            
        }

        public bool añadir(Object elemento)
        {
        int contador = 0;
        bool agregado = false;
        for (int i = 0; i < ListaObjectos.Count; i++)
        {

            if (ListaObjectos[i] == null)
            {
                ListaObjectos[i] = elemento;
                agregado = true;
                contador++;
                break;
            }
        }

        return agregado;


    }




















    }

}
