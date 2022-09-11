using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Dominio
{
    class Pilas : ICollection
    {
        Object[] Array;
       int  ultimo=0;

        public Pilas()
        {
            Array=new Object[10];
        }
       

            
        

        public bool añadir(Object elemento)
        {
            bool agregado = false;
            ultimo = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == null)
                {
                    Array[i] = elemento;
                    agregado = true;
                    break;
                }

            }


            return agregado; ;
        }

        public bool estaVacia()
        {
            bool vacio = false;
            for (int i = 0; i < Array.Length; i++)
            {

                if (Array[i] == null)
                {
                    vacio = true;
                    break;
                }

            }


            return vacio;

        }

        public string extraer()
        {
            string resultado = "";


            if (ultimo== Array.Length)
                {
                    resultado = Array[ultimo].ToString();
                    Array[ultimo] = null;
                    ultimo++;
                    
                }


            

            return resultado; ;
        }

        

       

        public string primero()
        {
            string resultado = "";

            for (int i = 0; i < Array.Length; i++)
            {

                if (Array[i] != null)
                {
                    resultado = Array[i].ToString();
                    break;
                }

            }

            return resultado; ;
        }
    }
}
