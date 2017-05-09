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
    public partial class EditarOficinaForm : Form
    {
        private OficinaBusiness oficinaBusiness;
        private int codigoOficina;
        private Oficina oficina;
        public EditarOficinaForm(int codigoOficina)
        {
            InitializeComponent();
            this.codigoOficina = codigoOficina;
            oficinaBusiness = new OficinaBusiness("Data Source=163.178.173.148;Initial Catalog=SidecaBD;User ID=lenguajes;Password=lenguajes");
            inicioComponentes();


        }
        private void inicioComponentes()
        {
            oficina = oficinaBusiness.ObtenerOficina(codigoOficina);

            tbProvincia.Text = oficina.Provincia;
            tbCanton.Text = oficina.Canton;
            tbDistrito.Text = oficina.Distrito;
            tbTelefono.Text = oficina.Telefono;
            tbFax.Text = oficina.Fax;
            tbCorreo.Text = oficina.Correo;

        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {

        }

        private void btContinuar_Click(object sender, EventArgs e)
        {
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
                oficinaBusiness.ActualizarOficina(oficina);
                ExitoErrorForm exito = new ExitoErrorForm("¡Edición Exitosa!", new OficinaForm());
                exito.Show();
                this.Hide();
            }
        }
    }
}
