using System;

namespace ClassLibrary2.Domain
{
    public class Denuncia
    {
        private String numeroExpediente;
        private String tipoDenuncia;
        private DateTime fechaIngreso;
        private Nino nino;

        public Denuncia()
        {
            this.nino = new Nino();
        }

        public string NumeroExpediente { get => numeroExpediente; set => numeroExpediente = value; }
        public string TipoDenuncia { get => tipoDenuncia; set => tipoDenuncia = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public Nino Nino { get => nino; set => nino = value; }
    }
}
