namespace SistemaInformaticoAzoc.Formularios.Cargos
{
    partial class FrmCargos
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
            this.DgvCargos = new System.Windows.Forms.DataGridView();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnNuevoCargo = new System.Windows.Forms.Button();
            this.ColMarcar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCargoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpleados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 66);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de cargos";
            // 
            // DgvCargos
            // 
            this.DgvCargos.AllowUserToAddRows = false;
            this.DgvCargos.AllowUserToDeleteRows = false;
            this.DgvCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvCargos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMarcar,
            this.ColCargoId,
            this.ColNombre,
            this.ColDescripcion,
            this.ColEmpleados,
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
            this.DgvCargos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCargos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvCargos.Location = new System.Drawing.Point(14, 152);
            this.DgvCargos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCargos.Name = "DgvCargos";
            this.DgvCargos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvCargos.RowHeadersVisible = false;
            this.DgvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCargos.Size = new System.Drawing.Size(1211, 505);
            this.DgvCargos.TabIndex = 6;
            this.DgvCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCargos_CellContentClick);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(954, 666);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(270, 68);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnNuevoCargo
            // 
            this.BtnNuevoCargo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoCargo.Location = new System.Drawing.Point(14, 75);
            this.BtnNuevoCargo.Margin = new System.Windows.Forms.Padding(5);
            this.BtnNuevoCargo.Name = "BtnNuevoCargo";
            this.BtnNuevoCargo.Size = new System.Drawing.Size(270, 68);
            this.BtnNuevoCargo.TabIndex = 4;
            this.BtnNuevoCargo.Text = "Crear nuevo cargo";
            this.BtnNuevoCargo.UseVisualStyleBackColor = true;
            this.BtnNuevoCargo.Click += new System.EventHandler(this.BtnNuevoCargo_Click);
            // 
            // ColMarcar
            // 
            this.ColMarcar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColMarcar.HeaderText = "";
            this.ColMarcar.Name = "ColMarcar";
            this.ColMarcar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMarcar.Width = 5;
            // 
            // ColCargoId
            // 
            this.ColCargoId.HeaderText = "Id";
            this.ColCargoId.Name = "ColCargoId";
            this.ColCargoId.ReadOnly = true;
            this.ColCargoId.Visible = false;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescripcion.HeaderText = "Descripción";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColEmpleados
            // 
            this.ColEmpleados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEmpleados.HeaderText = "Cantidad de empleados";
            this.ColEmpleados.Name = "ColEmpleados";
            this.ColEmpleados.ReadOnly = true;
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
            // FrmCargos
            // 
            this.AcceptButton = this.BtnNuevoCargo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnCerrar;
            this.ClientSize = new System.Drawing.Size(1243, 747);
            this.Controls.Add(this.DgvCargos);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnNuevoCargo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCargos";
            this.Text = "Lista de cargos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCargos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvCargos;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnNuevoCargo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColMarcar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCargoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleados;
        private System.Windows.Forms.DataGridViewButtonColumn ColDetalles;
        private System.Windows.Forms.DataGridViewButtonColumn ColEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
    }
}