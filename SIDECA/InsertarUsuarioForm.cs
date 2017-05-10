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
    public partial class InsertarUsuarioForm : Form
    {
        private UsuarioBusiness usuarioBusiness;
        public InsertarUsuarioForm()
        {
            InitializeComponent();
            usuarioBusiness= new UsuarioBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void InsertarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (tbNombreUsuario.Text != null)
            {
                usuario.NombreUsuario = tbNombreUsuario.Text;
            }
            else
            {
                lbNombre.Visible = true;
            }
            if (tbContrasena.Text != null)
            {
                usuario.Contrasena = tbContrasena.Text;
            }
            else
            {
                lbContrasena.Visible = true;
            }

            if (tbNombreUsuario.Text != null && tbContrasena.Text != null)
            {
                usuarioBusiness.InsertarUsuario(usuario);
            }
        }
        private void tbContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbContrasena.PasswordChar = '*';
        }
    }
}
