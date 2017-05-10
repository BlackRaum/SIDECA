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
    public partial class BuscarEditarNinoForm : Form
    {
        private NinoBusiness ninoBusiness;

        public BuscarEditarNinoForm()
        {
            InitializeComponent();

            ninoBusiness = new NinoBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

            //PlaceHolder
            tbxCedulaMenor.Text = "Cédula del Menor";
            tbxCedulaMenor.ForeColor = SystemColors.GrayText;
        }

        private void tbxCedulaMenor_Enter(object sender, EventArgs e)
        {
            if (tbxCedulaMenor.Text.Equals("Cédula del Menor"))
            {
                tbxCedulaMenor.Text = "";
                tbxCedulaMenor.ForeColor = SystemColors.WindowText;
            }
            lblErrorCedulaMenor.Visible = false;
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cedulaMenor;
            Boolean formularioCorrecto = true;
            if (tbxCedulaMenor.Text.Equals("Cédula del Menor"))
            {
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }

            if (!tbxCedulaMenor.Text.Equals("Cédula del Menor") && !Int32.TryParse(tbxCedulaMenor.Text, out cedulaMenor))
            {
                lblErrorCedulaMenor.Text = "*Debe ingresar sólo números.";
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }

            if (formularioCorrecto)
            {
                int cedula = Int32.Parse(tbxCedulaMenor.Text);
                Nino nino = this.ninoBusiness.ObtenerNinoPorCedula(cedula);
                if (nino.NombreNino == null)
                {
                    lblErrorCedulaMenor.Text = "*Esta cédula no existe. Intente con otra.";
                    lblErrorCedulaMenor.Visible = true;
                }
                else
                {
                    EditarNinoForm editarNinoForm = new EditarNinoForm(cedula);
                    editarNinoForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
