namespace SistemaInformaticoAzoc.Formularios.Controles
{
    partial class AdministracionMenuStrip
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnCargos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.Location = new System.Drawing.Point(39, 5);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(6);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(241, 68);
            this.BtnUsuarios.TabIndex = 4;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.Location = new System.Drawing.Point(39, 85);
            this.BtnEmpleados.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(241, 68);
            this.BtnEmpleados.TabIndex = 5;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnCargos
            // 
            this.BtnCargos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargos.Location = new System.Drawing.Point(39, 165);
            this.BtnCargos.Margin = new System.Windows.Forms.Padding(6);
            this.BtnCargos.Name = "BtnCargos";
            this.BtnCargos.Size = new System.Drawing.Size(241, 68);
            this.BtnCargos.TabIndex = 6;
            this.BtnCargos.Text = "Cargos";
            this.BtnCargos.UseVisualStyleBackColor = true;
            this.BtnCargos.Click += new System.EventHandler(this.BtnCargos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(9, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 68);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(9, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 68);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(9, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 68);
            this.panel2.TabIndex = 10;
            // 
            // AdministracionMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnCargos);
            this.Controls.Add(this.BtnEmpleados);
            this.Controls.Add(this.BtnUsuarios);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministracionMenuStrip";
            this.Size = new System.Drawing.Size(291, 238);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button BtnUsuarios;
        public System.Windows.Forms.Button BtnEmpleados;
        public System.Windows.Forms.Button BtnCargos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
