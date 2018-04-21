namespace FrmExamen
{
    partial class FrmPronosticoCiudades
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPronosticoCiudades));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pbxMadrugada = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.pbxNoche = new System.Windows.Forms.PictureBox();
            this.pbxTarde = new System.Windows.Forms.PictureBox();
            this.pbxManana = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMadrugada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManana)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pbxManana);
            this.bunifuGradientPanel1.Controls.Add(this.pbxTarde);
            this.bunifuGradientPanel1.Controls.Add(this.pbxNoche);
            this.bunifuGradientPanel1.Controls.Add(this.cbx);
            this.bunifuGradientPanel1.Controls.Add(this.rtxtMessage);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.pbxMadrugada);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(744, 467);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pbxMadrugada
            // 
            this.pbxMadrugada.BackColor = System.Drawing.Color.Transparent;
            this.pbxMadrugada.Location = new System.Drawing.Point(81, 342);
            this.pbxMadrugada.Name = "pbxMadrugada";
            this.pbxMadrugada.Size = new System.Drawing.Size(100, 111);
            this.pbxMadrugada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMadrugada.TabIndex = 2;
            this.pbxMadrugada.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(184, 246);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 17);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Seleccione Ciudad: ";
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Location = new System.Drawing.Point(169, 12);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(390, 175);
            this.rtxtMessage.TabIndex = 4;
            this.rtxtMessage.Text = "";
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(240, 294);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(261, 24);
            this.cbx.TabIndex = 5;
            this.cbx.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedIndexChanged);
            // 
            // pbxNoche
            // 
            this.pbxNoche.BackColor = System.Drawing.Color.Transparent;
            this.pbxNoche.Location = new System.Drawing.Point(576, 342);
            this.pbxNoche.Name = "pbxNoche";
            this.pbxNoche.Size = new System.Drawing.Size(100, 111);
            this.pbxNoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNoche.TabIndex = 6;
            this.pbxNoche.TabStop = false;
            // 
            // pbxTarde
            // 
            this.pbxTarde.BackColor = System.Drawing.Color.Transparent;
            this.pbxTarde.Location = new System.Drawing.Point(417, 342);
            this.pbxTarde.Name = "pbxTarde";
            this.pbxTarde.Size = new System.Drawing.Size(100, 111);
            this.pbxTarde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTarde.TabIndex = 7;
            this.pbxTarde.TabStop = false;
            // 
            // pbxManana
            // 
            this.pbxManana.BackColor = System.Drawing.Color.Transparent;
            this.pbxManana.Location = new System.Drawing.Point(240, 342);
            this.pbxManana.Name = "pbxManana";
            this.pbxManana.Size = new System.Drawing.Size(100, 111);
            this.pbxManana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxManana.TabIndex = 8;
            this.pbxManana.TabStop = false;
            // 
            // FrmPronosticoCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 465);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "FrmPronosticoCiudades";
            this.Text = "FrmPronosticoCiudades";
            this.Load += new System.EventHandler(this.PronosticoCiudades_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMadrugada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNoche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pbxMadrugada;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.PictureBox pbxManana;
        private System.Windows.Forms.PictureBox pbxTarde;
        private System.Windows.Forms.PictureBox pbxNoche;
    }
}

