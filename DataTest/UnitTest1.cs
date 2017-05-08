using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Data;
using ClassLibrary2.Domain;

namespace DataTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UsuarioData usuarioData = new UsuarioData("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
            Usuario usuario = new Usuario();

            usuario.NombreUsuario = "Rogelio23";
            usuario.Contrasena = "123ad.23";
            usuarioData.InsertarUsuario(usuario);
        }
    }
}
