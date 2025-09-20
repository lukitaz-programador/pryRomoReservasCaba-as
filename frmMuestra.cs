using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRomoReservasCabañas
{
    public partial class frmMuestra : Form
    {
        public frmMuestra()
        {
            InitializeComponent();
        }

        private void frmMuestra_Load(object sender, EventArgs e)
        {
            decimal preciofinal = frmReservasCabañas.PRECIO;
            lblMensaje.Text = "Total = US$ " + preciofinal;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmReservasCabañas frmReservasCabañas = new frmReservasCabañas();
            Hide();
            frmReservasCabañas.ShowDialog();
        }
    }
}
