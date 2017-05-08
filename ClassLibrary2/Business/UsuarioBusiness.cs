using Library.Data;
using System;
using System.Collections.Generic;
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
            return usuarioData.ObtenerUsuario(nickName);
        }

        public LinkedList<Usuario> ObtenerUsuarios()
        {
            return usuarioData.ObtenerUsuarios();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            usuarioData.InsertarUsuario(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            usuarioData.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(string nickNameUsuario)
        {
            usuarioData.EliminarUsuario(nickNameUsuario);
        }


    }
}