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
    public partial class DepartamentosForm : Form
    {
        public DepartamentosForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            DepartamentosForm df = new DepartamentosForm();
            df.Show();
            this.Hide();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            BuscarOficinaDepartamentoForm db = new BuscarOficinaDepartamentoForm(1);
            db.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BuscarOficinaDepartamentoForm db = new BuscarOficinaDepartamentoForm(2);
            db.Show();
            this.Hide();
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            
            InsertarDepartamentoForm id = new InsertarDepartamentoForm();
            id.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            ProfesionalesForm pf = new ProfesionalesForm();
            pf.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            UsuarioForm us = new UsuarioForm();
            us.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            OficinaForm of = new OficinaForm();
            of.Show();
            this.Hide();
        }
    }
}
