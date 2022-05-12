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
            this.SuspendLayout();
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.Location = new System.Drawing.Point(6, 6);
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(315, 79);
            this.BtnUsuarios.TabIndex = 4;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.Location = new System.Drawing.Point(6, 104);
            this.BtnEmpleados.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(315, 79);
            this.BtnEmpleados.TabIndex = 5;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnCargos
            // 
            this.BtnCargos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargos.Location = new System.Drawing.Point(6, 203);
            this.BtnCargos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCargos.Name = "BtnCargos";
            this.BtnCargos.Size = new System.Drawing.Size(315, 79);
            this.BtnCargos.TabIndex = 6;
            this.BtnCargos.Text = "Cargos";
            this.BtnCargos.UseVisualStyleBackColor = true;
            this.BtnCargos.Click += new System.EventHandler(this.BtnCargos_Click);
            // 
            // AdministracionMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnCargos);
            this.Controls.Add(this.BtnEmpleados);
            this.Controls.Add(this.BtnUsuarios);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdministracionMenuStrip";
            this.Size = new System.Drawing.Size(328, 288);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button BtnUsuarios;
        public System.Windows.Forms.Button BtnEmpleados;
        public System.Windows.Forms.Button BtnCargos;
    }
}
