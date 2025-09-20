namespace pryRomoReservasCabañas
{
    public partial class frmReservasCabañas : Form
    {
        public frmReservasCabañas()
        {
            InitializeComponent();
        }

        //Declaracion de variables globales
        bool TIPOA = false;
        bool TIPOB = false;
        bool COCINA = false;
        bool HELADERA = false;
        bool TELEVISOR = false;
        public static decimal PRECIO = 0;
        int i = 1;

        //La fase me va a servir para poder habilitar en cantidad 
        bool FASE = false;

        //Inicializamos valores predeterminados para cada carga de reserva
        private void frmReservasCabañas_Load(object sender, EventArgs e)
        {
            // Combo Tipo de cabaña
            lstTipo.Items.Clear();
            lstTipo.Items.Add("Tipo A");
            lstTipo.Items.Add("Tipo B");
            lstTipo.SelectedIndex = -1;

            // Combo tarjetas
            lstTarjetas.Items.Clear();
            lstTarjetas.Items.Add("Card Red");
            lstTarjetas.Items.Add("Card Green");
            lstTarjetas.Items.Add("Card Blue");

            // Valores iniciales de los textos
            mtbDias.Text = "1";
            txtNombre.Text = "";
            mtbTelefono.Text = "";

            // Valores iniciales de los checks
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;

            // Valores iniciales de radios
            optEfectivo.Checked = true;
            optTarjeta.Checked = false;

            // Botón aceptar deshabilitado al inicio
            btnAceptar.Enabled = false;

            //i vuelve a 1
            i = 1;

        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comprobamos que tipo se seleción y confirmamos en la varaible bool
            if (lstTipo.Text == "Tipo A")
            {
                TIPOA = true;
            }
            else
            {
                TIPOA = false;
            }

            if (lstTipo.Text == "Tipo B")
            {
                TIPOB = true;
            }
            else
            {
                TIPOB = false;
            }

            //Confirma que se haya llenado el campo de tipo
            if (lstTipo.Text == "")
            {
                lstPersonas.Enabled = false;
            }
            else
            {
                lstPersonas.Enabled = true;
            }

            //Completa las opciones de lstPersonas
            if (TIPOA)
            {
                i = 1;
                lstPersonas.Items.Clear();
                while (i <= 4)
                {
                    lstPersonas.Items.Add(i);
                    i++;
                }
            }
            if (TIPOB)
            {
                i = 1;
                lstPersonas.Items.Clear();
                while (i <= 8)
                {
                    lstPersonas.Items.Add(i);
                    i++;
                }
            }

        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Confirma que se haya llenado el campo de personas
            if (lstPersonas.Text == "")
            {
                mtbDias.Enabled = false;
            }
            else
            {
                mtbDias.Enabled = true;
                FASE = true;
            }


            //Habilita los campso restantes
            if (FASE)
            {
                chkCocina.Enabled = true;
                chkHeladera.Enabled = true;
                chkTelevisor.Enabled = true;
                optEfectivo.Enabled = true;
                optTarjeta.Enabled = true;
                txtNombre.Enabled = true;
            }
        }

        private void mtbDias_TextChanged(object sender, EventArgs e)
        {
            if (mtbDias.Text == "0")
            {
                mtbDias.Text = "1";
            }
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                lstTarjetas.Enabled = true;
            }
            else
            {
                lstTarjetas.Enabled = false;
            }
        }

        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                mtbTelefono.Enabled = false;
            }
            else
            {
                mtbTelefono.Enabled = true;
            }
        }

        private void mtbTelefono_TextChanged(object sender, EventArgs e)
        {
            if (mtbTelefono.MaskCompleted)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PRECIO = 0;

            //Cálculo de precio
            switch (lstTipo.Text)
            {
                case "Tipo A":
                    PRECIO = 20;
                    break;

                case "Tipo B":
                    PRECIO = 34;
                    break;
            }

            if (chkCocina.Checked)
            {
                PRECIO += 1;
            }
            if (chkHeladera.Checked)
            {
                PRECIO += 1.5m;
            }
            if (chkTelevisor.Checked)
            {
                PRECIO += 2;
            }

            //Guardar como int las personas
            int personas = Convert.ToInt32(lstPersonas.SelectedItem);

            //Guardar como int los días
            int dias = Convert.ToInt32(mtbDias.Text);

            //Precio Final
            switch (lstTarjetas.Text)
            {
                case "Red Card":
                    PRECIO = (PRECIO + personas) * dias * 1.1m;
                    break;

                case "Green Card":
                    PRECIO = (PRECIO + personas) * dias * 1.2m;
                    break;

                case "Blue Card":
                    PRECIO = (PRECIO + personas) * dias * 1.2m;
                    break;
            }

            PRECIO = (PRECIO + personas) * dias;

            frmMuestra frmMuestra = new frmMuestra();
            Hide();
            frmMuestra.ShowDialog();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        //Inicializamos valores predeterminados para cada carga de reserva

            // Combo Tipo de cabaña
            lstTipo.Items.Clear();
            lstTipo.Items.Add("Tipo A");
            lstTipo.Items.Add("Tipo B");
            lstTipo.SelectedIndex = -1;

            //Personas 
            lstPersonas.SelectedIndex = -1;

            // Combo tarjetas
            lstTarjetas.Items.Clear();
            lstTarjetas.Items.Add("Card Red");
            lstTarjetas.Items.Add("Card Green");
            lstTarjetas.Items.Add("Card Blue");

            // Valores iniciales de los textos
            mtbDias.Text = "1";
            txtNombre.Text = "";
            mtbTelefono.Text = "";

            // Valores iniciales de los checks
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTelevisor.Checked = false;

            // Valores iniciales de radios
            optEfectivo.Checked = true;
            optTarjeta.Checked = false;

            // Botón aceptar deshabilitado al inicio
            btnAceptar.Enabled = false;

            //i vuelve a 1
            i = 1;
        }
    }
}
