namespace pryRomoReservasCabañas
{
    partial class frmMuestra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblMensaje = new Label();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.i;
            pictureBox1.Location = new Point(31, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F);
            lblMensaje.Location = new Point(88, 59);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(53, 21);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "Precio";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(178, 129);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 25);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMuestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 166);
            Controls.Add(btnAceptar);
            Controls.Add(lblMensaje);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmMuestra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importe de la reserva";
            Load += frmMuestra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMensaje;
        private Button btnAceptar;
    }
}