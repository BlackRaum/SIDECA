using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

    public class DepartamentoData
    {

        private string stringConexion;


        public DepartamentoData()
        {
        this.stringConexion = "Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes";
}

        public Departamento ObtenerDepartamento(int departamento)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerDepartamento = "sp_obtener_departamento";
            SqlCommand comandoObtenerDepartamento = new SqlCommand(sqlProcedureObtenerDepartamento, connection);
            comandoObtenerDepartamento.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerDepartamento.Parameters.Add(new SqlParameter("@codigo_departamento", departamento));
            try
        {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerDepartamento.ExecuteReader();
                Departamento depto = new Departamento();
                while (dataReader.Read())
                {
                    depto.CodigoDepartamento = Int32.Parse(dataReader["codigo_departamento"].ToString());
                    depto.NombreDepartamento = dataReader["nombre_departamento"].ToString();
                    depto.Telefono = dataReader["telefono"].ToString();
                    depto.Fax = dataReader["fax"].ToString();
                    depto.Correo = dataReader["correo"].ToString();
                    depto.CodigoOficina = Int32.Parse(dataReader["codigo_oficina"].ToString());
                }
                connection.Close();
                return depto;
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
        public LinkedList<Departamento> ObtenerDepartamentobyOficina(int oficina)
    {
        SqlConnection connection = new SqlConnection(stringConexion);
        string sqlProcedureObtenerDepartamentobyOficina = "sp_obtener_departamento_by_oficina";
        SqlCommand comandoObtenerDepartamentobyOficina = new SqlCommand(sqlProcedureObtenerDepartamentobyOficina, connection);
        comandoObtenerDepartamentobyOficina.CommandType = System.Data.CommandType.StoredProcedure;
        comandoObtenerDepartamentobyOficina.Parameters.Add(new SqlParameter("@codigoOficina", oficina));
        try
        {
            connection.Open();
            SqlDataReader dataReader = comandoObtenerDepartamentobyOficina.ExecuteReader();

            
            LinkedList<Departamento> listaDepartamentos = new LinkedList<Departamento>();
            while (dataReader.Read())
            {
                Departamento depto = new Departamento();
                depto.CodigoDepartamento = Int32.Parse(dataReader["codigo_departamento"].ToString());
                depto.NombreDepartamento = dataReader["nombre_departamento"].ToString();
                depto.Telefono = dataReader["telefono"].ToString();
                depto.Fax = dataReader["fax"].ToString();
                depto.Correo = dataReader["correo"].ToString();
                depto.CodigoOficina = Int32.Parse(dataReader["codigo_oficina"].ToString());

                listaDepartamentos.AddLast(depto);
            }
            connection.Close();
            return listaDepartamentos;
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
        public string insertarDepartamento(Departamento departamento)
    {
        string mensaje = "";
        string sqlProcedureInsertarDepartamento = "sp_insertar_departamento";
        SqlConnection connection = new SqlConnection(stringConexion);
        SqlCommand cmdInsertarDepartamento = new SqlCommand(sqlProcedureInsertarDepartamento, connection);
        cmdInsertarDepartamento.CommandType = System.Data.CommandType.StoredProcedure;

        //agregar parametros
        cmdInsertarDepartamento.Parameters.Add(new SqlParameter("@nombre", departamento.NombreDepartamento));
        cmdInsertarDepartamento.Parameters.Add(new SqlParameter("@telefono", departamento.Telefono));
        cmdInsertarDepartamento.Parameters.Add(new SqlParameter("@fax", departamento.Fax));
        cmdInsertarDepartamento.Parameters.Add(new SqlParameter("@correo", departamento.Correo));
        cmdInsertarDepartamento.Parameters.Add(new SqlParameter("@codigo_oficina", departamento.CodigoOficina));

        try
        {
            connection.Open();
            cmdInsertarDepartamento.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            mensaje = ex.ToString();
            //throw ex;
           
        }
        finally
        {
            connection.Close();
        }return mensaje;
        
    }
        public string eliminarDepartamento(int departamento)
        {
        string mensaje = "";
            string sqlProcedureEliminarDepartamento = "sp_eliminar_departamento";
            SqlConnection connection = new SqlConnection(stringConexion);
            SqlCommand cmdEliminarDepartamento = new SqlCommand(sqlProcedureEliminarDepartamento, connection);
            cmdEliminarDepartamento.CommandType = System.Data.CommandType.StoredProcedure;

            //agregar parametros
            cmdEliminarDepartamento.Parameters.Add(new SqlParameter("@codigo", departamento));

            try
            {
                connection.Open();
                cmdEliminarDepartamento.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
            //throw ex;
            mensaje = ex.ToString();
            }
            finally
            {
                connection.Close();
            }
        return mensaje;
        }
        public string actualizarDepartamento(Departamento departamento)
        {
        string mensage = "";
            string sqlProcedureActualizarDepartamento = "sp_actualizar_departamento";
            SqlConnection connection = new SqlConnection(stringConexion);
            SqlCommand cmdActualizarDepartamento = new SqlCommand(sqlProcedureActualizarDepartamento, connection);
            cmdActualizarDepartamento.CommandType = System.Data.CommandType.StoredProcedure;

        //agregar parametros
        //@codigo int,@nombre varchar(30), @telefono varchar (15),
        // @fax varchar(15),@correo varchar(30),@codigo_oficina varchar(10)
        cmdActualizarDepartamento.Parameters.Add(new SqlParameter("@codigo", departamento.CodigoDepartamento));
        cmdActualizarDepartamento.Parameters.Add(new SqlParameter("@nombre", departamento.NombreDepartamento));
        cmdActualizarDepartamento.Parameters.Add(new SqlParameter("@telefono", departamento.Telefono));
        cmdActualizarDepartamento.Parameters.Add(new SqlParameter("@fax", departamento.Fax));
        cmdActualizarDepartamento.Parameters.Add(new SqlParameter("@correo", departamento.Correo));
        cmdActualizarDepartamento.Parameters.Add(new SqlParameter("@codigo_oficina", departamento.CodigoOficina));

        try
            {
                connection.Open();
                cmdActualizarDepartamento.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
            //throw ex;
            mensage = ex.ToString();
            }
            finally
            {
                connection.Close();
            }
        return mensage;
        }
}

