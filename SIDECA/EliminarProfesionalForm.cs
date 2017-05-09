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
    public partial class EliminarProfesionalForm : Form
    {
        DepartamentoBusiness departamentoBusiness;
        ProfesionalBusiness profesionalBusiness;
        LinkedList<Departamento> listaDepartamentos;
        Profesional profesional;
        int cedulaProfesional;

        public EliminarProfesionalForm(int cedulaProfesional)
        {
            InitializeComponent();

            //cargar datos en text
            profesionalBusiness = new ProfesionalBusiness();
            profesional = new Profesional();
            profesional = profesionalBusiness.ObtenerProfesional(cedulaProfesional);

            this.cedulaProfesional = cedulaProfesional;

            txtNombreProfesional.Text = profesional.NombreCompleto.ToString();
            txtEspecialidadProfesional.Text = profesional.Especialidad.ToString();
            txtTelefonoProfesional.Text = profesional.TelefonoCelular.ToString();
            txtCorreoProfesional.Text = profesional.Correo.ToString();
        }

        private void btnEditarProfesional_Click(object sender, EventArgs e)
        {
            if (txtNombreProfesional.Text != "" && txtNombreProfesional.Text != "Nombre")
            { //Verifica si el telefono esta correcto
                lbErrorNombre.Visible = false;
                if (txtEspecialidadProfesional.Text != "" && txtEspecialidadProfesional.Text != "Especialidad")
                {
                    lbErrorEspecialidad.Visible = false;
                    if (txtTelefonoProfesional.Text != "" && txtTelefonoProfesional.Text != "Teléfono Celular" && ValidarNumero(txtTelefonoProfesional.Text) == true)
                    {
                        lbErrorTelefono.Visible = false;
                        if (txtCorreoProfesional.Text != "" && txtCorreoProfesional.Text != "Correo Electrónico")
                        {
                            //Crear Profesional
                            Profesional profe = new Profesional();
                            profe.Cedula = cedulaProfesional;
                            profe.NombreCompleto = txtNombreProfesional.Text;
                            profe.Especialidad = txtEspecialidadProfesional.Text;
                            profe.TelefonoCelular = txtTelefonoProfesional.Text;
                            profe.Correo = txtCorreoProfesional.Text;

                            //Crear business para insertar
                            ProfesionalBusiness profesionalBusiness = new ProfesionalBusiness();
                            if (profesionalBusiness.eliminarProfesional(cedulaProfesional)=="")
                            {
                                MessageBox.Show("Departamento ingresado correctamente");
                                txtNombreProfesional.Text = "";
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
                lbErrorNombre.Visible = true;
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
