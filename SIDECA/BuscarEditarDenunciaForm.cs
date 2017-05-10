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
    public partial class BuscarEditarDenunciaForm : Form
    {
        private DenunciaBusiness denunciaBusiness;

        public BuscarEditarDenunciaForm()
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
            lblErrorNumeroExpediente.Visible = false;
        }

        private void tbxNumeroExpediente_Leave(object sender, EventArgs e)
        {
            if (tbxNumeroExpediente.Text.Equals(""))
            {
                lblErrorNumeroExpediente.Text = "*Debe ingresar el número de expediente.";
                tbxNumeroExpediente.Text = "Número de Expediente";
                tbxNumeroExpediente.ForeColor = SystemColors.GrayText;
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Boolean formularioCorrecto = true;
            if (tbxNumeroExpediente.Text.Equals("Número de Expediente"))
            {
                lblErrorNumeroExpediente.Visible = true;
                formularioCorrecto = false;
            }

            if (formularioCorrecto)
            {
                String numeroExpediente = tbxNumeroExpediente.Text;
                Denuncia denuncia = this.denunciaBusiness.ObtenerDenunciaPorExpediente(numeroExpediente);
                if (denuncia.NumeroExpediente == null)
                {
                    lblErrorNumeroExpediente.Text = "*Este expediente no existe. Intente con otro.";
                    lblErrorNumeroExpediente.Visible = true;
                }
                else
                {
                    EditarDenunciaForm editarDenunciaForm = new EditarDenunciaForm(numeroExpediente);
                    editarDenunciaForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
