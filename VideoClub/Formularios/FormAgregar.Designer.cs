namespace VideoClub.Formularios
{
    partial class frmAgregar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVentaCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVentaSocio = new System.Windows.Forms.TextBox();
            this.txtVentaPelicula = new System.Windows.Forms.TextBox();
            this.btnVentaAceptar = new System.Windows.Forms.Button();
            this.btnVentaCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAlquiler = new System.Windows.Forms.RadioButton();
            this.rdoVenta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoNoSocio = new System.Windows.Forms.RadioButton();
            this.rdoSocio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCalidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVentaTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtVentaCodigo
            // 
            this.txtVentaCodigo.Location = new System.Drawing.Point(165, 88);
            this.txtVentaCodigo.Name = "txtVentaCodigo";
            this.txtVentaCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtVentaCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Socio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelicula";
            // 
            // txtVentaSocio
            // 
            this.txtVentaSocio.Location = new System.Drawing.Point(165, 164);
            this.txtVentaSocio.Name = "txtVentaSocio";
            this.txtVentaSocio.Size = new System.Drawing.Size(130, 20);
            this.txtVentaSocio.TabIndex = 4;
            // 
            // txtVentaPelicula
            // 
            this.txtVentaPelicula.Location = new System.Drawing.Point(165, 128);
            this.txtVentaPelicula.Name = "txtVentaPelicula";
            this.txtVentaPelicula.Size = new System.Drawing.Size(130, 20);
            this.txtVentaPelicula.TabIndex = 5;
            // 
            // btnVentaAceptar
            // 
            this.btnVentaAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaAceptar.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaAceptar.Location = new System.Drawing.Point(111, 327);
            this.btnVentaAceptar.Name = "btnVentaAceptar";
            this.btnVentaAceptar.Size = new System.Drawing.Size(101, 35);
            this.btnVentaAceptar.TabIndex = 8;
            this.btnVentaAceptar.Text = "Aceptar";
            this.btnVentaAceptar.UseVisualStyleBackColor = true;
            this.btnVentaAceptar.Click += new System.EventHandler(this.btnVentaAceptar_Click);
            // 
            // btnVentaCancelar
            // 
            this.btnVentaCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaCancelar.Location = new System.Drawing.Point(302, 327);
            this.btnVentaCancelar.Name = "btnVentaCancelar";
            this.btnVentaCancelar.Size = new System.Drawing.Size(101, 35);
            this.btnVentaCancelar.TabIndex = 9;
            this.btnVentaCancelar.Text = "Cancelar";
            this.btnVentaCancelar.UseVisualStyleBackColor = true;
            this.btnVentaCancelar.Click += new System.EventHandler(this.btnVentaCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAlquiler);
            this.groupBox1.Controls.Add(this.rdoVenta);
            this.groupBox1.Location = new System.Drawing.Point(344, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 59);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdoAlquiler
            // 
            this.rdoAlquiler.AutoSize = true;
            this.rdoAlquiler.Location = new System.Drawing.Point(134, 20);
            this.rdoAlquiler.Name = "rdoAlquiler";
            this.rdoAlquiler.Size = new System.Drawing.Size(59, 17);
            this.rdoAlquiler.TabIndex = 1;
            this.rdoAlquiler.Text = "Alquiler";
            this.rdoAlquiler.UseVisualStyleBackColor = true;
            // 
            // rdoVenta
            // 
            this.rdoVenta.AutoSize = true;
            this.rdoVenta.Checked = true;
            this.rdoVenta.Location = new System.Drawing.Point(7, 20);
            this.rdoVenta.Name = "rdoVenta";
            this.rdoVenta.Size = new System.Drawing.Size(53, 17);
            this.rdoVenta.TabIndex = 0;
            this.rdoVenta.TabStop = true;
            this.rdoVenta.Text = "Venta";
            this.rdoVenta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Detalles Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(404, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Detalles Pago";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNoSocio);
            this.groupBox2.Controls.Add(this.rdoSocio);
            this.groupBox2.Location = new System.Drawing.Point(344, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 75);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // rdoNoSocio
            // 
            this.rdoNoSocio.AutoSize = true;
            this.rdoNoSocio.Location = new System.Drawing.Point(134, 20);
            this.rdoNoSocio.Name = "rdoNoSocio";
            this.rdoNoSocio.Size = new System.Drawing.Size(69, 17);
            this.rdoNoSocio.TabIndex = 1;
            this.rdoNoSocio.Text = "No Socio";
            this.rdoNoSocio.UseVisualStyleBackColor = true;
            this.rdoNoSocio.CheckedChanged += new System.EventHandler(this.rdoNoSocio_CheckedChanged);
            // 
            // rdoSocio
            // 
            this.rdoSocio.AutoSize = true;
            this.rdoSocio.Checked = true;
            this.rdoSocio.Location = new System.Drawing.Point(7, 20);
            this.rdoSocio.Name = "rdoSocio";
            this.rdoSocio.Size = new System.Drawing.Size(52, 17);
            this.rdoSocio.TabIndex = 0;
            this.rdoSocio.TabStop = true;
            this.rdoSocio.Text = "Socio";
            this.rdoSocio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Detalles";
            // 
            // cboCalidad
            // 
            this.cboCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalidad.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCalidad.FormattingEnabled = true;
            this.cboCalidad.Items.AddRange(new object[] {
            "Comun",
            "3D",
            "HD",
            "Full HD",
            "Full 4k"});
            this.cboCalidad.Location = new System.Drawing.Point(165, 197);
            this.cboCalidad.Name = "cboCalidad";
            this.cboCalidad.Size = new System.Drawing.Size(130, 21);
            this.cboCalidad.TabIndex = 15;
            this.cboCalidad.SelectedIndexChanged += new System.EventHandler(this.cboCalidad_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total:";
            // 
            // lblVentaTotal
            // 
            this.lblVentaTotal.AutoSize = true;
            this.lblVentaTotal.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaTotal.Location = new System.Drawing.Point(160, 272);
            this.lblVentaTotal.Name = "lblVentaTotal";
            this.lblVentaTotal.Size = new System.Drawing.Size(57, 30);
            this.lblVentaTotal.TabIndex = 17;
            this.lblVentaTotal.Text = "Total";
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(586, 383);
            this.Controls.Add(this.lblVentaTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboCalidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVentaCancelar);
            this.Controls.Add(this.btnVentaAceptar);
            this.Controls.Add(this.txtVentaPelicula);
            this.Controls.Add(this.txtVentaSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVentaCodigo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(602, 422);
            this.MinimumSize = new System.Drawing.Size(602, 422);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVentaCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVentaSocio;
        private System.Windows.Forms.TextBox txtVentaPelicula;
        private System.Windows.Forms.Button btnVentaAceptar;
        private System.Windows.Forms.Button btnVentaCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAlquiler;
        private System.Windows.Forms.RadioButton rdoVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNoSocio;
        private System.Windows.Forms.RadioButton rdoSocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVentaTotal;
    }
}