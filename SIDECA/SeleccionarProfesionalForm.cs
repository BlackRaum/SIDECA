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
    public partial class SeleccionarProfesionalForm : Form
    {
        ProfesionalBusiness profesionalBusiness;
        LinkedList<Profesional> listaProfesionales;

        public SeleccionarProfesionalForm(string nombreProfesional)
        {
            InitializeComponent();
            profesionalBusiness = new ProfesionalBusiness();

            listaProfesionales = profesionalBusiness.ObtenerProfesionalbyNombre(nombreProfesional);

            BindingSource sourceData = new BindingSource();
            sourceData.DataSource = listaProfesionales;
            cbProfesionalesBuscar.DataSource = null;

            //asignas datasource a combo
            cbProfesionalesBuscar.DataSource = sourceData;
            //indicar cual valor tiene cada item
            cbProfesionalesBuscar.ValueMember = "Cedula";
            cbProfesionalesBuscar.DisplayMember = "NombreCompleto";

        }

        private void btnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            int codigoProfesional = Int32.Parse(cbProfesionalesBuscar.SelectedValue.ToString());
            ActualizarProfesional ap = new ActualizarProfesional(codigoProfesional,2);
            ap.Show();
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
