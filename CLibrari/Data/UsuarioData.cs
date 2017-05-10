using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Library.Data
{
    public class UsuarioData
    {
        private string stringConexion;


        public UsuarioData(string stringConexion)
        {
            this.stringConexion = stringConexion;

        }

        public Usuario ObtenerUsuario(string usuario)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerUsuario = "sp_obtener_usuario";

            SqlCommand comandoObtenerUsuario = new SqlCommand(sqlProcedureObtenerUsuario, connection);

            comandoObtenerUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerUsuario.Parameters.Add(new SqlParameter("@usuario", usuario));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerUsuario.ExecuteReader();
                Usuario usuario = new Usuario();
                while (dataReader.Read())
                {
                   
                }
                connection.Close();
                return curso;
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
