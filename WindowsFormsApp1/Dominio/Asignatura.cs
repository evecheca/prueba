using System;
namespace WindowsFormsApp1.Dominio
{


public class Asignatura
{

    public int Id_Asignatura { get; set; }
    public string Nombre { get; set; }  
    
    //public Asignatura(string nombre,int id_Asignatura)
    //{
    //        Id_Asignatura = id_Asignatura;
    //    Nombre = nombre;

    //}

    //public Asignatura( )
    //{
    //    Id_Asignatura = 1;
    //    Nombre = "Programacion_II";

    //}

    public override string ToString()
    {
        return Nombre;
    }

    public static explicit operator Asignatura(string v)
    {
        throw new NotImplementedException();
    }
}
}