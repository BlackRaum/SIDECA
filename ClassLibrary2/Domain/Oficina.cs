using System;

namespace ClassLibrary2.Domain
{
    public class Oficina
    {
        private String codigoOficina;
        private String provincia;
        private String canton;
        private String distrito;
        private String telefono;
        private String fax;
        private String correo;

        public Oficina()
        {
        }

        public string CodigoOficina { get => codigoOficina; set => codigoOficina = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Canton { get => canton; set => canton = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fax { get => fax; set => fax = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Ubicacion { get => provincia + ", " + canton + ", " + distrito; }
    }
}