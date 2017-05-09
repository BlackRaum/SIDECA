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
    public partial class ProfesionalesForm : Form
    {
        public ProfesionalesForm()
        {
            InitializeComponent();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            BuscarOficinaDepartamentoForm buscar = new BuscarOficinaDepartamentoForm(3);
            buscar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BuscarProfesionalForm ip = new BuscarProfesionalForm();
            ip.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BuscarOficinaDepartamentoForm ep = new BuscarOficinaDepartamentoForm(4);
            ep.Show();
            this.Hide();
        }
    }
}
