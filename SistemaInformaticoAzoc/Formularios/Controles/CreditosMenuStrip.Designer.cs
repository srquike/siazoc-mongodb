namespace SistemaInformaticoAzoc.Formularios.Controles
{
    partial class CreditosMenuStrip
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
            this.BtnCreditos = new System.Windows.Forms.Button();
            this.BtnSocios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreditos
            // 
            this.BtnCreditos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreditos.Location = new System.Drawing.Point(6, 6);
            this.BtnCreditos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCreditos.Name = "BtnCreditos";
            this.BtnCreditos.Size = new System.Drawing.Size(315, 79);
            this.BtnCreditos.TabIndex = 5;
            this.BtnCreditos.Text = "Créditos";
            this.BtnCreditos.UseVisualStyleBackColor = true;
            this.BtnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // BtnSocios
            // 
            this.BtnSocios.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSocios.Location = new System.Drawing.Point(6, 104);
            this.BtnSocios.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSocios.Name = "BtnSocios";
            this.BtnSocios.Size = new System.Drawing.Size(315, 79);
            this.BtnSocios.TabIndex = 6;
            this.BtnSocios.Text = "Socios";
            this.BtnSocios.UseVisualStyleBackColor = true;
            this.BtnSocios.Click += new System.EventHandler(this.BtnSocios_Click);
            // 
            // CreditosMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnSocios);
            this.Controls.Add(this.BtnCreditos);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreditosMenuStrip";
            this.Size = new System.Drawing.Size(328, 190);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreditos;
        private System.Windows.Forms.Button BtnSocios;
    }
}
