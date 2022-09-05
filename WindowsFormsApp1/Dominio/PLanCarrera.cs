using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Dominio

{ 
public class PLanCarrera
{
	public int Id_Carrera { get; set; }
	public string Nombre_Carrera { get; set; }
	public string Titulo { get; set; }
    public List<DetalleCarrera> Detalles{ get; set; }


    //    public PLanCarrera(int id_Carrera,string nombre_Carrera,string titulo)
    //{
    //        Id_Carrera = id_Carrera;
    //        Nombre_Carrera = nombre_Carrera;
    //        Titulo = titulo;
    //        Detalles = new List<DetalleCarrera>();

    //}

    public PLanCarrera()
    {
            
        Detalles = new List<DetalleCarrera>();

        }




        public void AgregarDetalle(DetalleCarrera detalle)
        {

            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int Indice)
        {
            Detalles.RemoveAt(Indice);
        }


        public override string ToString()
    {
        return " Carrera:" + Nombre_Carrera + "Titulo que otorga:" + Titulo;
    }

        //public static explicit operator PLanCarrera(string v)
        //{
        //	throw new NotImplementedException();
        //}

        //internal bool Confirmar()
        //{
        //    SqlConnection cnn = new SqlConnection();
        //    cnn.ConnectionString = @"Data Source = DESKTOP-VFUQVSN\SQLEXPRESS; Initial Catalog = Carrera; Integrated Security = True";
        //    cnn.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "SP_iNSERTAR_Carrera";
        //    cmd.Connection = cnn;
        //    cmd.Parameters.AddWithValue("@nombre_carrera", Nombre_Carrera);
        //    cmd.Parameters.AddWithValue("@titulo", Titulo);
        //    SqlParameter param = new SqlParameter();
        //    param.ParameterName = "id_carrera";
        //    param.SqlDbType = SqlDbType.Int;
        //    param.Direction = ParameterDirection.Output;
        //    cmd.Parameters.Add(param);

        //    cmd.ExecuteNonQuery();
        //    this.Id_Carrera = (int)param.Value;


        //    int DetalleNro = 1;
        //    foreach (DetalleCarrera item in Detalles)
        //    {

        //        SqlCommand comando = new SqlCommand();
        //        comando.Connection = cnn;
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.CommandText = "SP_iNSERTAR_DetalleCarrera";
        //        comando.Parameters.AddWithValue("@id_Carrera", this.Id_Carrera);
        //        //comando.Parameters.AddWithValue("@Id_DetalleCarrera", DetalleNro);

        //        comando.Parameters.AddWithValue("@materia",item.Materia.Nombre );
        //        comando.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
        //        comando.Parameters.AddWithValue("@aniocursado", item.AnioCursado);
        //        comando.Parameters.AddWithValue("@id_Asignatura", item.Materia.Id_Asignatura);
        //        comando.ExecuteNonQuery();
        //        DetalleNro++;

        //    }

        //    cnn.Close();

        //    return true;
        //}


      

    }

}

