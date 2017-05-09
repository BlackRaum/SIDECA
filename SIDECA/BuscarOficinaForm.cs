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
    public partial class BuscarOficinaForm : Form
    {
        private OficinaBusiness oficinaBusiness;

        private int tipo;
        public BuscarOficinaForm(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            if (tipo == 1)
            {
                lbBuscarOficina.Text = "Editar Oficina";
                btContinuar.Text = "Editar";
            }
            else
            {
                lbBuscarOficina.Text = "Eliminar Oficina";
                btContinuar.Text = "Eliminar";
            }

            oficinaBusiness = new OficinaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");

        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }    

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text!=null)
            {
                LinkedList<Oficina> oficinas =  oficinaBusiness.ObtenerOficinas(tbNombreUsuario.Text);

                tbNombreUsuario.Visible = false;
                BindingSource sourceData = new BindingSource();
                sourceData.DataSource = oficinas;
                cbOficinas.DataSource = null;

                //Asignar la propiedad DataSource
                cbOficinas.DataSource = sourceData;

                cbOficinas.Visible = true;
                lboOficina2.Text = "Seleccione la oficina a editar";
                btBuscar.Visible = false;
                btContinuar.Visible = true;
                //Indicar qué valor tendrá cada ítem
                cbOficinas.ValueMember = "CodigoOficina";//aqui va el id oculto de item 
                //Indicar qué propiedad se verá en la lista
                cbOficinas.DisplayMember = "Ubicacion";//aqui el valor q se va a mostrar
            } else
            {
                lbNombre.Visible = true;
            }
        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
            int CodigoOficina = Int32.Parse(cbOficinas.SelectedValue.ToString());
            
            if (tipo == 1)
            {
               
                EditarOficinaForm editar = new EditarOficinaForm(CodigoOficina);
                editar.Show();
                this.Hide();
            }
            else
            {
                oficinaBusiness.EliminarOficina(CodigoOficina);
                ExitoErrorForm exito = new ExitoErrorForm("¡Borrado Exitoso!", new OficinaForm());
                exito.Show();
                this.Hide();

            }
        }
    }
}
