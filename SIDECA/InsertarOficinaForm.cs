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
    public partial class InsertarOficinaForm : Form
    {
        private OficinaBusiness oficinaBusiness;
        public InsertarOficinaForm()
        {
            InitializeComponent();
            oficinaBusiness = new OficinaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void InsertarUsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            Oficina oficina = new Oficina();
            int contador = 0;
            if (tbProvincia.Text != null)
            {
                oficina.Provincia = tbProvincia.Text;
                contador++;
            }
            else
            {
                lbProvincia.Visible = true;
            }
            if (tbCanton.Text != null)
            {
                oficina.Canton = tbCanton.Text;
                contador++;
            }
            else
            {
                lbCanton.Visible = true;
            }

            if (tbDistrito.Text != null)
            {
                oficina.Distrito = tbDistrito.Text;
                contador++;
            }
            else
            {
                lbDistrito.Visible = true;
            }
            if (tbTelefono.Text != null)
            {
                oficina.Telefono = tbTelefono.Text;
                contador++;
            }
            else
            {
                lbTelefono.Visible = true;
            }
            if (tbFax.Text != null)
            {
                oficina.Fax = tbFax.Text;
                contador++;
            }
            else
            {
                lbFax.Visible = true;
            }

            if (tbCorreo.Text != null)
            {
                oficina.Correo = tbCorreo.Text;
                contador++;
            }
            else
            {
                lbCorreo.Visible = true;
            }

            if (contador == 6)
            {
                oficinaBusiness.InsertarOficina(oficina);
                ExitoErrorForm exito = new ExitoErrorForm("¡Inserción Exitosa!", new OficinaForm());
                exito.Show();
                this.Hide();
            }
        }
        
    }
}
