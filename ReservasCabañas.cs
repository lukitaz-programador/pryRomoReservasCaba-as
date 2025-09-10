namespace pryRomoReservasCabañas
{
    public partial class frmReservasCabañas : Form
    {
        public frmReservasCabañas()
        {
            InitializeComponent();
        }

        int vPrecioPersona;
        int vPrecioCabaña;
        int vPrecioFinal;
        decimal vDescuento=0.0m;

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grbTipo.Text == "")
            {
                lstPersonas.Enabled = false;
            }
            else
            {
                lstPersonas.Enabled = true;
            }

            if (grbTipo.Text == "Cabaña A")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add("1");
                lstPersonas.Items.Add("2");
                lstPersonas.Items.Add("3");
                lstPersonas.Items.Add("4");
                vPrecioCabaña = 20;
            }

            if (grbTipo.Text == "Cabaña B")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add("1");
                lstPersonas.Items.Add("2");
                lstPersonas.Items.Add("3");
                lstPersonas.Items.Add("4");
                lstPersonas.Items.Add("5");
                lstPersonas.Items.Add("6");
                lstPersonas.Items.Add("7");
                lstPersonas.Items.Add("8");
                vPrecioCabaña = 32;
            }
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonas.Text == "")
            {
                txtDias.Enabled = false;
            }
            else
            {
                txtDias.Enabled = true;
            }
            vPrecioPersona = Convert.ToInt32(lstPersonas.Text);
        }

        private void lstTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstTarjetas.Text)
            {
                case "Card Red":
                    vDescuento = 0.1m;
                    break;

                case "Card Green":
                    vDescuento = 0.15m;
                    break;

                case "Card Blue":
                    vDescuento = 0.2m;
                    break;

                default:
                    vDescuento = 0.0m;
                    break;
            }

        }
    }
}
