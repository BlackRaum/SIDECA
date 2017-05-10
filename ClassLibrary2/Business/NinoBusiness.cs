using ClassLibrary2.Data;
using ClassLibrary2.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Business
{
    public class NinoBusiness
    {
        private NinoData ninoData;

        public NinoBusiness(string conexion)
        {
            this.ninoData = new NinoData(conexion);
        }

        public void InsertarNino(Nino nino)
        {
            try
            {
                this.ninoData.InsertarNino(nino);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarNino(Nino nino)
        {
            try
            {
                this.ninoData.ActualizarNino(nino);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarNino(int numeroCedula)
        {
            try
            {
                this.ninoData.EliminarNino(numeroCedula);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Nino ObtenerNinoPorCedula(int cedulaNino)
        {
            try
            {
                return this.ninoData.ObtenerNinoPorCedula(cedulaNino);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
