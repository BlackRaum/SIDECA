using System;

namespace ClassLibrary2.Domain
{
    public class Usuario
    {
        private String nombreUsuario;
        private String contrasena;

        public Usuario()
        {
        }

        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
    }
}