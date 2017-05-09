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
    public partial class EliminarDepartamentoForm : Form
    {
        DepartamentoBusiness departamentoBusiness;
        LinkedList<Departamento> listaDepartamentos;
        private int codigoOficina;
        public EliminarDepartamentoForm(int codigoOficina)
        {
            InitializeComponent();
            departamentoBusiness = new DepartamentoBusiness();
            this.codigoOficina = codigoOficina;
            listaDepartamentos = departamentoBusiness.ObtenerDepartamentobyOficina(codigoOficina);

            BindingSource sourceData = new BindingSource();
            sourceData.DataSource = listaDepartamentos;
            cbDepartamentos.DataSource = null;

            //asignas datasource a combo
            cbDepartamentos.DataSource = sourceData;
            //indicar cual valor tiene cada item
            cbDepartamentos.ValueMember = "codigoDepartamento";
            cbDepartamentos.DisplayMember = "NombreDepartamento";
            


           
           


        }

        private void btnEliminarDeparatmento_Click(object sender, EventArgs e)
        {
           
            int codigoDepartamento = Int32.Parse( cbDepartamentos.SelectedValue.ToString());
            string mensaje=departamentoBusiness.eliminarDepartamento(codigoDepartamento);
            if (mensaje == "")
            {
               
                ExitoErrorForm ed = new ExitoErrorForm("¡Borrado Exitoso!", new DepartamentosForm());
                ed.Show();
                this.Hide();
            }
            else
            {
                ExitoErrorForm ed = new ExitoErrorForm("¡A ocurrido un error,intentelo de nuevo!", new DepartamentosForm());
                ed.Show();
                this.Hide();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            DepartamentosForm df = new DepartamentosForm();
            df.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            ProfesionalesForm pf = new ProfesionalesForm();
            pf.Show();
            this.Hide();
        }
    }
}
