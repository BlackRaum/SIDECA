using System;

namespace ClassLibrary2.Domain
{

    public class Profesional
    {
        private int cedula;
        private String nombreCompleto;
        private String especialidad;
        private String telefonoCelular;
        private String correo;

        public Profesional()
        {
        }

        public int Cedula { get => cedula; set => cedula = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string TelefonoCelular { get => telefonoCelular; set => telefonoCelular = value; }
        public string Correo { get => correo; set => correo = value; }
    }
}