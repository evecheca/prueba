using System;
namespace WindowsFormsApp1.Dominio

{


public class DetalleCarrera
{
        //public int DetalleNro { get; set; }
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Materia{ get; set; }
        



       
   
    public DetalleCarrera(int anioCursado,int cuatrimestre,Asignatura materia)
    {
            //DetalleNro = 1;

            AnioCursado = anioCursado;
           Cuatrimestre = cuatrimestre;
            Materia = materia;

   
        
        }

    

    public override string ToString()
    {
        return "Asignatura a cursar:" + Materia + " , " + " cuatrimestre " + Cuatrimestre + "año de cursado:" + AnioCursado;
    }


}

}