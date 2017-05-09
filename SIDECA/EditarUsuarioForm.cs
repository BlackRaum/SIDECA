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
    public partial class EditarUsuarioForm : Form
    {
        private UsuarioBusiness usuarioBusiness;
        private string nickName;
        private Usuario usuario;
        public EditarUsuarioForm(string nickName)
        {
            InitializeComponent();
            this.nickName = nickName;
            usuarioBusiness = new UsuarioBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
            inicioComponentes();


        }
        private void inicioComponentes()
        {
            usuario = usuarioBusiness.ObtenerUsuario(nickName);

            tbNombreUsuario.Text = usuario.NombreUsuario;
            tbContrasena.Text = usuario.Contrasena;
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            usuario.NombreUsuario = tbNombreUsuario.Text;
            usuario.Contrasena = tbContrasena.Text;

            usuarioBusiness.ActualizarUsuario(usuario);
        }
    }
}
