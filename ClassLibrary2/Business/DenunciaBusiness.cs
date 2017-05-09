using ClassLibrary2.Domain;
using Library.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Business
{
    public class DenunciaBusiness
    {
        DenunciaData denunciaData;

        public DenunciaBusiness(string conexion)
        {
            this.denunciaData = new DenunciaData(conexion);
        }

        public void InsertarDenuncia(Denuncia denuncia)
        {
            try
            {
                this.denunciaData.InsertarDenuncia(denuncia);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarDenuncia(Denuncia denuncia)
        {
            try
            {
                this.denunciaData.ActualizarDenuncia(denuncia);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarDenuncia(string numeroExpediente)
        {
            try
            {
                this.EliminarDenuncia(numeroExpediente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public LinkedList<Denuncia> ObtenerDenunciasPorNino(int cedulaNino)
        {
            try
            {
                return this.ObtenerDenunciasPorNino(cedulaNino);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Denuncia ObtenerDenunciaPorExpediente(string numeroExpediente)
        {
            try
            {
                return this.ObtenerDenunciaPorExpediente(numeroExpediente);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
