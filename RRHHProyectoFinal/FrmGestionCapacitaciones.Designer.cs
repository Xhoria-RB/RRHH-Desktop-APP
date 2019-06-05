namespace RRHHProyectoFinal
{
    partial class FrmGestionCapacitaciones
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
            this.components = new System.ComponentModel.Container();
            this.capacitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.capacitacionesTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.CapacitacionesTableAdapter();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvCapacitaciones = new System.Windows.Forms.DataGridView();
            this.idCapacitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucionCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCapacitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // capacitacionesBindingSource
            // 
            this.capacitacionesBindingSource.DataMember = "Capacitaciones";
            this.capacitacionesBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // capacitacionesTableAdapter
            // 
            this.capacitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(476, 460);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(136, 46);
            this.BtnCerrar.TabIndex = 14;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.DgvCapacitaciones);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 362);
            this.panel1.TabIndex = 15;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(130, 324);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(98, 32);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(16, 325);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 32);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvCapacitaciones
            // 
            this.DgvCapacitaciones.AllowUserToAddRows = false;
            this.DgvCapacitaciones.AllowUserToDeleteRows = false;
            this.DgvCapacitaciones.AutoGenerateColumns = false;
            this.DgvCapacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCapacitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCapacitacionDataGridViewTextBoxColumn,
            this.descripcionCapacitacionesDataGridViewTextBoxColumn,
            this.nivelCapacitacionesDataGridViewTextBoxColumn,
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn,
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn,
            this.institucionCapacitacionesDataGridViewTextBoxColumn});
            this.DgvCapacitaciones.DataSource = this.capacitacionesBindingSource;
            this.DgvCapacitaciones.Location = new System.Drawing.Point(3, -1);
            this.DgvCapacitaciones.MultiSelect = false;
            this.DgvCapacitaciones.Name = "DgvCapacitaciones";
            this.DgvCapacitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCapacitaciones.Size = new System.Drawing.Size(592, 319);
            this.DgvCapacitaciones.TabIndex = 1;
            // 
            // idCapacitacionDataGridViewTextBoxColumn
            // 
            this.idCapacitacionDataGridViewTextBoxColumn.DataPropertyName = "IdCapacitacion";
            this.idCapacitacionDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCapacitacionDataGridViewTextBoxColumn.Name = "idCapacitacionDataGridViewTextBoxColumn";
            this.idCapacitacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionCapacitacionesDataGridViewTextBoxColumn
            // 
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Capacitaciones";
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Capacitaciones";
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.Name = "descripcionCapacitacionesDataGridViewTextBoxColumn";
            // 
            // nivelCapacitacionesDataGridViewTextBoxColumn
            // 
            this.nivelCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "Nivel_Capacitaciones";
            this.nivelCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelCapacitacionesDataGridViewTextBoxColumn.Name = "nivelCapacitacionesDataGridViewTextBoxColumn";
            // 
            // fechaDesdeCapacitacionesDataGridViewTextBoxColumn
            // 
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde_Capacitaciones";
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.Name = "fechaDesdeCapacitacionesDataGridViewTextBoxColumn";
            // 
            // fechaHastaCapacitacionesDataGridViewTextBoxColumn
            // 
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "FechaHasta_Capacitaciones";
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.Name = "fechaHastaCapacitacionesDataGridViewTextBoxColumn";
            // 
            // institucionCapacitacionesDataGridViewTextBoxColumn
            // 
            this.institucionCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "Institucion_Capacitaciones";
            this.institucionCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Instituciones";
            this.institucionCapacitacionesDataGridViewTextBoxColumn.Name = "institucionCapacitacionesDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestion de Capacitaciones";
            // 
            // FrmGestionCapacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionCapacitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacitaciones";
            this.Load += new System.EventHandler(this.FrmGestionCapacitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCapacitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource;
        private RRHHDataSetTableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvCapacitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCapacitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesdeCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHastaCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucionCapacitacionesDataGridViewTextBoxColumn;
    }
}