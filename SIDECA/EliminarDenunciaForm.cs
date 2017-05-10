using ClassLibrary2.Business;
using ClassLibrary2.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIDECA
{
    public partial class EliminarDenunciaForm : Form
    {
        private DenunciaBusiness denunciaBusiness;

        public EliminarDenunciaForm()
        {
            InitializeComponent();

            denunciaBusiness = new DenunciaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

            //PlaceHolder
            tbxNumeroExpediente.Text = "Número de Expediente";
            tbxNumeroExpediente.ForeColor = SystemColors.GrayText;
        }

        private void tbxNumeroExpediente_Enter(object sender, EventArgs e)
        {
            if (tbxNumeroExpediente.Text.Equals("Número de Expediente"))
            {
                tbxNumeroExpediente.Text = "";
                tbxNumeroExpediente.ForeColor = SystemColors.WindowText;
            }
            lblErrorCedulaMenor.Visible = false;
        }

        private void tbxNumeroExpediente_Leave(object sender, EventArgs e)
        {
            if (tbxNumeroExpediente.Text.Equals(""))
            {
                lblErrorCedulaMenor.Text = "*Debe ingresar el número de expediente.";
                tbxNumeroExpediente.Text = "Número de Expediente";
                tbxNumeroExpediente.ForeColor = SystemColors.GrayText;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean formularioCorrecto = true;
            if (tbxNumeroExpediente.Text.Equals("Número de Expediente"))
            {
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }

            if (formularioCorrecto)
            {
                String numeroExpediente = tbxNumeroExpediente.Text;
                Denuncia denuncia = this.denunciaBusiness.ObtenerDenunciaPorExpediente(numeroExpediente);
                if (denuncia.NumeroExpediente == null)
                {
                    lblErrorCedulaMenor.Text = "*Este expediente no existe. Por favor, intente con otro.";
                    lblErrorCedulaMenor.Visible = true;
                }
                else
                {
                    try
                    {
                        this.denunciaBusiness.EliminarDenuncia(numeroExpediente);
                        //Redirigir a Form de Éxito
                    }
                    catch(SqlException ex)
                    {
                        Console.Write(ex.Message);
                        //Redirigir a Form de Error
                    }
                }
            }
        }
    }
}
