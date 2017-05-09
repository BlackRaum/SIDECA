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
    public partial class InsertarProfesionalForm : Form
    {
        DepartamentoBusiness departamentoBusiness;
        LinkedList<Departamento> listaDepartamentos;

        public InsertarProfesionalForm(int codigoOficina)
        {
            InitializeComponent();

            departamentoBusiness = new DepartamentoBusiness();
            listaDepartamentos = departamentoBusiness.ObtenerDepartamentobyOficina(codigoOficina);

            BindingSource sourceData = new BindingSource();
            sourceData.DataSource = listaDepartamentos;
            cbDepartamentosProfesional.DataSource = null;

            //asignas datasource a combo
            cbDepartamentosProfesional.DataSource = sourceData;
            //indicar cual valor tiene cada item
            cbDepartamentosProfesional.ValueMember = "codigoDepartamento";
            cbDepartamentosProfesional.DisplayMember = "NombreDepartamento";
        }

        private void btnInsertarDeparatmento_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text!=""&&txtCedula.Text!="Cédula" && ValidarNumero(txtCedula.Text)==true) {
                //Verifica si el Nombre esta correcto
                lbErrorCedula.Visible = false;
            if (txtNombreProfesional.Text != "" && txtNombreProfesional.Text != "Nombre")
            { //Verifica si el telefono esta correcto
                lbErrorNombre.Visible = false;
                if (txtPrimerApellido.Text != "" && txtPrimerApellido.Text != "Primer Apellido")
                { //Verifica si el fax esta correcto
                    lbErrorApellido1.Visible = false;
                    if (txtsegundoApellido.Text != "" && txtsegundoApellido.Text != "Segundo Apellido")
                    {//Verifica si el fax esta correcto
                        lbErrorApellido2.Visible = false;
                        if (txtEspecialidadProfesional.Text != "" && txtEspecialidadProfesional.Text != "Especialidad")
                        {lbErrorEspecialidad.Visible = false;
                            if (txtTelefonoProfesional.Text!="" && txtTelefonoProfesional.Text!="Teléfono Celular" && ValidarNumero(txtTelefonoProfesional.Text) == true)
                            {
                                lbErrorTelefono.Visible = false;
                                if (txtCorreoProfesional.Text!=""&&txtCorreoProfesional.Text!="Correo Electrónico")
                                {
                                    //Crear Profesional
                                    Profesional profesional = new Profesional();
                                    profesional.Cedula = Int32.Parse(txtCedula.Text);
                                    profesional.NombreCompleto = txtNombreProfesional.Text+" "+txtPrimerApellido.Text+" "+txtsegundoApellido.Text;
                                    profesional.Especialidad = txtEspecialidadProfesional.Text;
                                    profesional.TelefonoCelular = txtTelefonoProfesional.Text;
                                    profesional.Correo = txtCorreoProfesional.Text;
                                    int codigoDepartamento = Int32.Parse(cbDepartamentosProfesional.SelectedValue.ToString());

                                    //Crear business para insertar
                                    ProfesionalBusiness profesionalBusiness = new ProfesionalBusiness();
                                   if( profesionalBusiness.insertarProfesional(profesional,codigoDepartamento)=="")
                                    {
                                        MessageBox.Show("Departamento ingresado correctamente");
                                        txtNombreProfesional.Text = "";
                                        txtCedula.Text = "";
                                        txtPrimerApellido.Text = "";
                                        txtsegundoApellido.Text = "";
                                        txtEspecialidadProfesional.Text = "";
                                        txtTelefonoProfesional.Text = "";
                                        txtCorreoProfesional.Text = "";

                                    }
                                    else
                                    {
                                        //Por si ocurre algun error
                                        MessageBox.Show("ERROR");

                                    }
                                }
                                else
                                {
                                    lbErrorCorreo.Visible = true;
                                }
                            }
                            else
                            {
                                lbErrorTelefono.Visible = true;
                            }                           
                        }
                        else
                        {
                            lbErrorEspecialidad.Visible = true;
                        }
                    }
                    else
                    {
                        lbErrorApellido2.Visible = true;
                    }
                }
                else
                {
                    lbErrorApellido1.Visible = true;
                }

            }
            else
            {
                lbErrorNombre.Visible = true;
            }
            }
            else
            {
                lbErrorCedula.Visible = true;
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

