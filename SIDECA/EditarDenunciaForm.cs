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
    public partial class EditarDenunciaForm : Form
    {
        private DenunciaBusiness denunciaBusiness;

        public EditarDenunciaForm(string numeroExpediente)
        {
            InitializeComponent();

            denunciaBusiness = new DenunciaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

            Denuncia denuncia = this.denunciaBusiness.ObtenerDenunciaPorExpediente(numeroExpediente);
            //PlaceHolder
            tbxCedulaMenor.Text = denuncia.Nino.CedulaNino+"";
            tbxCedulaMenor.Enabled = false;
            tbxNumeroExpediente.Text = denuncia.NumeroExpediente;
            tbxNumeroExpediente.Enabled = false;
            cbxTipoDenuncia.SelectedItem = cbxTipoDenuncia.Items.IndexOf(denuncia.TipoDenuncia);
            dtpFechaIngreso.MaxDate = DateTime.Now;
            dtpFechaIngreso.MinDate = DateTime.Now.AddYears(-1);
            dtpFechaIngreso.Value = denuncia.FechaIngreso;
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
            if (!cbxTipoDenuncia.Text.Equals("Teléfono")&& !cbxTipoDenuncia.Text.Equals("Correo Electrónico") && !cbxTipoDenuncia.Text.Equals("Presencial")&&!cbxTipoDenuncia.Text.Equals("Institución Educativa"))
            {
                cbxTipoDenuncia.DropDownStyle = ComboBoxStyle.DropDown;
                cbxTipoDenuncia.Text = "Tipo de Denuncia";
                lblErrorTipoDenuncia.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
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

            if (cbxTipoDenuncia.Text.Equals("") || cbxTipoDenuncia.Text.Equals("Tipo de Denuncia"))
            {
                lblErrorTipoDenuncia.Visible = true;
                formularioCorrecto = false;
            }
                        
            if (formularioCorrecto)
            {
                //Editamos la Denuncia
                
                Denuncia denuncia = new Denuncia();
                denuncia.Nino.CedulaNino = Int32.Parse(tbxCedulaMenor.Text);
                denuncia.NumeroExpediente = tbxNumeroExpediente.Text;
                denuncia.TipoDenuncia = cbxTipoDenuncia.SelectedText;                
                denuncia.FechaIngreso = dtpFechaIngreso.Value.Date;
               
                try
                {
                    this.denunciaBusiness.ActualizarDenuncia(denuncia);
                }
                catch (SqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
