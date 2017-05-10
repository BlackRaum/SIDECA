using ClassLibrary2.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Library.Data
{

    public class DenunciaData
    {
        private string stringConexion;

        public DenunciaData(string stringConexion)
        {
            this.stringConexion = stringConexion;
        }

        public void InsertarDenuncia(Denuncia denuncia)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            //para insertar denuncia
            string slqProcedureInsertarDenuncia = "sp_insertar_denuncia";
            SqlCommand cmdInsertarDenuncia = new SqlCommand(slqProcedureInsertarDenuncia, conexion);
            cmdInsertarDenuncia.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarDenuncia.Parameters.Add(new SqlParameter("@numero_expediente", denuncia.NumeroExpediente));
            cmdInsertarDenuncia.Parameters.Add(new SqlParameter("@tipo_denuncia", denuncia.TipoDenuncia));
            cmdInsertarDenuncia.Parameters.Add(new SqlParameter("@fecha_ingreso", denuncia.FechaIngreso));

            //para vincular la denuncia con el niño
            string slqProcedureInsertarDenunciaNino = "sp_insertar_denuncia_nino";
            SqlCommand cmdInsertarDenunciaNino = new SqlCommand(slqProcedureInsertarDenunciaNino, conexion);
            cmdInsertarDenunciaNino.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregamos los parámetros
            cmdInsertarDenunciaNino.Parameters.Add(new SqlParameter("@cedula_nino", denuncia.Nino.CedulaNino));
            cmdInsertarDenunciaNino.Parameters.Add(new SqlParameter("@numero_expediente", denuncia.NumeroExpediente));

            conexion.Open();

            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {

                cmdInsertarDenuncia.Transaction = transaccion;
                cmdInsertarDenunciaNino.Transaction = transaccion;

                cmdInsertarDenuncia.ExecuteNonQuery();
                cmdInsertarDenunciaNino.ExecuteNonQuery();

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

        public void ActualizarDenuncia(Denuncia denuncia)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);

            //Para actualizar denuncia
            string slqProcedureActualizarDenuncia = "sp_actualizar_denuncia";
            SqlCommand cmdActualizarDenuncia = new SqlCommand(slqProcedureActualizarDenuncia, conexion);
            cmdActualizarDenuncia.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdActualizarDenuncia.Parameters.Add(new SqlParameter("@numero_expediente", denuncia.NumeroExpediente));
            cmdActualizarDenuncia.Parameters.Add(new SqlParameter("@tipo_denuncia", denuncia.TipoDenuncia));
            cmdActualizarDenuncia.Parameters.Add(new SqlParameter("@fecha_ingreso", denuncia.FechaIngreso));

            try
            {
                conexion.Open();
                cmdActualizarDenuncia.ExecuteNonQuery();
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

        public void EliminarDenuncia(string numeroExpediente)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);

            //Para eliminar vínculos de denuncia-niño
            string slqProcedureEliminarDenunciaNino = "sp_eliminar_denuncia_nino";
            SqlCommand cmdEliminarDenunciaNino = new SqlCommand(slqProcedureEliminarDenunciaNino, conexion);
            cmdEliminarDenunciaNino.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarDenunciaNino.Parameters.Add(new SqlParameter("@numero_expediente", numeroExpediente));

            //Para eliminar la denuncia
            string slqProcedureEliminarDenuncia = "sp_eliminar_denuncia";
            SqlCommand cmdEliminarDenuncia = new SqlCommand(slqProcedureEliminarDenuncia, conexion);
            cmdEliminarDenuncia.CommandType = System.Data.CommandType.StoredProcedure;
            cmdEliminarDenuncia.Parameters.Add(new SqlParameter("@numero_expediente", numeroExpediente));

            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();

            try
            {
                cmdEliminarDenuncia.Transaction = transaccion;
                cmdEliminarDenunciaNino.Transaction = transaccion;

                cmdEliminarDenunciaNino.ExecuteNonQuery();
                cmdEliminarDenuncia.ExecuteNonQuery();
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

        public LinkedList<Denuncia> ObtenerDenunciasPorNino(int cedulaNino)
        {
            SqlConnection connection = new SqlConnection(stringConexion);

            string sqlProcedureObtenerDenuncias = "sp_obtener_denuncias_por_nino";
            SqlCommand comandoObtenerDenuncias = new SqlCommand(sqlProcedureObtenerDenuncias, connection);
            comandoObtenerDenuncias.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerDenuncias.Parameters.Add(new SqlParameter("@cedula_nino", cedulaNino));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerDenuncias.ExecuteReader();
                LinkedList<Denuncia> listaDenuncias = new LinkedList<Denuncia>();
                while (dataReader.Read())
                {

                    Denuncia denuncia = new Denuncia();
                    denuncia.NumeroExpediente = dataReader["numero_expediente"].ToString();
                    denuncia.TipoDenuncia = dataReader["tipo_denuncia"].ToString();
                    denuncia.FechaIngreso = DateTime.Parse(dataReader["fecha_ingreso"].ToString());
                    denuncia.Nino.CedulaNino = Int32.Parse(dataReader["cedula_nino"].ToString());
                    listaDenuncias.AddLast(denuncia);
                }
                connection.Close();
                return listaDenuncias;
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

        public Denuncia ObtenerDenunciaPorExpediente(string numeroExpediente)
        {
            SqlConnection connection = new SqlConnection(stringConexion);

            string sqlProcedureObtenerDenuncia = "sp_obtener_denuncia_por_expediente";
            SqlCommand comandoObtenerDenuncia = new SqlCommand(sqlProcedureObtenerDenuncia, connection);
            comandoObtenerDenuncia.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerDenuncia.Parameters.Add(new SqlParameter("@numero_expediente", numeroExpediente));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerDenuncia.ExecuteReader();

                Denuncia denuncia = new Denuncia();
                while (dataReader.Read())
                {
                    denuncia.NumeroExpediente = dataReader["numero_expediente"].ToString();
                    denuncia.TipoDenuncia = dataReader["tipo_denuncia"].ToString();
                    denuncia.FechaIngreso = DateTime.Parse(dataReader["fecha_ingreso"].ToString());
                    denuncia.Nino.CedulaNino = Int32.Parse(dataReader["cedula_nino"].ToString());
                }
                connection.Close();
                return denuncia;
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
