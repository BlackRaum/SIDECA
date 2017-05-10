using ClassLibrary2.Domain;
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
                    usuario.NombreUsuario = dataReader["usuario"].ToString();
                    usuario.Contrasena = dataReader["constrasena"].ToString();
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
        public LinkedList<Usuario> ObtenerUsuarios()
        {
            SqlConnection connection = new SqlConnection(stringConexion);
            string sqlProcedureObtenerUsuarios = "sp_obtener_usuarios";
            SqlCommand comandoObtenerUsuarios = new SqlCommand(sqlProcedureObtenerUsuarios, connection);
            comandoObtenerUsuarios.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerUsuarios.ExecuteReader();
                LinkedList<Usuario> listaUsuarios = new LinkedList<Usuario>();
                while (dataReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.NombreUsuario = dataReader["usuario"].ToString();
                    usuario.Contrasena = dataReader["constrasena"].ToString();

                    listaUsuarios.AddLast(usuario);
                }
                connection.Close();
                return listaUsuarios;
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


        public void InsertarUsuario(Usuario usuario)
        {
            string slqProcedureInsertarUsuario= "sp_insertar_usuario";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdInsertarUsuario = new SqlCommand(slqProcedureInsertarUsuario, conexion);
            cmdInsertarUsuario.CommandType = System.Data.CommandType.StoredProcedure;

            //Agregar los demas parametros restantes
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@usuario", usuario.NombreUsuario));
            cmdInsertarUsuario.Parameters.Add(new SqlParameter("@contrasena", usuario.Contrasena));
            try
            {
                conexion.Open();
                cmdInsertarUsuario.ExecuteNonQuery();
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

        public void ActualizarUsuario(Usuario usuario)
        {
            string slqProcedureActualizarUsuario = "sp_actualizar_usuario";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdActualizarUsuario = new SqlCommand(slqProcedureActualizarUsuario, conexion);
            cmdActualizarUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@usuario", usuario.NombreUsuario));
            cmdActualizarUsuario.Parameters.Add(new SqlParameter("@contrasena", usuario.Contrasena));
            try
            {
                conexion.Open();
                cmdActualizarUsuario.ExecuteNonQuery();
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

        public void EliminarUsuario(string nickNameUsuario)
        {
            string slqProcedureEliminarUsuario = "sp_eliminar_usuario";
            SqlConnection conexion = new SqlConnection(stringConexion);
            SqlCommand cmdEliminarUsuario = new SqlCommand(slqProcedureEliminarUsuario, conexion);
            cmdEliminarUsuario.CommandType = System.Data.CommandType.StoredProcedure;
            //Agregar los demas parametros restantes
            cmdEliminarUsuario.Parameters.Add(new SqlParameter("@nombreUsuario", nickNameUsuario));
            try
            {
                conexion.Open();
                cmdEliminarUsuario.ExecuteNonQuery();
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
