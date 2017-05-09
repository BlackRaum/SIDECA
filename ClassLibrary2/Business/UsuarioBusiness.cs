using ClassLibrary2.Domain;
using Library.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Business
{
    public class UsuarioBusiness
    {
        private UsuarioData usuarioData;

        public UsuarioBusiness(string conexion)
        {

            usuarioData = new UsuarioData(conexion);
        }

        public Usuario ObtenerUsuario(string nickName)
        {
            try
            {
                return usuarioData.ObtenerUsuario(nickName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            
        }

        public LinkedList<Usuario> ObtenerUsuarios(string nickName)
        {
            try
            {
                return usuarioData.ObtenerUsuarios(nickName);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public void InsertarUsuario(Usuario usuario)
        {
            try
            {
                usuarioData.InsertarUsuario(usuario);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                usuarioData.ActualizarUsuario(usuario);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarUsuario(string nickNameUsuario)
        {
            try
            {
                usuarioData.EliminarUsuario(nickNameUsuario);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
           
        }

    }
}