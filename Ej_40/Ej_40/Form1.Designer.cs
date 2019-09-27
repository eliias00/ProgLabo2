namespace Ej_40
{
    partial class FormularioMenu
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGenLLam = new System.Windows.Forms.Button();
            this.btnFacPro = new System.Windows.Forms.Button();
            this.btnFacTot = new System.Windows.Forms.Button();
            this.btnFacLoc = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenLLam
            // 
            this.btnGenLLam.Location = new System.Drawing.Point(44, 12);
            this.btnGenLLam.Name = "btnGenLLam";
            this.btnGenLLam.Size = new System.Drawing.Size(239, 59);
            this.btnGenLLam.TabIndex = 0;
            this.btnGenLLam.Text = "Generar Llamada";
            this.btnGenLLam.UseVisualStyleBackColor = true;
            this.btnGenLLam.Click += new System.EventHandler(this.btnGenLLam_Click);
            // 
            // btnFacPro
            // 
            this.btnFacPro.Location = new System.Drawing.Point(44, 245);
            this.btnFacPro.Name = "btnFacPro";
            this.btnFacPro.Size = new System.Drawing.Size(239, 59);
            this.btnFacPro.TabIndex = 1;
            this.btnFacPro.Text = "Facturacion Provincial";
            this.btnFacPro.UseVisualStyleBackColor = true;
            // 
            // btnFacTot
            // 
            this.btnFacTot.Location = new System.Drawing.Point(44, 87);
            this.btnFacTot.Name = "btnFacTot";
            this.btnFacTot.Size = new System.Drawing.Size(239, 59);
            this.btnFacTot.TabIndex = 2;
            this.btnFacTot.Text = "Facturacion Total";
            this.btnFacTot.UseVisualStyleBackColor = true;
            // 
            // btnFacLoc
            // 
            this.btnFacLoc.Location = new System.Drawing.Point(44, 165);
            this.btnFacLoc.Name = "btnFacLoc";
            this.btnFacLoc.Size = new System.Drawing.Size(239, 59);
            this.btnFacLoc.TabIndex = 3;
            this.btnFacLoc.Text = "Facturacion Local";
            this.btnFacLoc.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(44, 323);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(239, 59);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 394);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacLoc);
            this.Controls.Add(this.btnFacTot);
            this.Controls.Add(this.btnFacPro);
            this.Controls.Add(this.btnGenLLam);
            this.Name = "Form";
            this.Text = "Central Telefonica ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGenLLam;
        private System.Windows.Forms.Button btnFacPro;
        private System.Windows.Forms.Button btnFacTot;
        private System.Windows.Forms.Button btnFacLoc;
        private System.Windows.Forms.Button btnSalir;
    }
}

