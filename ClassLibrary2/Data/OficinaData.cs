using ClassLibrary2.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Data
{
    public class OficinaData
    {
        private string stringConexion;


        public OficinaData(string stringConexion)
        {
            this.stringConexion = stringConexion;

        }

        public Oficina ObtenerOficina(int codigoOficina)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerOficina = "sp_obtener_oficina";
            SqlCommand comandoObtenerOficina = new SqlCommand(sqlProcedureObtenerOficina, connection);
            comandoObtenerOficina.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerOficina.Parameters.Add(new SqlParameter("@codigo_oficina", codigoOficina));
            Oficina oficina = new Oficina();
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerOficina.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    oficina.CodigoOficina = dataReader["codigo_oficina"].ToString();
                    oficina.Provincia = dataReader["provincia"].ToString();
                    oficina.Canton = dataReader["canton"].ToString();
                    oficina.Distrito = dataReader["distrito"].ToString();
                    oficina.Telefono = dataReader["telefono"].ToString();
                    oficina.Fax = dataReader["fax"].ToString();
                    oficina.Correo = dataReader["correo"].ToString();

                }
                connection.Close();
                return oficina;
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
        public LinkedList<Oficina> ObtenerOficinas(string ubicacion)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerOficinas = "sp_obtener_oficinas";
            SqlCommand comandoObtenerOficina = new SqlCommand(sqlProcedureObtenerOficinas, connection);
            comandoObtenerOficina.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerOficina.Parameters.Add(new SqlParameter("@ubicacion", ubicacion));
            
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerOficina.ExecuteReader();
                LinkedList<Oficina> listaOficinas = new LinkedList<Oficina>();
                while (dataReader.Read())
                {
                    Oficina oficina = new Oficina();
                    oficina.CodigoOficina = dataReader["codigo_oficina"].ToString();
                    oficina.Provincia = dataReader["provincia"].ToString();
                    oficina.Canton = dataReader["canton"].ToString();
                    oficina.Distrito = dataReader["distrito"].ToString();
                    oficina.Telefono = dataReader["telefono"].ToString();
                    oficina.Fax = dataReader["fax"].ToString();
                    oficina.Correo = dataReader["correo"].ToString();


                    listaOficinas.AddLast(oficina);
                }
                connection.Close();
                return listaOficinas;
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


        public void InsertarOficina(Oficina oficina)
        {
           
            SqlConnection conexion = new SqlConnection(stringConexion);
            string slqProcedureInsertarOficina = "sp_insertar_oficina";
            SqlCommand cmdInsertarOficina = new SqlCommand(slqProcedureInsertarOficina, conexion);
            cmdInsertarOficina.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            
            cmdInsertarOficina.Parameters.Add(new SqlParameter("@provincia", oficina.Provincia));
            cmdInsertarOficina.Parameters.Add(new SqlParameter("@canton", oficina.Canton));
            cmdInsertarOficina.Parameters.Add(new SqlParameter("@distrito", oficina.Distrito));
            cmdInsertarOficina.Parameters.Add(new SqlParameter("@telefono", oficina.Telefono));
            cmdInsertarOficina.Parameters.Add(new SqlParameter("@fax", oficina.Fax));
            cmdInsertarOficina.Parameters.Add(new SqlParameter("@correo", oficina.Correo));
            try
            {
                conexion.Open();
                cmdInsertarOficina.ExecuteNonQuery();
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

        public void ActualizarOficina(Oficina oficina)
        {
            string slqProcedureActualizarOficina = "sp_actualizar_oficina";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdActualizarOficina = new SqlCommand(slqProcedureActualizarOficina, conexion);
            cmdActualizarOficina.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@codigo_oficina", oficina.CodigoOficina));
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@provincia", oficina.Provincia));
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@canton", oficina.Canton));
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@distrito", oficina.Distrito));
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@telefono", oficina.Telefono));
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@fax", oficina.Fax));
            cmdActualizarOficina.Parameters.Add(new SqlParameter("@correo", oficina.Correo));
            try
            {
                conexion.Open();
                cmdActualizarOficina.ExecuteNonQuery();
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

        public void EliminarOficina(int codigoOficina)
        {
            string slqProcedureEliminarOficina = "sp_eliminar_oficina";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdEliminarOficina = new SqlCommand(slqProcedureEliminarOficina, conexion);
            cmdEliminarOficina.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdEliminarOficina.Parameters.Add(new SqlParameter("@codigo_oficina", codigoOficina));
            try
            {
                conexion.Open();
                cmdEliminarOficina.ExecuteNonQuery();
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

    }
}

