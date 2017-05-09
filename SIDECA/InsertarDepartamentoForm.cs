using ClassLibrary2.Business;
using ClassLibrary2.Domain;
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
    public partial class InsertarDepartamentoForm : Form
    {
        private OficinaBusiness oficinaBusiness;
        public InsertarDepartamentoForm()
        {
            InitializeComponent();
            oficinaBusiness = new OficinaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
            InicioComponentes();
        }
        private void InicioComponentes()
        {
            LinkedList<Oficina> oficinas = oficinaBusiness.ObtenerOficinasTodas();

          
            BindingSource sourceData = new BindingSource();
            sourceData.DataSource = oficinas;
            cbOficinas.DataSource = null;

            //Asignar la propiedad DataSource
            cbOficinas.DataSource = sourceData;         
            //Indicar qué valor tendrá cada ítem
            cbOficinas.ValueMember = "CodigoOficina";//aqui va el id oculto de item 
                                                     //Indicar qué propiedad se verá en la lista
            cbOficinas.DisplayMember = "Ubicacion";//aqui el valor q se va a mostrar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verifica si el Nombre esta correcto
            if(txtNombreDepartamento.Text != "" && txtNombreDepartamento.Text != "Nombre del Departamento")
            { //Verifica si el telefono esta correcto
                lbErrorNombreDepto.Visible = false;
                if (txtTelefonoDepartamento.Text != "" && txtTelefonoDepartamento.Text != "Teléfono"&&ValidarNumero(txtTelefonoDepartamento.Text)==true)
                { //Verifica si el fax esta correcto
                    lbErrorTelefonoDepto.Visible = false;
                    if (txtFaxDepartamento.Text != "" && txtFaxDepartamento.Text != "Fax")
                    {//Verifica si el fax esta correcto
                        lbErrorFaxDepto.Visible = false;
                        if (txtCorreoDepartamento.Text !="" && txtCorreoDepartamento.Text !="Correo Electrónico")
                        {
                            lbErrorCorreoDepto.Visible = false;
                            
                            //Crear depto
                            Departamento departamento= new Departamento();
                            departamento.NombreDepartamento = txtNombreDepartamento.Text;
                            departamento.Telefono = txtTelefonoDepartamento.Text;
                            departamento.Fax = txtFaxDepartamento.Text;
                            departamento.Correo = txtCorreoDepartamento.Text;
                            departamento.CodigoOficina = Int32.Parse(cbOficinas.SelectedValue.ToString());
                            

                            //Crear business para insertar
                            DepartamentoBusiness departamentoBusiness = new DepartamentoBusiness();
                            if(departamentoBusiness.insertarDepartamento(departamento) == "")
                            {
                                ExitoErrorForm exito = new ExitoErrorForm("¡Insertado Exitoso!", new DepartamentosForm());
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbErrorFaxDepto_Click(object sender, EventArgs e)
        {

        }

        private void lbErrorNombreDepto_Click(object sender, EventArgs e)
        {

        }

        private void lbErrorCorreoDepto_Click(object sender, EventArgs e)
        {

        }

        private void txtOficinaDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreoDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFaxDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
