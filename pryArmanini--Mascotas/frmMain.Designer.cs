namespace pryArmanini__Mascotas
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstAnimales = new System.Windows.Forms.ListBox();
            this.lblVete = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPasear = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnMimos = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.picMascotas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 77);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(49, 120);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "Edad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(49, 161);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(98, 16);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de Animal";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(169, 117);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(132, 22);
            this.txtEdad.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Caniche",
            "Perro Salchicha",
            "Gato Siames",
            "Tortuga",
            "Loro Hablador",
            "Hamster Ruso"});
            this.cmbTipo.Location = new System.Drawing.Point(169, 157);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(132, 24);
            this.cmbTipo.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(360, 80);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 36);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstAnimales
            // 
            this.lstAnimales.FormattingEnabled = true;
            this.lstAnimales.ItemHeight = 16;
            this.lstAnimales.Location = new System.Drawing.Point(37, 224);
            this.lstAnimales.Margin = new System.Windows.Forms.Padding(4);
            this.lstAnimales.Name = "lstAnimales";
            this.lstAnimales.Size = new System.Drawing.Size(240, 196);
            this.lstAnimales.TabIndex = 8;
            this.lstAnimales.SelectedIndexChanged += new System.EventHandler(this.lstAnimales_SelectedIndexChanged);
            // 
            // lblVete
            // 
            this.lblVete.AutoSize = true;
            this.lblVete.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVete.Location = new System.Drawing.Point(162, 9);
            this.lblVete.Name = "lblVete";
            this.lblVete.Size = new System.Drawing.Size(246, 38);
            this.lblVete.TabIndex = 11;
            this.lblVete.Text = "VETERINARIA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(496, 501);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 40);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPasear
            // 
            this.btnPasear.Location = new System.Drawing.Point(37, 442);
            this.btnPasear.Name = "btnPasear";
            this.btnPasear.Size = new System.Drawing.Size(117, 38);
            this.btnPasear.TabIndex = 13;
            this.btnPasear.Text = "Pasear";
            this.btnPasear.UseVisualStyleBackColor = true;
            this.btnPasear.Click += new System.EventHandler(this.btnPasear_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(37, 497);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(117, 38);
            this.btnJugar.TabIndex = 14;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnMimos
            // 
            this.btnMimos.Location = new System.Drawing.Point(160, 498);
            this.btnMimos.Name = "btnMimos";
            this.btnMimos.Size = new System.Drawing.Size(117, 38);
            this.btnMimos.TabIndex = 15;
            this.btnMimos.Text = "Mimos";
            this.btnMimos.UseVisualStyleBackColor = true;
            this.btnMimos.Click += new System.EventHandler(this.btnMimos_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(160, 442);
            this.btnAlimentar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(117, 38);
            this.btnAlimentar.TabIndex = 10;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // picMascotas
            // 
            this.picMascotas.Image = ((System.Drawing.Image)(resources.GetObject("picMascotas.Image")));
            this.picMascotas.Location = new System.Drawing.Point(331, 243);
            this.picMascotas.Margin = new System.Windows.Forms.Padding(4);
            this.picMascotas.Name = "picMascotas";
            this.picMascotas.Size = new System.Drawing.Size(192, 158);
            this.picMascotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMascotas.TabIndex = 9;
            this.picMascotas.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 553);
            this.Controls.Add(this.btnMimos);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnPasear);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVete);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.picMascotas);
            this.Controls.Add(this.lstAnimales);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Veterinaria";
            ((System.ComponentModel.ISupportInitialize)(this.picMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstAnimales;
        private System.Windows.Forms.PictureBox picMascotas;
        private System.Windows.Forms.Label lblVete;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPasear;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnMimos;
        private System.Windows.Forms.Button btnAlimentar;
    }
}

