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
    public partial class InsertarNinoForm : Form
    {
        private NinoBusiness ninoBusiness;
        public InsertarNinoForm()
        {
            InitializeComponent();

            ninoBusiness = new NinoBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

            //PlaceHolder
            tbxCedulaMenor.Text = "Cédula del Menor";
            tbxCedulaMenor.ForeColor = SystemColors.GrayText;
            tbxNombreMenor.Text = "Nombre del Menor";
            tbxNombreMenor.ForeColor = SystemColors.GrayText;
            tbxCedulaEncargado.Text = "Cédula del Encargado";
            tbxCedulaEncargado.ForeColor = SystemColors.GrayText;
            tbxNombreEncargado.Text = "Nombre del Encargado";
            tbxNombreEncargado.ForeColor = SystemColors.GrayText;
            cbxGenero.ForeColor = SystemColors.GrayText;
            cbxGenero.Text = "Genero";
            dtpFechaNacimiento.MaxDate = DateTime.Now;
            dtpFechaNacimiento.MinDate = DateTime.Now.AddYears(-18);
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

        private void tbxNombreMenor_Leave(object sender, EventArgs e)
        {
            if (tbxNombreMenor.Text.Equals(""))
            {
                tbxNombreMenor.Text = "Nombre del Menor";
                tbxNombreMenor.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbxNombreMenor_Enter(object sender, EventArgs e)
        {
            if (tbxNombreMenor.Text.Equals("Nombre del Menor"))
            {
                tbxNombreMenor.Text = "";
                tbxNombreMenor.ForeColor = SystemColors.WindowText;
                lblErrorNombreMenor.Visible = false;
            }
        }

        private void tbxCedulaEncargado_Leave(object sender, EventArgs e)
        {
            if (tbxCedulaEncargado.Text.Equals(""))
            {
                tbxCedulaEncargado.Text = "Cédula del Encargado";
                tbxCedulaEncargado.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbxCedulaEncargado_Enter(object sender, EventArgs e)
        {
            if (tbxCedulaEncargado.Text.Equals("Cédula del Encargado"))
            {
                tbxCedulaEncargado.Text = "";
                tbxCedulaEncargado.ForeColor = SystemColors.WindowText;
            }
        }

        private void tbxNombreEncargado_Leave(object sender, EventArgs e)
        {
            if (tbxNombreEncargado.Text.Equals(""))
            {
                tbxNombreEncargado.Text = "Nombre del Encargado";
                tbxNombreEncargado.ForeColor = SystemColors.GrayText;
            }
        }

        private void tbxNombreEncargado_Enter(object sender, EventArgs e)
        {
            if (tbxNombreEncargado.Text.Equals("Nombre del Encargado"))
            {
                tbxNombreEncargado.Text = "";
                tbxNombreEncargado.ForeColor = SystemColors.WindowText;
            }
        }

        private void cbxGenero_Enter(object sender, EventArgs e)
        {
            cbxGenero.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxGenero_Leave(object sender, EventArgs e)
        {
            cbxGenero.ForeColor = SystemColors.WindowText;
            if (!cbxGenero.Text.Equals("Femenino") && !cbxGenero.Text.Equals("Masculino"))
            {
                cbxGenero.DropDownStyle = ComboBoxStyle.DropDown;
                cbxGenero.Text = "Genero";
            }
            lblErrorGenero.Visible = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int cedulaMenor;
            int cedulaEncargado;
            Boolean formularioCorrecto = true;
            if (tbxCedulaMenor.Text.Equals("Cédula del Menor"))
            {
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }
            
            if (!tbxCedulaMenor.Text.Equals("Cédula del Menor")&&!Int32.TryParse(tbxCedulaMenor.Text, out cedulaMenor))
            {
                lblErrorCedulaMenor.Text = "*Debe ingresar sólo números.";
                lblErrorCedulaMenor.Visible = true;
                formularioCorrecto = false;
            }

            if (tbxNombreMenor.Text.Equals("Nombre del Menor"))
            {
                lblErrorNombreMenor.Visible = true;
                formularioCorrecto = false;
            }

            if (!cbxGenero.Text.Equals("Femenino") && !cbxGenero.Text.Equals("Masculino"))
            {
                lblErrorGenero.Visible = true;
                formularioCorrecto = false;
            }

            if (!tbxCedulaEncargado.Text.Equals("Cédula del Encargado") && !Int32.TryParse(tbxCedulaEncargado.Text, out cedulaEncargado))
            {
                lblErrorCedulaEncargado.Text = "*Debe ingresar sólo números.";
                lblErrorCedulaEncargado.Visible = true;
                formularioCorrecto = false;
            }
            if (formularioCorrecto)
            {
                //Insertamor el Niño
                Nino nino = new Nino();
                nino.CedulaNino = Int32.Parse(tbxCedulaMenor.Text);
                nino.NombreNino = tbxNombreMenor.Text;
                nino.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                nino.Edad = CalcularEdad(nino.FechaNacimiento, DateTime.Now);
                nino.Sexo = cbxGenero.SelectedText.Equals("Femenino") ? 'f' : 'm';
                nino.NombreEncargado = tbxNombreEncargado.Text.Equals("Nombre del Encargado") ? "" : tbxNombreEncargado.Text;
                nino.CedulaEncargado = tbxCedulaEncargado.Text.Equals("Cédula del Encargado") ? 0 : Int32.Parse(tbxCedulaEncargado.Text);
               
                try
                {
                    this.ninoBusiness.InsertarNino(nino);
                }
                catch (SqlException ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public int CalcularEdad(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }
    }
}
