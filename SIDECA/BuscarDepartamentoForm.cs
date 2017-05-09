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
    public partial class BuscarDepartamentoForm : Form
    {
        DepartamentoBusiness departamentoBusiness;
        LinkedList<Departamento> listaDepartamentos;

        public BuscarDepartamentoForm(int codigoOficina)
        {
            InitializeComponent();

            departamentoBusiness = new DepartamentoBusiness();
            listaDepartamentos = departamentoBusiness.ObtenerDepartamentobyOficina(codigoOficina);

            BindingSource sourceData = new BindingSource();
            sourceData.DataSource = listaDepartamentos;
            cbDepartamentosBuscar.DataSource = null;

            //asignas datasource a combo
            cbDepartamentosBuscar.DataSource = sourceData;
            //indicar cual valor tiene cada item
            cbDepartamentosBuscar.ValueMember = "codigoDepartamento";
            cbDepartamentosBuscar.DisplayMember = "NombreDepartamento";



        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            int codigoDepartamento = Int32.Parse(cbDepartamentosBuscar.SelectedValue.ToString());
            ActualizarDepartamento actualizar = new ActualizarDepartamento(codigoDepartamento);
            this.Hide();
            actualizar.Show();
            
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
