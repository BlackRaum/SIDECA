using System;

namespace ClassLibrary2.Domain
{
    public class Departamento
    {
        private int codigoDepartamento;
        private String nombreDepartamento;
        private String telefono;
        private String fax;
        private String correo;
        private Oficina oficina;

        public Departamento()
        {
            this.oficina = new Oficina();
        }

        public int CodigoDepartamento { get => codigoDepartamento; set => codigoDepartamento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Correo { get => correo; set => correo = value; }
        public Oficina Oficina { get => oficina; set => oficina = value; }
        public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
    }
}