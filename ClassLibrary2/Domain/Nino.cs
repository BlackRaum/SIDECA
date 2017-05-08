using System;

namespace ClassLibrary2.Domain
{

    public class Nino
    {
        private int cedulaNino;
        private String nombreNino;
        private Char sexo;
        private int edad;
        private DateTime fechaNacimiento;
        private int cedulaEncargado;
        private String nombreEncargado;

        public Nino()
        {
        }

        public int CedulaNino
        {
            get => cedulaNino;
            set => cedulaNino = value;
        }
        public string NombreNino
        {
            get => nombreNino;
            set => nombreNino = value;
        }
        public char Sexo
        {
            get => sexo;
            set => sexo = value;
        }
        public int Edad
        {
            get => edad;
            set => edad = value;
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public int CedulaEncargado
        {
            get => cedulaEncargado;
            set => cedulaEncargado = value;
        }
        public string NombreEncargado
        {
            get => nombreEncargado;
            set => nombreEncargado = value;
        }
    }
}