namespace pryRomoReservasCabañas
{
    partial class frmReservasCabañas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbTipo = new GroupBox();
            txtDias = new TextBox();
            lblDiass = new Label();
            lstPersonas = new ComboBox();
            lblPersonass = new Label();
            lstTipo = new ComboBox();
            lblTipoo = new Label();
            grbAdicionales = new GroupBox();
            chkTelevisor = new CheckBox();
            chkHeladera = new CheckBox();
            chkCocina = new CheckBox();
            grbFormaPago = new GroupBox();
            lstTarjetas = new ComboBox();
            lblTarjetaa = new Label();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            grbTitularReserva = new GroupBox();
            txtTelefonoo = new TextBox();
            txtNombree = new TextBox();
            lblTelefonoo = new Label();
            lblNombree = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            grbTipo.SuspendLayout();
            grbAdicionales.SuspendLayout();
            grbFormaPago.SuspendLayout();
            grbTitularReserva.SuspendLayout();
            SuspendLayout();
            // 
            // grbTipo
            // 
            grbTipo.Controls.Add(txtDias);
            grbTipo.Controls.Add(lblDiass);
            grbTipo.Controls.Add(lstPersonas);
            grbTipo.Controls.Add(lblPersonass);
            grbTipo.Controls.Add(lstTipo);
            grbTipo.Controls.Add(lblTipoo);
            grbTipo.Location = new Point(12, 12);
            grbTipo.Name = "grbTipo";
            grbTipo.Size = new Size(515, 83);
            grbTipo.TabIndex = 0;
            grbTipo.TabStop = false;
            grbTipo.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(413, 36);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(86, 23);
            txtDias.TabIndex = 6;
            // 
            // lblDiass
            // 
            lblDiass.AutoSize = true;
            lblDiass.Location = new Point(375, 39);
            lblDiass.Name = "lblDiass";
            lblDiass.Size = new Size(32, 15);
            lblDiass.TabIndex = 5;
            lblDiass.Text = "Días:";
            // 
            // lstPersonas
            // 
            lstPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            lstPersonas.FormattingEnabled = true;
            lstPersonas.Location = new Point(269, 36);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(71, 23);
            lstPersonas.TabIndex = 3;
            // 
            // lblPersonass
            // 
            lblPersonass.AutoSize = true;
            lblPersonass.Location = new Point(206, 39);
            lblPersonass.Name = "lblPersonass";
            lblPersonass.Size = new Size(57, 15);
            lblPersonass.TabIndex = 2;
            lblPersonass.Text = "Personas:";
            // 
            // lstTipo
            // 
            lstTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstTipo.FormattingEnabled = true;
            lstTipo.Location = new Point(60, 36);
            lstTipo.Name = "lstTipo";
            lstTipo.Size = new Size(115, 23);
            lstTipo.TabIndex = 1;
            // 
            // lblTipoo
            // 
            lblTipoo.AutoSize = true;
            lblTipoo.Location = new Point(21, 39);
            lblTipoo.Name = "lblTipoo";
            lblTipoo.Size = new Size(33, 15);
            lblTipoo.TabIndex = 0;
            lblTipoo.Text = "Tipo:";
            // 
            // grbAdicionales
            // 
            grbAdicionales.Controls.Add(chkTelevisor);
            grbAdicionales.Controls.Add(chkHeladera);
            grbAdicionales.Controls.Add(chkCocina);
            grbAdicionales.Location = new Point(12, 101);
            grbAdicionales.Name = "grbAdicionales";
            grbAdicionales.Size = new Size(158, 133);
            grbAdicionales.TabIndex = 1;
            grbAdicionales.TabStop = false;
            grbAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            chkTelevisor.AutoSize = true;
            chkTelevisor.Location = new Point(28, 92);
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.Size = new Size(71, 19);
            chkTelevisor.TabIndex = 2;
            chkTelevisor.Text = "Televisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            chkHeladera.AutoSize = true;
            chkHeladera.Location = new Point(28, 61);
            chkHeladera.Name = "chkHeladera";
            chkHeladera.Size = new Size(73, 19);
            chkHeladera.TabIndex = 1;
            chkHeladera.Text = "Heladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            chkCocina.AutoSize = true;
            chkCocina.Location = new Point(28, 31);
            chkCocina.Name = "chkCocina";
            chkCocina.Size = new Size(63, 19);
            chkCocina.TabIndex = 0;
            chkCocina.Text = "Cocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // grbFormaPago
            // 
            grbFormaPago.Controls.Add(lstTarjetas);
            grbFormaPago.Controls.Add(lblTarjetaa);
            grbFormaPago.Controls.Add(rbtTarjeta);
            grbFormaPago.Controls.Add(rbtEfectivo);
            grbFormaPago.Location = new Point(176, 101);
            grbFormaPago.Name = "grbFormaPago";
            grbFormaPago.Size = new Size(351, 133);
            grbFormaPago.TabIndex = 2;
            grbFormaPago.TabStop = false;
            grbFormaPago.Text = "Forma de Pago";
            // 
            // lstTarjetas
            // 
            lstTarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
            lstTarjetas.FormattingEnabled = true;
            lstTarjetas.Location = new Point(127, 85);
            lstTarjetas.Name = "lstTarjetas";
            lstTarjetas.Size = new Size(208, 23);
            lstTarjetas.TabIndex = 3;
            // 
            // lblTarjetaa
            // 
            lblTarjetaa.AutoSize = true;
            lblTarjetaa.Location = new Point(127, 61);
            lblTarjetaa.Name = "lblTarjetaa";
            lblTarjetaa.Size = new Size(49, 15);
            lblTarjetaa.TabIndex = 2;
            lblTarjetaa.Text = "Tarjetas:";
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(21, 56);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(59, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(20, 28);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // grbTitularReserva
            // 
            grbTitularReserva.Controls.Add(txtTelefonoo);
            grbTitularReserva.Controls.Add(txtNombree);
            grbTitularReserva.Controls.Add(lblTelefonoo);
            grbTitularReserva.Controls.Add(lblNombree);
            grbTitularReserva.Location = new Point(12, 240);
            grbTitularReserva.Name = "grbTitularReserva";
            grbTitularReserva.Size = new Size(515, 118);
            grbTitularReserva.TabIndex = 3;
            grbTitularReserva.TabStop = false;
            grbTitularReserva.Text = "Titular de la Reserva";
            // 
            // txtTelefonoo
            // 
            txtTelefonoo.Location = new Point(81, 67);
            txtTelefonoo.Name = "txtTelefonoo";
            txtTelefonoo.Size = new Size(418, 23);
            txtTelefonoo.TabIndex = 3;
            // 
            // txtNombree
            // 
            txtNombree.Location = new Point(81, 28);
            txtNombree.Name = "txtNombree";
            txtNombree.Size = new Size(418, 23);
            txtNombree.TabIndex = 2;
            // 
            // lblTelefonoo
            // 
            lblTelefonoo.AutoSize = true;
            lblTelefonoo.Location = new Point(21, 70);
            lblTelefonoo.Name = "lblTelefonoo";
            lblTelefonoo.Size = new Size(55, 15);
            lblTelefonoo.TabIndex = 1;
            lblTelefonoo.Text = "Teléfono:";
            // 
            // lblNombree
            // 
            lblNombree.AutoSize = true;
            lblNombree.Location = new Point(21, 31);
            lblNombree.Name = "lblNombree";
            lblNombree.Size = new Size(54, 15);
            lblNombree.TabIndex = 0;
            lblNombree.Text = "Nombre:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(432, 373);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(95, 31);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(331, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmReservasCabañas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 420);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(grbTitularReserva);
            Controls.Add(grbFormaPago);
            Controls.Add(grbAdicionales);
            Controls.Add(grbTipo);
            Name = "frmReservasCabañas";
            Text = "Reservas de Cabañas";
            grbTipo.ResumeLayout(false);
            grbTipo.PerformLayout();
            grbAdicionales.ResumeLayout(false);
            grbAdicionales.PerformLayout();
            grbFormaPago.ResumeLayout(false);
            grbFormaPago.PerformLayout();
            grbTitularReserva.ResumeLayout(false);
            grbTitularReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTipo;
        private GroupBox grbAdicionales;
        private GroupBox grbFormaPago;
        private GroupBox grbTitularReserva;
        private Label lblTelefonoo;
        private Label lblNombree;
        private Button btnAceptar;
        private CheckBox chkTelevisor;
        private CheckBox chkHeladera;
        private CheckBox chkCocina;
        private TextBox txtTelefonoo;
        private TextBox txtNombree;
        private Label lblTarjetaa;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private ComboBox lstTarjetas;
        private Label lblDiass;
        private ComboBox lstPersonas;
        private Label lblPersonass;
        private ComboBox lstTipo;
        private Label lblTipoo;
        private TextBox txtDias;
        private Button btnCancelar;
    }
}
