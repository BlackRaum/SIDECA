using ClassLibrary2.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Data
{
    public class CasoData
    {
        private string stringConexion;

        public CasoData(string stringConexion)
        {
            this.stringConexion = stringConexion;
        }

        public void InsertarCaso(Caso caso)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            //para insertar denuncia
            string slqProcedureInsertarCaso = "sp_insertar_caso";
            SqlCommand cmdInsertarCaso = new SqlCommand(slqProcedureInsertarCaso, conexion);
            cmdInsertarCaso.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarCaso.Parameters.Add(new SqlParameter("@numero_expediente", caso.NumeroExpediente));
            cmdInsertarCaso.Parameters.Add(new SqlParameter("@fecha_atencion", caso.FechaAtencion));
            cmdInsertarCaso.Parameters.Add(new SqlParameter("@estado", caso.Estado));
            cmdInsertarCaso.Parameters.Add(new SqlParameter("@codigo_departamento", caso.Departamento.CodigoDepartamento));
            cmdInsertarCaso.Parameters.Add(new SqlParameter("@cedula_profesional", caso.Profesional.Cedula));

            //para vincular la denuncia con el niño
            string slqProcedureInsertarDenunciaNino = "sp_insertar_denuncia_nino";
            SqlCommand cmdInsertarCasoNino = new SqlCommand(slqProcedureInsertarDenunciaNino, conexion);
            cmdInsertarCasoNino.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregamos los parámetros
            cmdInsertarCasoNino.Parameters.Add(new SqlParameter("@cedula_nino", caso.Nino.CedulaNino));
            cmdInsertarCasoNino.Parameters.Add(new SqlParameter("@numero_expediente", caso.NumeroExpediente));

            conexion.Open();

            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {

                cmdInsertarCaso.Transaction = transaccion;
                cmdInsertarCasoNino.Transaction = transaccion;

                cmdInsertarCaso.ExecuteNonQuery();
                cmdInsertarCasoNino.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void ActualizarCaso(Caso caso)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);

            //Para actualizar denuncia
            string slqProcedureActualizarCaso = "sp_actualizar_caso";
            SqlCommand cmdActualizarCaso = new SqlCommand(slqProcedureActualizarCaso, conexion);
            cmdActualizarCaso.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdActualizarCaso.Parameters.Add(new SqlParameter("@fecha_atencion", caso.FechaAtencion));
            cmdActualizarCaso.Parameters.Add(new SqlParameter("@estado", caso.Estado));
            cmdActualizarCaso.Parameters.Add(new SqlParameter("@codigo_departamento", caso.Departamento.CodigoDepartamento));
            cmdActualizarCaso.Parameters.Add(new SqlParameter("@cedula_profesional", caso.Profesional.Cedula));

            try
            {
                conexion.Open();
                cmdActualizarCaso.ExecuteNonQuery();
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

        public void EliminarCaso(string numeroExpediente)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);

            //Para eliminar vínculos de caso-niño
            string slqProcedureEliminarCasoNino = "sp_eliminar_caso_nino";
            SqlCommand cmdEliminarCasoNino = new SqlCommand(slqProcedureEliminarCasoNino, conexion);
            cmdEliminarCasoNino.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarCasoNino.Parameters.Add(new SqlParameter("@numero_expediente", numeroExpediente));

            //Para eliminar la denuncia
            string slqProcedureEliminarCaso = "sp_eliminar_caso";
            SqlCommand cmdEliminarCaso = new SqlCommand(slqProcedureEliminarCaso, conexion);
            cmdEliminarCaso.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarCaso.Parameters.Add(new SqlParameter("@numero_expediente", numeroExpediente));

            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                cmdEliminarCasoNino.ExecuteNonQuery();
                cmdEliminarCaso.ExecuteNonQuery();
                transaccion.Commit();
            }
            catch (SqlException exc)
            {
                transaccion.Rollback();
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
        }

        public LinkedList<Caso> ObtenerCasosPorNino(int cedulaNino)
        {
            SqlConnection connection = new SqlConnection(stringConexion);

            string sqlProcedureObtenerCaso = "sp_obtener_casos_por_nino";
            SqlCommand comandoObtenerCaso = new SqlCommand(sqlProcedureObtenerCaso, connection);
            comandoObtenerCaso.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerCaso.Parameters.Add(new SqlParameter("@cedula_nino", cedulaNino));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerCaso.ExecuteReader();
                LinkedList<Caso> listaCasos = new LinkedList<Caso>();
                while (dataReader.Read())
                {

                    Caso caso = new Caso();
                    caso.NumeroExpediente = dataReader["numero_expediente"].ToString();
                    caso.FechaAtencion = DateTime.Parse(dataReader["fecha_atencion"].ToString());
                    caso.Estado = dataReader["estado"].ToString();
                    caso.Profesional.Cedula = Int32.Parse(dataReader["cedula_profesional"].ToString());
                    caso.Departamento.CodigoDepartamento = Int32.Parse(dataReader["codigo_departamento"].ToString());
                    caso.Nino.CedulaNino = Int32.Parse(dataReader["cedula_nino"].ToString());
                    listaCasos.AddLast(caso);
                }
                connection.Close();
                return listaCasos;
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

        public Caso ObtenerCasoPorExpediente(string numeroExpediente)
        {
            SqlConnection connection = new SqlConnection(stringConexion);

            string sqlProcedureObtenerCaso = "sp_obtener_caso_por_expediente";
            SqlCommand comandoObtenerCaso = new SqlCommand(sqlProcedureObtenerCaso, connection);
            comandoObtenerCaso.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerCaso.Parameters.Add(new SqlParameter("@numero_expediente", numeroExpediente));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerCaso.ExecuteReader();

                Caso caso = new Caso();
                while (dataReader.Read())
                {
                    caso.NumeroExpediente = dataReader["numero_expediente"].ToString();
                    caso.FechaAtencion = DateTime.Parse(dataReader["fecha_atencion"].ToString());
                    caso.Estado = dataReader["estado"].ToString();
                    caso.Profesional.Cedula = Int32.Parse(dataReader["cedula_profesional"].ToString());
                    caso.Departamento.CodigoDepartamento = Int32.Parse(dataReader["codigo_departamento"].ToString());
                    caso.Nino.CedulaNino = Int32.Parse(dataReader["cedula_nino"].ToString());
                }
                connection.Close();
                return caso;
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
