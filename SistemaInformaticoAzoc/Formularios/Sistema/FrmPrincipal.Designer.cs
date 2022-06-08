namespace SistemaInformaticoAzoc.Formularios
{
    partial class FrmPrincipal
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
        /// 
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAdministrar = new System.Windows.Forms.Button();
            this.BtnCreditos = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.BtnAdministrar);
            this.panel1.Controls.Add(this.BtnCreditos);
            this.panel1.Controls.Add(this.BtnCerrarSesion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 749);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(13, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 68);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(13, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 68);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(13, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 68);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "BIENVENIDO(A)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaInformaticoAzoc.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(71, 146);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAdministrar
            // 
            this.BtnAdministrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAdministrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministrar.Location = new System.Drawing.Point(42, 406);
            this.BtnAdministrar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAdministrar.Name = "BtnAdministrar";
            this.BtnAdministrar.Size = new System.Drawing.Size(241, 68);
            this.BtnAdministrar.TabIndex = 3;
            this.BtnAdministrar.Text = "Administración";
            this.BtnAdministrar.UseVisualStyleBackColor = true;
            this.BtnAdministrar.Click += new System.EventHandler(this.BtnAdministrar_Click);
            // 
            // BtnCreditos
            // 
            this.BtnCreditos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCreditos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreditos.Location = new System.Drawing.Point(42, 484);
            this.BtnCreditos.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCreditos.Name = "BtnCreditos";
            this.BtnCreditos.Size = new System.Drawing.Size(241, 68);
            this.BtnCreditos.TabIndex = 2;
            this.BtnCreditos.Text = "Créditos";
            this.BtnCreditos.UseVisualStyleBackColor = true;
            this.BtnCreditos.Click += new System.EventHandler(this.BtnCreditos_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.Location = new System.Drawing.Point(42, 663);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(241, 68);
            this.BtnCerrarSesion.TabIndex = 1;
            this.BtnCerrarSesion.Text = "Salir";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaInformaticoAzoc.Properties.Resources.azoc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // administracionMenuStrip
            // 
            this.administracionMenuStrip.BackColor = System.Drawing.Color.White;
            this.administracionMenuStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracionMenuStrip.Location = new System.Drawing.Point(307, 371);
            this.administracionMenuStrip.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.administracionMenuStrip.Name = "administracionMenuStrip";
            this.administracionMenuStrip.Size = new System.Drawing.Size(291, 238);
            this.administracionMenuStrip.TabIndex = 3;
            this.administracionMenuStrip.Visible = false;
            // 
            // creditosMenuStrip
            // 
            this.creditosMenuStrip.BackColor = System.Drawing.Color.White;
            this.creditosMenuStrip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditosMenuStrip.Location = new System.Drawing.Point(307, 449);
            this.creditosMenuStrip.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.creditosMenuStrip.Name = "creditosMenuStrip";
            this.creditosMenuStrip.Size = new System.Drawing.Size(288, 160);
            this.creditosMenuStrip.TabIndex = 5;
            this.creditosMenuStrip.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombre.Location = new System.Drawing.Point(13, 345);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(270, 19);
            this.TxtNombre.TabIndex = 10;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCerrarSesion;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.creditosMenuStrip);
            this.Controls.Add(this.administracionMenuStrip);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPrincipal";
            this.Text = "SIAZOC v1.0.0 - Cooperativa AZOC de R. L.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAdministrar;
        private System.Windows.Forms.Button BtnCreditos;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private Controles.AdministracionMenuStrip administracionMenuStrip;
        private Controles.CreditosMenuStrip creditosMenuStrip;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}