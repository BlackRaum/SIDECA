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
    public partial class BuscarUsuarioForm : Form
    {
        private UsuarioBusiness usuarioBusiness;

        private int tipo;
        public BuscarUsuarioForm(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            if (tipo == 1)
            {
                lbBuscarUsuario.Text = "Editar Usuario";
                btContinuar.Text = "Editar";
            }
            else
            {
                lbBuscarUsuario.Text = "Eliminar Usuario";
                btContinuar.Text = "Eliminar";
            }

            usuarioBusiness = new UsuarioBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }    

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text!=null)
            {
                LinkedList<Usuario> usuarios=  usuarioBusiness.ObtenerUsuarios(tbNombreUsuario.Text);

                tbNombreUsuario.Visible = false;
                BindingSource sourceData = new BindingSource();
                sourceData.DataSource = usuarios;
                cbUsuariosNombre.DataSource = null;

                //Asignar la propiedad DataSource
                cbUsuariosNombre.DataSource = sourceData;

                cbUsuariosNombre.Visible = true;
                lbBuscarUsuario2.Text = "Seleccione el usuario a editar";
                btBuscar.Visible = false;
                btContinuar.Visible = true;
                //Indicar qué valor tendrá cada ítem
                cbUsuariosNombre.ValueMember = "NombreUsuario";//aqui va el id oculto de item 
                //Indicar qué propiedad se verá en la lista
                cbUsuariosNombre.DisplayMember = "NombreUsuario";//aqui el valor q se va a mostrar
            } else
            {
                lbNombre.Visible = true;
            }
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            string nickName = cbUsuariosNombre.SelectedValue.ToString();
            
            if (tipo == 1)
            {
               
                EditarUsuarioForm editar = new EditarUsuarioForm(nickName);
                editar.Show();
            }
            else
            {
                usuarioBusiness.EliminarUsuario(nickName);
                ExitoErrorForm exito = new ExitoErrorForm("¡Borrado Exitoso!", new UsuarioForm());
                exito.Show();
                this.Hide();

            }
        }
    }
}
