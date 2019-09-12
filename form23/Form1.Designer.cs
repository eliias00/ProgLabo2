namespace form23
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEuroA = new System.Windows.Forms.Label();
            this.labelDolarA = new System.Windows.Forms.Label();
            this.labelPesoA = new System.Windows.Forms.Label();
            this.txtCotizacioneEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 0;
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(230, 17);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(133, 40);
            this.btnLockCotizacion.TabIndex = 0;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock-solid.png");
            this.imageList1.Images.SetKeyName(1, "lock-open-solid.png");
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.ImageList = this.imageList1;
            this.btnConvertEuro.Location = new System.Drawing.Point(230, 118);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(133, 26);
            this.btnConvertEuro.TabIndex = 1;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.ImageList = this.imageList1;
            this.btnConvertPeso.Location = new System.Drawing.Point(230, 226);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(133, 26);
            this.btnConvertPeso.TabIndex = 2;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.ImageList = this.imageList1;
            this.btnConvertDolar.Location = new System.Drawing.Point(230, 170);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(133, 26);
            this.btnConvertDolar.TabIndex = 3;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(26, 118);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(47, 20);
            this.labelEuro.TabIndex = 4;
            this.labelEuro.Text = "Euro";
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar.Location = new System.Drawing.Point(26, 175);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(52, 20);
            this.labelDolar.TabIndex = 5;
            this.labelDolar.Text = "Dolar";
            this.labelDolar.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(26, 231);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(49, 20);
            this.labelPeso.TabIndex = 6;
            this.labelPeso.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cotizacion";
            // 
            // labelEuroA
            // 
            this.labelEuroA.AutoSize = true;
            this.labelEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuroA.Location = new System.Drawing.Point(434, 85);
            this.labelEuroA.Name = "labelEuroA";
            this.labelEuroA.Size = new System.Drawing.Size(47, 20);
            this.labelEuroA.TabIndex = 8;
            this.labelEuroA.Text = "Euro";
            // 
            // labelDolarA
            // 
            this.labelDolarA.AutoSize = true;
            this.labelDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolarA.Location = new System.Drawing.Point(548, 85);
            this.labelDolarA.Name = "labelDolarA";
            this.labelDolarA.Size = new System.Drawing.Size(52, 20);
            this.labelDolarA.TabIndex = 9;
            this.labelDolarA.Text = "Dolar";
            // 
            // labelPesoA
            // 
            this.labelPesoA.AutoSize = true;
            this.labelPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesoA.Location = new System.Drawing.Point(669, 85);
            this.labelPesoA.Name = "labelPesoA";
            this.labelPesoA.Size = new System.Drawing.Size(49, 20);
            this.labelPesoA.TabIndex = 10;
            this.labelPesoA.Text = "Peso";
            // 
            // txtCotizacioneEuro
            // 
            this.txtCotizacioneEuro.Location = new System.Drawing.Point(98, 120);
            this.txtCotizacioneEuro.Name = "txtCotizacioneEuro";
            this.txtCotizacioneEuro.Size = new System.Drawing.Size(117, 20);
            this.txtCotizacioneEuro.TabIndex = 11;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(98, 174);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(117, 20);
            this.txtCotizacionDolar.TabIndex = 12;
            this.txtCotizacionDolar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(98, 226);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(117, 20);
            this.txtCotizacionPeso.TabIndex = 13;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(515, 22);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(117, 20);
            this.txtDolar.TabIndex = 14;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(394, 122);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(117, 20);
            this.txtEuroAEuro.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(517, 122);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(117, 20);
            this.txtEuroADolar.TabIndex = 16;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(640, 122);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(117, 20);
            this.txtEuroAPeso.TabIndex = 17;
            this.txtEuroAPeso.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(394, 22);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(117, 20);
            this.txtEuro.TabIndex = 18;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(640, 175);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(117, 20);
            this.txtDolarAPeso.TabIndex = 21;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(517, 175);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(117, 20);
            this.txtDolarADolar.TabIndex = 20;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(394, 175);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(117, 20);
            this.txtDolarAEuro.TabIndex = 19;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(640, 230);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(117, 20);
            this.txtPesoAPeso.TabIndex = 24;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(517, 230);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(117, 20);
            this.txtPesoADolar.TabIndex = 23;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(394, 230);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(117, 20);
            this.txtPesoAEuro.TabIndex = 22;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(640, 22);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(117, 20);
            this.txtPeso.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 286);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacioneEuro);
            this.Controls.Add(this.labelPesoA);
            this.Controls.Add(this.labelDolarA);
            this.Controls.Add(this.labelEuroA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
         /*private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.btnConvertPeso = new System.Windows.Forms.Button();
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.labelEuro = new System.Windows.Forms.Label();
            this.labelDolar = new System.Windows.Forms.Label();
            this.labelPeso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEuroA = new System.Windows.Forms.Label();
            this.labelDolarA = new System.Windows.Forms.Label();
            this.labelPesoA = new System.Windows.Forms.Label();
            this.txtCotizacioneEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 0;
            this.btnLockCotizacion.ImageList = this.imageList1;
            this.btnLockCotizacion.Location = new System.Drawing.Point(230, 17);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(133, 40);
            this.btnLockCotizacion.TabIndex = 0;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock-solid.png");
            this.imageList1.Images.SetKeyName(1, "lock-open-solid.png");
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.ImageList = this.imageList1;
            this.btnConvertEuro.Location = new System.Drawing.Point(230, 118);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(133, 26);
            this.btnConvertEuro.TabIndex = 1;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // btnConvertPeso
            // 
            this.btnConvertPeso.ImageList = this.imageList1;
            this.btnConvertPeso.Location = new System.Drawing.Point(230, 226);
            this.btnConvertPeso.Name = "btnConvertPeso";
            this.btnConvertPeso.Size = new System.Drawing.Size(133, 26);
            this.btnConvertPeso.TabIndex = 2;
            this.btnConvertPeso.Text = "->";
            this.btnConvertPeso.UseVisualStyleBackColor = true;
            this.btnConvertPeso.Click += new System.EventHandler(this.btnConvertPeso_Click);
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.ImageList = this.imageList1;
            this.btnConvertDolar.Location = new System.Drawing.Point(230, 170);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(133, 26);
            this.btnConvertDolar.TabIndex = 3;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(26, 118);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(47, 20);
            this.labelEuro.TabIndex = 4;
            this.labelEuro.Text = "Euro";
            // 
            // labelDolar
            // 
            this.labelDolar.AutoSize = true;
            this.labelDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolar.Location = new System.Drawing.Point(26, 175);
            this.labelDolar.Name = "labelDolar";
            this.labelDolar.Size = new System.Drawing.Size(52, 20);
            this.labelDolar.TabIndex = 5;
            this.labelDolar.Text = "Dolar";
            this.labelDolar.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.Location = new System.Drawing.Point(26, 231);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(49, 20);
            this.labelPeso.TabIndex = 6;
            this.labelPeso.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cotizacion";
            // 
            // labelEuroA
            // 
            this.labelEuroA.AutoSize = true;
            this.labelEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuroA.Location = new System.Drawing.Point(434, 85);
            this.labelEuroA.Name = "labelEuroA";
            this.labelEuroA.Size = new System.Drawing.Size(47, 20);
            this.labelEuroA.TabIndex = 8;
            this.labelEuroA.Text = "Euro";
            // 
            // labelDolarA
            // 
            this.labelDolarA.AutoSize = true;
            this.labelDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDolarA.Location = new System.Drawing.Point(548, 85);
            this.labelDolarA.Name = "labelDolarA";
            this.labelDolarA.Size = new System.Drawing.Size(52, 20);
            this.labelDolarA.TabIndex = 9;
            this.labelDolarA.Text = "Dolar";
            // 
            // labelPesoA
            // 
            this.labelPesoA.AutoSize = true;
            this.labelPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPesoA.Location = new System.Drawing.Point(669, 85);
            this.labelPesoA.Name = "labelPesoA";
            this.labelPesoA.Size = new System.Drawing.Size(49, 20);
            this.labelPesoA.TabIndex = 10;
            this.labelPesoA.Text = "Peso";
            // 
            // txtCotizacioneEuro
            // 
            this.txtCotizacioneEuro.Location = new System.Drawing.Point(98, 120);
            this.txtCotizacioneEuro.Name = "txtCotizacioneEuro";
            this.txtCotizacioneEuro.Size = new System.Drawing.Size(117, 20);
            this.txtCotizacioneEuro.TabIndex = 11;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(98, 174);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(117, 20);
            this.txtCotizacionDolar.TabIndex = 12;
            this.txtCotizacionDolar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(98, 226);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(117, 20);
            this.txtCotizacionPeso.TabIndex = 13;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(515, 22);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(117, 20);
            this.txtDolar.TabIndex = 14;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(394, 122);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(117, 20);
            this.txtEuroAEuro.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(517, 122);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(117, 20);
            this.txtEuroADolar.TabIndex = 16;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(640, 122);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(117, 20);
            this.txtEuroAPeso.TabIndex = 17;
            this.txtEuroAPeso.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(394, 22);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(117, 20);
            this.txtEuro.TabIndex = 18;
            this.txtEuro.TextChanged += new System.EventHandler(this.txtEuro_TextChanged);
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(640, 175);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(117, 20);
            this.txtDolarAPeso.TabIndex = 21;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(517, 175);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(117, 20);
            this.txtDolarADolar.TabIndex = 20;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(394, 175);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(117, 20);
            this.txtDolarAEuro.TabIndex = 19;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(640, 230);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(117, 20);
            this.txtPesoAPeso.TabIndex = 24;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(517, 230);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(117, 20);
            this.txtPesoADolar.TabIndex = 23;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(394, 230);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(117, 20);
            this.txtPesoAEuro.TabIndex = 22;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(640, 22);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(117, 20);
            this.txtPeso.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 286);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacioneEuro);
            this.Controls.Add(this.labelPesoA);
            this.Controls.Add(this.labelDolarA);
            this.Controls.Add(this.labelEuroA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelDolar);
            this.Controls.Add(this.labelEuro);
            this.Controls.Add(this.btnConvertDolar);
            this.Controls.Add(this.btnConvertPeso);
            this.Controls.Add(this.btnConvertEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Button btnConvertPeso;
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Label labelDolar;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEuroA;
        private System.Windows.Forms.Label labelDolarA;
        private System.Windows.Forms.Label labelPesoA;
        private System.Windows.Forms.TextBox txtCotizacioneEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPeso;
    }
}

