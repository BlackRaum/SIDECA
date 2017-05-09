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
    public class OficinaBusiness
    {
        private OficinaData oficinaData;

        public OficinaBusiness(string conexion)
        {

            oficinaData = new OficinaData(conexion);
        }

        public Oficina ObtenerOficina(int codigoOficina)
        {
            try
            {
                return oficinaData.ObtenerOficina(codigoOficina);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public LinkedList<Oficina> ObtenerOficinas(string ubicacion)
        {
            try
            {
                return oficinaData.ObtenerOficinas(ubicacion);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public void InsertarOficina(Oficina oficina)
        {
            try
            {
                oficinaData.InsertarOficina(oficina);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ActualizarOficina(Oficina oficina)
        {
            try
            {
                oficinaData.ActualizarOficina(oficina);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EliminarOficina(int codigoOficina)
        {
            try
            {
                oficinaData.EliminarOficina(codigoOficina);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public LinkedList<Oficina> ObtenerOficinasTodas()
        {
            return oficinaData.ObtenerOficinasTodas();
        }

    }
}

