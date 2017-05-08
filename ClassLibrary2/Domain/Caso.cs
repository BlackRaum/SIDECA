using System;

namespace ClassLibrary2.Domain
{
    public class Caso
    {
        private String numeroExpediente;
        private DateTime fechaAtencion;
        private String estado;
        private Profesional profesional;
        private Departamento departamento;
        private Nino nino;

        public Caso()
        {
            this.departamento = new Departamento();
            this.profesional = new Profesional();
        }

        public string NumeroExpediente { get => numeroExpediente; set => numeroExpediente = value; }
        public DateTime FechaAtencion { get => fechaAtencion; set => fechaAtencion = value; }
        public string Estado { get => estado; set => estado = value; }
        public Profesional Profesional { get => profesional; set => profesional = value; }
        public Departamento Departamento { get => departamento; set => departamento = value; }
        public Nino Nino { get => nino; set => nino = value; }
    }
}
