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
    public class CasoBusiness
    {
        CasoData casoData;

        public CasoBusiness(string conexion)
        {
            this.casoData = new CasoData(conexion);
        }

        public void InsertarCaso(Caso caso)
        {
            try
            {
                this.casoData.InsertarCaso(caso);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarCaso(Caso caso)
        {
            try
            {
                this.casoData.ActualizarCaso(caso);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarCaso(string numeroExpediente)
        {
            try
            {
                this.casoData.EliminarCaso(numeroExpediente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public LinkedList<Caso> ObtenerCasosPorNino(int cedulaNino)
        {
            try
            {
                return this.casoData.ObtenerCasosPorNino(cedulaNino);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Caso ObtenerCasoPorExpediente(string numeroExpediente)
        {
            try
            {
                return this.casoData.ObtenerCasoPorExpediente(numeroExpediente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
