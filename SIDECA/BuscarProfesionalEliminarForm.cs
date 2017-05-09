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
    public partial class BuscarProfesionalEliminarForm : Form
    {
        ProfesionalBusiness profesionalBusiness;
        LinkedList<Profesional> listaProfesionales;
        public BuscarProfesionalEliminarForm()
        {
            InitializeComponent();
            profesionalBusiness = new ProfesionalBusiness();
        }

        private void btnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            if (txtNombreProfesional.Text != "")
            {
                listaProfesionales = profesionalBusiness.ObtenerProfesionalbyNombre(txtNombreProfesional.Text);
                if (listaProfesionales.Any())
                {
                    this.Hide();
                    SeleccionarProfesionalEliminarForm sd = new SeleccionarProfesionalEliminarForm(txtNombreProfesional.Text);
                    sd.Show();
                }
                else
                {
                    lbErrorNoEncontrado.Visible = true;
                }

            }
            else
            {
                lbErrorNombre.Visible = true;
            }
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
