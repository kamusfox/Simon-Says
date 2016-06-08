namespace SimonBueno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bEmpezar = new System.Windows.Forms.Button();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.bAzul = new System.Windows.Forms.Button();
            this.bAmarillo = new System.Windows.Forms.Button();
            this.bRojo = new System.Windows.Forms.Button();
            this.bVerde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEmpezar
            // 
            this.bEmpezar.Location = new System.Drawing.Point(262, 30);
            this.bEmpezar.Name = "bEmpezar";
            this.bEmpezar.Size = new System.Drawing.Size(134, 23);
            this.bEmpezar.TabIndex = 4;
            this.bEmpezar.Text = "Nueva Partida";
            this.bEmpezar.UseVisualStyleBackColor = true;
            this.bEmpezar.Click += new System.EventHandler(this.bEmpezar_Click);
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.Location = new System.Drawing.Point(318, 371);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(316, 45);
            this.lblPuntos.TabIndex = 5;
            this.lblPuntos.Text = "Pulse nueva partida";
            // 
            // bAzul
            // 
            this.bAzul.BackColor = System.Drawing.Color.Transparent;
            this.bAzul.Enabled = false;
            this.bAzul.FlatAppearance.BorderSize = 0;
            this.bAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAzul.Image = global::SimonBueno.Properties.Resources.bAzul1;
            this.bAzul.Location = new System.Drawing.Point(185, 80);
            this.bAzul.Name = "bAzul";
            this.bAzul.Size = new System.Drawing.Size(140, 140);
            this.bAzul.TabIndex = 3;
            this.bAzul.UseVisualStyleBackColor = false;
            this.bAzul.Click += new System.EventHandler(this.bAzul_Click);
            // 
            // bAmarillo
            // 
            this.bAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.bAmarillo.Enabled = false;
            this.bAmarillo.FlatAppearance.BorderSize = 0;
            this.bAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAmarillo.Image = global::SimonBueno.Properties.Resources.bAmarillo;
            this.bAmarillo.Location = new System.Drawing.Point(326, 219);
            this.bAmarillo.Name = "bAmarillo";
            this.bAmarillo.Size = new System.Drawing.Size(140, 140);
            this.bAmarillo.TabIndex = 2;
            this.bAmarillo.UseVisualStyleBackColor = false;
            this.bAmarillo.Click += new System.EventHandler(this.bAmarillo_Click);
            // 
            // bRojo
            // 
            this.bRojo.BackColor = System.Drawing.Color.Transparent;
            this.bRojo.Enabled = false;
            this.bRojo.FlatAppearance.BorderSize = 0;
            this.bRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRojo.Image = global::SimonBueno.Properties.Resources.bRojo;
            this.bRojo.Location = new System.Drawing.Point(185, 219);
            this.bRojo.Name = "bRojo";
            this.bRojo.Size = new System.Drawing.Size(140, 140);
            this.bRojo.TabIndex = 1;
            this.bRojo.UseVisualStyleBackColor = false;
            this.bRojo.Click += new System.EventHandler(this.bRojo_Click);
            // 
            // bVerde
            // 
            this.bVerde.BackColor = System.Drawing.Color.Transparent;
            this.bVerde.Enabled = false;
            this.bVerde.FlatAppearance.BorderSize = 0;
            this.bVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerde.Image = global::SimonBueno.Properties.Resources.bVerde;
            this.bVerde.Location = new System.Drawing.Point(326, 80);
            this.bVerde.Name = "bVerde";
            this.bVerde.Size = new System.Drawing.Size(140, 140);
            this.bVerde.TabIndex = 0;
            this.bVerde.UseVisualStyleBackColor = false;
            this.bVerde.Click += new System.EventHandler(this.bVerde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 465);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.bEmpezar);
            this.Controls.Add(this.bAzul);
            this.Controls.Add(this.bAmarillo);
            this.Controls.Add(this.bRojo);
            this.Controls.Add(this.bVerde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simon Says";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bRojo;
        public System.Windows.Forms.Button bAmarillo;
        public System.Windows.Forms.Button bAzul;
        public System.Windows.Forms.Button bVerde;
        public System.Windows.Forms.Button bEmpezar;
        private System.Windows.Forms.Label lblPuntos;
    }
}

