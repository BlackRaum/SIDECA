using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIDECA
{
    public partial class ActualizarDepartamento : Form
    {
        DepartamentoBusiness departamentoBusiness;
        Departamento departamento;
        public ActualizarDepartamento(int codigoDepartamento)
        {
            InitializeComponent();
            departamentoBusiness = new DepartamentoBusiness();
            departamento = new Departamento();

            departamento = departamentoBusiness.ObtenerDepartamento(codigoDepartamento);

            //Otorgar datos a los campos
            txtNombreDepartamento.Text = departamento.NombreDepartamento.ToString();
            txtTelefonoDepartamento.Text = departamento.Telefono.ToString();
            txtFaxDepartamento.Text = departamento.Fax.ToString();
            txtCorreoDepartamento.Text = departamento.Correo.ToString();

        }

        private void btnInsertarDeparatmento_Click(object sender, EventArgs e)
        {
            //Verifica si el Nombre esta correcto
            if (txtNombreDepartamento.Text != "" && txtNombreDepartamento.Text != "Nombre del Departamento")
            { //Verifica si el telefono esta correcto
                lbErrorNombreDepto.Visible = false;
                if (txtTelefonoDepartamento.Text != "" && txtTelefonoDepartamento.Text != "Teléfono"&&ValidarNumero(txtTelefonoDepartamento.Text)==true)
                { //Verifica si el fax esta correcto
                    lbErrorTelefonoDepto.Visible = false;
                    if (txtFaxDepartamento.Text != "" && txtFaxDepartamento.Text != "Fax")
                    {//Verifica si el fax esta correcto
                        lbErrorFaxDepto.Visible = false;
                        if (txtCorreoDepartamento.Text != "" && txtCorreoDepartamento.Text != "Correo Electrónico")
                        {
                            lbErrorCorreoDepto.Visible = false;

                            //Crear depto
                            departamento.NombreDepartamento = txtNombreDepartamento.Text;
                            departamento.Telefono = txtTelefonoDepartamento.Text;
                            departamento.Fax = txtFaxDepartamento.Text;
                            departamento.Correo = txtCorreoDepartamento.Text;
                            
                            //Crear business para insertar
                            if (departamentoBusiness.actualizarDepartamento(departamento) == "")
                            {
                                //Por si ocurre algun error
                                ExitoErrorForm exito = new ExitoErrorForm("¡Edición exitosa!", new DepartamentosForm());
                                exito.Show();
                                this.Hide();
                            }
                            else
                            {
                                //Por si ocurre algun error
                                ExitoErrorForm exito = new ExitoErrorForm("¡A ocurrido un error, intentelo de nuevo!", new DepartamentosForm());
                                exito.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            lbErrorCorreoDepto.Visible = true;
                        }
                    }
                    else
                    {
                        lbErrorFaxDepto.Visible = true;
                    }
                }
                else
                {
                    lbErrorTelefonoDepto.Visible = true;
                }

            }
            else
            {
                lbErrorNombreDepto.Visible = true;
            }
        }
        public Boolean ValidarNumero(string text)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(text, @"^[+-]?\d+(?:\.\d+)?$");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepartamentosForm df = new DepartamentosForm();
            df.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfesionalesForm pf = new ProfesionalesForm();
            pf.Show();
        }
    }
}
