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
    public partial class InsertarDenunciaForm : Form
    {
        private DenunciaBusiness denunciaBusiness;
        private NinoBusiness ninoBusiness;
        public InsertarDenunciaForm()
        {
            InitializeComponent();

            denunciaBusiness = new DenunciaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
            ninoBusiness = new NinoBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

            //PlaceHolder
            tbxCedulaMenor.Text = "Cédula del Menor";
            tbxCedulaMenor.ForeColor = SystemColors.GrayText;
            tbxNumeroExpediente.Text = "Número de Expediente";
            tbxNumeroExpediente.ForeColor = SystemColors.GrayText;
            cbxTipoDenuncia.ForeColor = SystemColors.GrayText;
            cbxTipoDenuncia.Text = "Tipo de Denuncia";
            dtpFechaIngreso.MaxDate = DateTime.Now;
            dtpFechaIngreso.MinDate = DateTime.Now.AddYears(-1);
        }

        private void tbxCedulaMenor_Enter(object sender, EventArgs e)
        {
            if (tbxCedulaMenor.Text.Equals("Cédula del Menor"))
            {
                tbxCedulaMenor.Text = "";
                tbxCedulaMenor.ForeColor = SystemColors.WindowText;
                lblErrorCedulaMenor.Visible = false;
            }
        }

        private void tbxCedulaMenor_Leave(object sender, EventArgs e)
        {
            if (tbxCedulaMenor.Text.Equals(""))
            {
                lblErrorCedulaMenor.Text = "*Debe ingresar la cédula de menor.";
                tbxCedulaMenor.Text = "Cédula del Menor";
                tbxCedulaMenor.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbxNumeroExpediente_Leave(object sender, EventArgs e)
        {
            if (tbxNumeroExpediente.Text.Equals(""))
            {
                tbxNumeroExpediente.Text = "Número de Expediente";
                tbxNumeroExpediente.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbxNumeroExpediente_Enter(object sender, EventArgs e)
        {
            if (tbxNumeroExpediente.Text.Equals("Número de Expediente"))
            {
                tbxNumeroExpediente.Text = "";
                tbxNumeroExpediente.ForeColor = SystemColors.WindowText;
                lblErrorNumeroExpediente.Visible = false;
            }
        }

        private void cbxTipoDenuncia_Enter(object sender, EventArgs e)
        {
            cbxTipoDenuncia.DropDownStyle = ComboBoxStyle.DropDownList;
            lblErrorTipoDenuncia.Visible = false;
        }

        private void cbxTipoDenuncia_Leave(object sender, EventArgs e)
        {
            cbxTipoDenuncia.ForeColor = SystemColors.WindowText;
            if (!cbxTipoDenuncia.Text.Equals("Teléfono")&& !cbxTipoDenuncia.Text.Equals("Correo Electrónico")&&
                !cbxTipoDenuncia.Text.Equals("Presencial")&& !cbxTipoDenuncia.Text.Equals("Institución Educativa"))
            {
                cbxTipoDenuncia.DropDownStyle = ComboBoxStyle.DropDown;
                cbxTipoDenuncia.Text = "Tipo de Denuncia";
                lblErrorTipoDenuncia.Visible = false;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int cedulaMenor;
            Boolean formularioCorrecto = true;

            if (tbxNumeroExpediente.Text.Equals("Número de Expediente"))
            {
                lblErrorNumeroExpediente.Text = "*Debe ingresar él número de expediente.";
                lblErrorNumeroExpediente.Visible = true;
                formularioCorrecto = false;
            }

            if (tbxCedulaMenor.Text.Equals("Cédula del Menor"))
            {
                lblErrorCedulaMenor.Text = "*Debe ingresar él número de cédula del menor.";
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }
            
            if (!tbxCedulaMenor.Text.Equals("Cédula del Menor")&&!Int32.TryParse(tbxCedulaMenor.Text, out cedulaMenor))
            {
                lblErrorCedulaMenor.Text = "*Debe ingresar sólo números.";
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }

            if (!cbxTipoDenuncia.Text.Equals("Teléfono") && !cbxTipoDenuncia.Text.Equals("Correo Electrónico") && !cbxTipoDenuncia.Text.Equals("Presencial") && !cbxTipoDenuncia.Text.Equals("Institución Educativa"))
            {
                lblErrorTipoDenuncia.Visible = true;
                formularioCorrecto = false;
            }

            if (formularioCorrecto)
            {
                cedulaMenor = Int32.Parse(tbxCedulaMenor.Text);
                Nino nino = this.ninoBusiness.ObtenerNinoPorCedula(cedulaMenor);

                if (nino.NombreNino == null)
                {
                    lblErrorCedulaMenor.Text = "La cédula ingresada no existe. Intente con otra.";
                    lblErrorCedulaMenor.Visible = true;
                    formularioCorrecto = false;
                }
            }

            if (formularioCorrecto)
            {
                //Insertamor el Niño
                Nino nino2 = new Nino();
                nino2.CedulaNino = Int32.Parse(tbxCedulaMenor.Text);
                Denuncia denuncia = new Denuncia();

                denuncia.NumeroExpediente = tbxNumeroExpediente.Text;
                denuncia.TipoDenuncia = cbxTipoDenuncia.SelectedText;                
                denuncia.FechaIngreso = dtpFechaIngreso.Value.Date;
                denuncia.Nino = nino2; 
               
                try
                {
                    this.denunciaBusiness.InsertarDenuncia(denuncia);
                }
                catch (SqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
