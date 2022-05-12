namespace SistemaInformaticoAzoc.Formularios.Creditos
{
    partial class FrmCreditos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvCreditos = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.ColMarcar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCreditoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTasaInteres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreditos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 66);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de créditos";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCreditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCreditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMarcar,
            this.ColCreditoId,
            this.ColCodigo,
            this.ColMonto,
            this.ColTasaInteres,
            this.ColPlazo,
            this.ColFechaInicio,
            this.ColSocio,
            this.ColDetalles,
            this.ColEditar,
            this.ColEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCreditos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCreditos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvCreditos.Location = new System.Drawing.Point(17, 160);
            this.DgvCreditos.Margin = new System.Windows.Forms.Padding(6);
            this.DgvCreditos.Name = "DgvCreditos";
            this.DgvCreditos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvCreditos.RowHeadersVisible = false;
            this.DgvCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCreditos.Size = new System.Drawing.Size(1211, 490);
            this.DgvCreditos.TabIndex = 7;
            this.DgvCreditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCreditos_CellContentClick);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(956, 663);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(270, 68);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(17, 79);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(270, 68);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "Crear nuevo crédito";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // ColMarcar
            // 
            this.ColMarcar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMarcar.HeaderText = "";
            this.ColMarcar.Name = "ColMarcar";
            this.ColMarcar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMarcar.Width = 5;
            // 
            // ColCreditoId
            // 
            this.ColCreditoId.HeaderText = "Id";
            this.ColCreditoId.Name = "ColCreditoId";
            this.ColCreditoId.ReadOnly = true;
            this.ColCreditoId.Visible = false;
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCodigo.Width = 75;
            // 
            // ColMonto
            // 
            this.ColMonto.HeaderText = "Monto";
            this.ColMonto.Name = "ColMonto";
            this.ColMonto.ReadOnly = true;
            this.ColMonto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMonto.Width = 75;
            // 
            // ColTasaInteres
            // 
            this.ColTasaInteres.HeaderText = "Tasa de interes";
            this.ColTasaInteres.Name = "ColTasaInteres";
            // 
            // ColPlazo
            // 
            this.ColPlazo.HeaderText = "Plazo";
            this.ColPlazo.Name = "ColPlazo";
            this.ColPlazo.ReadOnly = true;
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
            // ColSocio
            // 
            this.ColSocio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSocio.HeaderText = "Socio ";
            this.ColSocio.Name = "ColSocio";
            this.ColSocio.ReadOnly = true;
            this.ColSocio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColDetalles
            // 
            this.ColDetalles.HeaderText = "";
            this.ColDetalles.Name = "ColDetalles";
            this.ColDetalles.ReadOnly = true;
            this.ColDetalles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDetalles.Text = "Ver";
            this.ColDetalles.UseColumnTextForButtonValue = true;
            // 
            // ColEditar
            // 
            this.ColEditar.HeaderText = "";
            this.ColEditar.Name = "ColEditar";
            this.ColEditar.ReadOnly = true;
            this.ColEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEditar.Text = "Editar";
            this.ColEditar.UseColumnTextForButtonValue = true;
            // 
            // ColEliminar
            // 
            this.ColEliminar.HeaderText = "";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColEliminar.Text = "Eliminar";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // FrmCreditos
            // 
            this.AcceptButton = this.BtnNuevo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnCerrar;
            this.ClientSize = new System.Drawing.Size(1243, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvCreditos);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnNuevo);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCreditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de créditos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCreditos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCreditos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCreditos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColMarcar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreditoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTasaInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSocio;
        private System.Windows.Forms.DataGridViewButtonColumn ColDetalles;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
    }
}