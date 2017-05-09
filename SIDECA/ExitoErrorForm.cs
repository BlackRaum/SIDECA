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
    public partial class ExitoErrorForm : Form
    {
        Form destino;
        public ExitoErrorForm(string mensaje, Form origen)
        {
            InitializeComponent();
            lbMensaje.Text = mensaje;
            destino = origen;
        }
    
        private void btContinuar_Click(object sender, EventArgs e)
        {
            destino.Show();
            this.Hide();
        }
    }
}
