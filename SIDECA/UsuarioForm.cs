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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            InsertarUsuarioForm insertar = new InsertarUsuarioForm();
            insertar.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarUsuarioForm buscar = new BuscarUsuarioForm(1);
            buscar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarUsuarioForm buscar = new BuscarUsuarioForm(2);
            buscar.Show();
            this.Hide();
        }
    }
}
