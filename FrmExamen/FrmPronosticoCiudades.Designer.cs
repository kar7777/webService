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
            this.pbxMadrugada = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbx = new System.Windows.Forms.ComboBox();
            this.pbxNoche = new System.Windows.Forms.PictureBox();
            this.pbxTarde = new System.Windows.Forms.PictureBox();
            this.pbxManana = new System.Windows.Forms.PictureBox();
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMadrugada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNoche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManana)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMadrugada
            // 
            this.pbxMadrugada.BackColor = System.Drawing.Color.Transparent;
            this.pbxMadrugada.Location = new System.Drawing.Point(33, 342);
            this.pbxMadrugada.Name = "pbxMadrugada";
            this.pbxMadrugada.Size = new System.Drawing.Size(100, 111);
            this.pbxMadrugada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMadrugada.TabIndex = 2;
            this.pbxMadrugada.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(130, 253);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(164, 22);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Seleccione Ciudad: ";
            // 
            // cbx
            // 
            this.cbx.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx.FormattingEnabled = true;
            this.cbx.Location = new System.Drawing.Point(309, 247);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(261, 28);
            this.cbx.TabIndex = 5;
            this.cbx.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedIndexChanged);
            // 
            // pbxNoche
            // 
            this.pbxNoche.BackColor = System.Drawing.Color.Transparent;
            this.pbxNoche.Location = new System.Drawing.Point(575, 342);
            this.pbxNoche.Name = "pbxNoche";
            this.pbxNoche.Size = new System.Drawing.Size(100, 111);
            this.pbxNoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNoche.TabIndex = 6;
            this.pbxNoche.TabStop = false;
            // 
            // pbxTarde
            // 
            this.pbxTarde.BackColor = System.Drawing.Color.Transparent;
            this.pbxTarde.Location = new System.Drawing.Point(382, 342);
            this.pbxTarde.Name = "pbxTarde";
            this.pbxTarde.Size = new System.Drawing.Size(100, 111);
            this.pbxTarde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTarde.TabIndex = 7;
            this.pbxTarde.TabStop = false;
            // 
            // pbxManana
            // 
            this.pbxManana.BackColor = System.Drawing.Color.Transparent;
            this.pbxManana.Location = new System.Drawing.Point(205, 342);
            this.pbxManana.Name = "pbxManana";
            this.pbxManana.Size = new System.Drawing.Size(100, 111);
            this.pbxManana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxManana.TabIndex = 8;
            this.pbxManana.TabStop = false;
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMessage.Location = new System.Drawing.Point(180, 29);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.Size = new System.Drawing.Size(390, 175);
            this.rtxtMessage.TabIndex = 4;
            this.rtxtMessage.Text = "";
            // 
            // FrmPronosticoCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 465);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pbxNoche);
            this.Controls.Add(this.pbxTarde);
            this.Controls.Add(this.pbxManana);
            this.Controls.Add(this.pbxMadrugada);
            this.Name = "FrmPronosticoCiudades";
            this.Text = "FrmPronosticoCiudades";
            this.Load += new System.EventHandler(this.PronosticoCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMadrugada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNoche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxManana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pbxMadrugada;
        private System.Windows.Forms.ComboBox cbx;
        private System.Windows.Forms.PictureBox pbxManana;
        private System.Windows.Forms.PictureBox pbxTarde;
        private System.Windows.Forms.PictureBox pbxNoche;
        private System.Windows.Forms.RichTextBox rtxtMessage;
    }
}

