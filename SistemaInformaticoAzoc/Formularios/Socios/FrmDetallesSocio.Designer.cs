namespace SistemaInformaticoAzoc.Formularios.Socios
{
    partial class FrmDetallesSocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ChkHabilitado = new System.Windows.Forms.CheckBox();
            this.ChkRetirado = new System.Windows.Forms.CheckBox();
            this.MtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MtbDui = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.TxtFechaIngreso = new System.Windows.Forms.TextBox();
            this.TxtFechaRetiro = new System.Windows.Forms.TextBox();
            this.TxtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvCreditos = new System.Windows.Forms.DataGridView();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(363, 613);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(270, 68);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cerrar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ChkHabilitado
            // 
            this.ChkHabilitado.AutoSize = true;
            this.ChkHabilitado.Enabled = false;
            this.ChkHabilitado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkHabilitado.Location = new System.Drawing.Point(490, 285);
            this.ChkHabilitado.Name = "ChkHabilitado";
            this.ChkHabilitado.Size = new System.Drawing.Size(118, 23);
            this.ChkHabilitado.TabIndex = 11;
            this.ChkHabilitado.Text = "Habilitado";
            this.ChkHabilitado.UseVisualStyleBackColor = true;
            // 
            // ChkRetirado
            // 
            this.ChkRetirado.AutoSize = true;
            this.ChkRetirado.Enabled = false;
            this.ChkRetirado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRetirado.Location = new System.Drawing.Point(338, 285);
            this.ChkRetirado.Name = "ChkRetirado";
            this.ChkRetirado.Size = new System.Drawing.Size(100, 23);
            this.ChkRetirado.TabIndex = 10;
            this.ChkRetirado.Text = "Retirado";
            this.ChkRetirado.UseVisualStyleBackColor = true;
            // 
            // MtbCodigo
            // 
            this.MtbCodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbCodigo.Location = new System.Drawing.Point(338, 164);
            this.MtbCodigo.Name = "MtbCodigo";
            this.MtbCodigo.ReadOnly = true;
            this.MtbCodigo.Size = new System.Drawing.Size(270, 26);
            this.MtbCodigo.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(334, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(334, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fecha de retiro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // MtbTelefono
            // 
            this.MtbTelefono.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTelefono.Location = new System.Drawing.Point(338, 224);
            this.MtbTelefono.Name = "MtbTelefono";
            this.MtbTelefono.ReadOnly = true;
            this.MtbTelefono.Size = new System.Drawing.Size(270, 26);
            this.MtbTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Número de teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Género:";
            // 
            // MtbDui
            // 
            this.MtbDui.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbDui.Location = new System.Drawing.Point(11, 224);
            this.MtbDui.Name = "MtbDui";
            this.MtbDui.ReadOnly = true;
            this.MtbDui.Size = new System.Drawing.Size(270, 26);
            this.MtbDui.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Número de DUI:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(11, 165);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(270, 26);
            this.TxtDireccion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(11, 45);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(270, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre completo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtGenero);
            this.groupBox1.Controls.Add(this.TxtFechaIngreso);
            this.groupBox1.Controls.Add(this.TxtFechaRetiro);
            this.groupBox1.Controls.Add(this.TxtFechaNacimiento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DgvCreditos);
            this.groupBox1.Controls.Add(this.ChkHabilitado);
            this.groupBox1.Controls.Add(this.ChkRetirado);
            this.groupBox1.Controls.Add(this.MtbCodigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MtbTelefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MtbDui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 594);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del socio";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenero.Location = new System.Drawing.Point(11, 285);
            this.TxtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.ReadOnly = true;
            this.TxtGenero.Size = new System.Drawing.Size(270, 26);
            this.TxtGenero.TabIndex = 29;
            // 
            // TxtFechaIngreso
            // 
            this.TxtFechaIngreso.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaIngreso.Location = new System.Drawing.Point(338, 45);
            this.TxtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaIngreso.Name = "TxtFechaIngreso";
            this.TxtFechaIngreso.ReadOnly = true;
            this.TxtFechaIngreso.Size = new System.Drawing.Size(270, 26);
            this.TxtFechaIngreso.TabIndex = 28;
            // 
            // TxtFechaRetiro
            // 
            this.TxtFechaRetiro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaRetiro.Location = new System.Drawing.Point(338, 105);
            this.TxtFechaRetiro.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaRetiro.Name = "TxtFechaRetiro";
            this.TxtFechaRetiro.ReadOnly = true;
            this.TxtFechaRetiro.Size = new System.Drawing.Size(270, 26);
            this.TxtFechaRetiro.TabIndex = 27;
            // 
            // TxtFechaNacimiento
            // 
            this.TxtFechaNacimiento.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaNacimiento.Location = new System.Drawing.Point(11, 105);
            this.TxtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFechaNacimiento.Name = "TxtFechaNacimiento";
            this.TxtFechaNacimiento.ReadOnly = true;
            this.TxtFechaNacimiento.Size = new System.Drawing.Size(270, 26);
            this.TxtFechaNacimiento.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Créditos asignados:";
            // 
            // DgvCreditos
            // 
            this.DgvCreditos.AllowUserToAddRows = false;
            this.DgvCreditos.AllowUserToDeleteRows = false;
            this.DgvCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCreditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvCreditos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumero,
            this.ColCodigo,
            this.ColMonto,
            this.ColFechaInicio,
            this.ColPlazo,
            this.ColInteres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCreditos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCreditos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvCreditos.Location = new System.Drawing.Point(11, 352);
            this.DgvCreditos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCreditos.Name = "DgvCreditos";
            this.DgvCreditos.ReadOnly = true;
            this.DgvCreditos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvCreditos.RowHeadersVisible = false;
            this.DgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCreditos.Size = new System.Drawing.Size(597, 235);
            this.DgvCreditos.TabIndex = 24;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "#";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 50;
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColMonto
            // 
            this.ColMonto.HeaderText = "Monto";
            this.ColMonto.Name = "ColMonto";
            this.ColMonto.ReadOnly = true;
            this.ColMonto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMonto.Width = 75;
            // 
            // ColFechaInicio
            // 
            this.ColFechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColFechaInicio.HeaderText = "Fecha de Inicio";
            this.ColFechaInicio.Name = "ColFechaInicio";
            this.ColFechaInicio.ReadOnly = true;
            this.ColFechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColFechaInicio.Width = 106;
            // 
            // ColPlazo
            // 
            this.ColPlazo.HeaderText = "Plazo";
            this.ColPlazo.Name = "ColPlazo";
            this.ColPlazo.ReadOnly = true;
            // 
            // ColInteres
            // 
            this.ColInteres.HeaderText = "% de interes";
            this.ColInteres.Name = "ColInteres";
            this.ColInteres.ReadOnly = true;
            // 
            // FrmDetallesSocio
            // 
            this.AcceptButton = this.BtnCancelar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(645, 695);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDetallesSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del socio";
            this.Load += new System.EventHandler(this.FrmDetallesSocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.CheckBox ChkHabilitado;
        private System.Windows.Forms.CheckBox ChkRetirado;
        private System.Windows.Forms.MaskedTextBox MtbCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MtbTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MtbDui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.TextBox TxtFechaIngreso;
        private System.Windows.Forms.TextBox TxtFechaRetiro;
        private System.Windows.Forms.TextBox TxtFechaNacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvCreditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInteres;
    }
}