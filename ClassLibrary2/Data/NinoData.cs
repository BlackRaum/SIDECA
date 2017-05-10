using ClassLibrary2.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Data
{

    public class NinoData
    {
        private string stringConexion;

        public NinoData(string stringConexion)
        {
            this.stringConexion = stringConexion;
        }

        public void InsertarNino(Nino nino)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            //para insertar nino
            string slqProcedureInsertarNino = "sp_insertar_nino";
            SqlCommand cmdInsertarNino = new SqlCommand(slqProcedureInsertarNino, conexion);
            cmdInsertarNino.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarNino.Parameters.Add(new SqlParameter("@cedula_nino", nino.CedulaNino));
            cmdInsertarNino.Parameters.Add(new SqlParameter("@nombre_nino", nino.NombreNino));
            cmdInsertarNino.Parameters.Add(new SqlParameter("@sexo", nino.Sexo));
            cmdInsertarNino.Parameters.Add(new SqlParameter("@edad", nino.Edad));
            cmdInsertarNino.Parameters.Add(new SqlParameter("@fecha_nacimiento", nino.FechaNacimiento));
            cmdInsertarNino.Parameters.Add(new SqlParameter("@cedula_encargado", nino.CedulaEncargado));
            cmdInsertarNino.Parameters.Add(new SqlParameter("@nombre_encargado", nino.NombreEncargado));

            conexion.Open();

            try
            {
                cmdInsertarNino.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ActualizarNino(Nino nino)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);

            //Para actualizar Nino
            string slqProcedureActualizarNino = "sp_actualizar_nino";
            SqlCommand cmdActualizarNino = new SqlCommand(slqProcedureActualizarNino, conexion);
            cmdActualizarNino.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdActualizarNino.Parameters.Add(new SqlParameter("@cedula_nino", nino.CedulaNino));
            cmdActualizarNino.Parameters.Add(new SqlParameter("@nombre_nino", nino.NombreNino));
            cmdActualizarNino.Parameters.Add(new SqlParameter("@sexo", nino.Sexo));
            cmdActualizarNino.Parameters.Add(new SqlParameter("@edad", nino.Edad));
            cmdActualizarNino.Parameters.Add(new SqlParameter("@fecha_nacimiento", nino.FechaNacimiento));
            cmdActualizarNino.Parameters.Add(new SqlParameter("@nombre_encargado", nino.CedulaEncargado));
            cmdActualizarNino.Parameters.Add(new SqlParameter("@cedula_encargado", nino.NombreEncargado));

            try
            {
                conexion.Open();
                cmdActualizarNino.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarNino(int numeroCedula)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);

            //Para eliminar niño
            string slqProcedureEliminarNino = "sp_eliminar_nino";
            SqlCommand cmdEliminarNino = new SqlCommand(slqProcedureEliminarNino, conexion);
            cmdEliminarNino.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarNino.Parameters.Add(new SqlParameter("@cedula_nino", numeroCedula));

            try
            {
                conexion.Open();

                cmdEliminarNino.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }

        public Nino ObtenerNinoPorCedula(int cedulaNino)
        {
            SqlConnection connection = new SqlConnection(stringConexion);

            string sqlProcedureObtenerNino = "sp_obtener_nino_por_cedula";
            SqlCommand comandoObtenerNino = new SqlCommand(sqlProcedureObtenerNino, connection);
            comandoObtenerNino.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerNino.Parameters.Add(new SqlParameter("@cedula_nino", cedulaNino));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerNino.ExecuteReader();
                Nino nino = new Nino();

                while (dataReader.Read())
                {
                    nino.CedulaNino = Int32.Parse(dataReader["cedula_nino"].ToString());
                    nino.NombreNino = dataReader["nombre_nino"].ToString();
                    nino.FechaNacimiento = DateTime.Parse(dataReader["fecha_nacimiento"].ToString());
                    nino.Edad = Int32.Parse(dataReader["edad"].ToString());
                    nino.NombreEncargado = dataReader["nombre_encargado"].ToString();
                    nino.CedulaEncargado = Int32.Parse(dataReader["cedula_encargado"].ToString());
                }
                connection.Close();
                return nino;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
