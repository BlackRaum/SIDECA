using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


    class ProfesionalData
    {
        private string stringConexion;
        public ProfesionalData()
        {
            this.stringConexion = "Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes";
        }

    public Profesional ObtenerProfesional(int cedula)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerProfesional = "sp_obtener_profesional";
            SqlCommand comandoObtenerProfesional = new SqlCommand(sqlProcedureObtenerProfesional, connection);
            comandoObtenerProfesional.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerProfesional.Parameters.Add(new SqlParameter("@cedula", cedula));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerProfesional.ExecuteReader();
                Profesional profesional = new Profesional();
                while (dataReader.Read())
                {
                    profesional.Cedula = Int32.Parse(dataReader["cedula_profesional"].ToString());
                    profesional.NombreCompleto = dataReader["nombre_completo"].ToString();
                    profesional.Especialidad = dataReader["especialidad"].ToString();
                    profesional.TelefonoCelular = dataReader["telefono_celular"].ToString();
                    profesional.Correo = dataReader["correo"].ToString();
                }
                connection.Close();
                return profesional;
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
    public LinkedList<Profesional> ObtenerProfesionalbyNombre(string nombreProfesional)
    {
        SqlConnection connection = new SqlConnection(stringConexion);
        string sqlProcedureObtenerProfesionalbyNombre = "sp_obtener_profesionalbyNombre";
        SqlCommand comandoObtenerProfesionalByNombre = new SqlCommand(sqlProcedureObtenerProfesionalbyNombre, connection);
        comandoObtenerProfesionalByNombre.CommandType = System.Data.CommandType.StoredProcedure;
        comandoObtenerProfesionalByNombre.Parameters.Add(new SqlParameter("@nombre ", nombreProfesional));
        try
        {
            connection.Open();
            SqlDataReader dataReader = comandoObtenerProfesionalByNombre.ExecuteReader();


            LinkedList<Profesional> listaProfesionales = new LinkedList<Profesional>();
            while (dataReader.Read())
            {
                Profesional profesional = new Profesional();
                profesional.Cedula = Int32.Parse(dataReader["cedula_profesional"].ToString());
                profesional.NombreCompleto = dataReader["nombre_completo"].ToString();
                profesional.Especialidad = dataReader["especialidad"].ToString();
                profesional.TelefonoCelular = dataReader["telefono_celular"].ToString();
                profesional.Correo = dataReader["correo"].ToString();

                listaProfesionales.AddLast(profesional);
            }
            connection.Close();
            return listaProfesionales;
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
    public string insertarProfesional(Profesional profesional, int departamento)
    {
        string mensaje = "";
        string sqlProcedureInsertarProfesional = "sp_insertar_profesional";
        SqlConnection connection = new SqlConnection(stringConexion);
        SqlCommand cmdInsertarProfesional = new SqlCommand(sqlProcedureInsertarProfesional, connection);
        cmdInsertarProfesional.CommandType = System.Data.CommandType.StoredProcedure;

        //agregar parametros
        cmdInsertarProfesional.Parameters.Add(new SqlParameter("@cedula", profesional.Cedula));
        cmdInsertarProfesional.Parameters.Add(new SqlParameter("@nombre", profesional.NombreCompleto));
        cmdInsertarProfesional.Parameters.Add(new SqlParameter("@especialidad", profesional.Especialidad));
        cmdInsertarProfesional.Parameters.Add(new SqlParameter("@telefono", profesional.TelefonoCelular));
        cmdInsertarProfesional.Parameters.Add(new SqlParameter("@correo", profesional.Correo));
        cmdInsertarProfesional.Parameters.Add(new SqlParameter("@codigo_departamento", departamento));

        try
        {
            connection.Open();
            cmdInsertarProfesional.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            mensaje = ex.ToString();
            //throw ex;

        }
        finally
        {
            connection.Close();
        }
        return mensaje;

    }
    public string eliminarProfesional(int cedula)
    {
        string mensaje = "";
        string sqlProcedureEliminarProfesional = "sp_eliminar_profesional";
        SqlConnection connection = new SqlConnection(stringConexion);
        SqlCommand cmdEliminarProfesional = new SqlCommand(sqlProcedureEliminarProfesional, connection);
        cmdEliminarProfesional.CommandType = System.Data.CommandType.StoredProcedure;

        //agregar parametros
        cmdEliminarProfesional.Parameters.Add(new SqlParameter("@cedula", cedula));

        try
        {
            connection.Open();
            cmdEliminarProfesional.ExecuteNonQuery();
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
    public string actualizarProfesional(Profesional profesional,int codigoDepartamento)
    {
        string mensage = "";
        string sqlProcedureActualizarProfesional = "sp_actualizar_profesional";
        SqlConnection connection = new SqlConnection(stringConexion);
        SqlCommand cmdActualizarProfesional = new SqlCommand(sqlProcedureActualizarProfesional, connection);
        cmdActualizarProfesional.CommandType = System.Data.CommandType.StoredProcedure;

        //agregar parametros
        cmdActualizarProfesional.Parameters.Add(new SqlParameter("@cedula", profesional.Cedula));
        cmdActualizarProfesional.Parameters.Add(new SqlParameter("@nombre", profesional.NombreCompleto));
        cmdActualizarProfesional.Parameters.Add(new SqlParameter("@especialidad", profesional.Especialidad));
        cmdActualizarProfesional.Parameters.Add(new SqlParameter("@telefono", profesional.TelefonoCelular));
        cmdActualizarProfesional.Parameters.Add(new SqlParameter("@correo", profesional.Correo));
        cmdActualizarProfesional.Parameters.Add(new SqlParameter("@codigo_departamento", codigoDepartamento)); 

        try
        {
            connection.Open();
            cmdActualizarProfesional.ExecuteNonQuery();
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
