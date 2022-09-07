using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Dominio;

namespace WindowsFormsApp1.Datos
{
    class ConexionBD
    {
        SqlConnection cnn;

        public ConexionBD()
        {
            cnn = new SqlConnection(Properties.Resources.Conexionstring);

        }




        public DataTable ConsultarTablas(string nombresp)
        {
            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = nombresp;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
            


        }



        public bool ConfirmarCarrera(PLanCarrera oPLanCarrera)
        {
            bool resultado = true;
            SqlTransaction t = null;
           try
            { 
                cnn.Open();
            t = cnn.BeginTransaction();
            SqlCommand cmdMaestro = new SqlCommand();
            cmdMaestro.Connection = cnn;
            cmdMaestro.CommandType = CommandType.StoredProcedure;
            cmdMaestro.CommandText = "sp_insertar_carrera";
            cmdMaestro.Transaction = t;
            cmdMaestro.Parameters.AddWithValue("@nombre", oPLanCarrera.Nombre_Carrera);
            cmdMaestro.Parameters.AddWithValue("@titulo", oPLanCarrera.Titulo);
            SqlParameter param = new SqlParameter("@new_id_carrera", DbType.Int32);
            param.Direction = ParameterDirection.Output;
            cmdMaestro.Parameters.Add(param);
            cmdMaestro.ExecuteNonQuery();

            int NroCarrera = (int)param.Value;

            SqlCommand cmdDetalle = new SqlCommand();

            foreach(DetalleCarrera item in  oPLanCarrera.Detalles)
            {

                cmdDetalle.Parameters.Clear();
                cmdDetalle.Connection = cnn;
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.CommandText = "sp_insertar_detalleCarreras";
                cmdDetalle.Transaction = t;

                cmdDetalle.Parameters.AddWithValue("@anioCursado", item.AnioCursado);
                cmdDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                cmdDetalle.Parameters.AddWithValue("@id_carrera", NroCarrera);
                cmdDetalle.Parameters.AddWithValue("@id_asignatura", item.Materia.Id_Asignatura);
                cmdDetalle.ExecuteNonQuery();

            }


                t.Commit();
            }
                catch(Exception) {

                t.Rollback();
                    resultado = false;


                }
            finally
            {
                if(cnn !=null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }


            return resultado;







        }




        public bool EliminarCarrera(int id_carrera)
        {
            cnn.Open();
           SqlCommand cmd = new SqlCommand("sp_registrar_baja_carrera", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_carrera", id_carrera);
            int filas = cmd.ExecuteNonQuery();
            cnn.Close();

            return filas == 1;

        }



    }
}
