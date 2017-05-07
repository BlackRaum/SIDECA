using System;
using System.Collections.Generic;
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

        public Usuario ObtenerUsuario(string nickName)
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerUsuario = "sp_obtener_usuario";
            SqlCommand comandoObtenerUsuario = new SqlCommand(sqlProcedureObtenerUsuario, connection);
            comandoObtenerUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerUsuario.Parameters.Add(new SqlParameter("@usuario", nickName));
            Usuario usuario = new Usuario();
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerUsuario.ExecuteReader();
               
                while (dataReader.Read())
                {
                   
                }
                connection.Close();
                return usuario;
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
