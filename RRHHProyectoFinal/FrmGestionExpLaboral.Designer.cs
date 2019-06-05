namespace RRHHProyectoFinal
{
    partial class FrmGestionExpLaboral
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
            this.label1 = new System.Windows.Forms.Label();
            this.expLaboralesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.expLaboralesTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.ExpLaboralesTableAdapter();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvExpLaboral = new System.Windows.Forms.DataGridView();
            this.idExpLaboralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaExpLaboralesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoOcupadoExpLaboralesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesdeExpLaboralesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHastaExpLaboralesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioExpLaboralesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expLaboralesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.expLaboralesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpLaboral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expLaboralesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gestion de Experiencia Laboral";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // expLaboralesBindingSource
            // 
            this.expLaboralesBindingSource.DataMember = "ExpLaborales";
            this.expLaboralesBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expLaboralesTableAdapter
            // 
            this.expLaboralesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(476, 460);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(136, 46);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.DgvExpLaboral);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 362);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // DgvExpLaboral
            // 
            this.DgvExpLaboral.AllowUserToAddRows = false;
            this.DgvExpLaboral.AllowUserToDeleteRows = false;
            this.DgvExpLaboral.AutoGenerateColumns = false;
            this.DgvExpLaboral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpLaboral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idExpLaboralDataGridViewTextBoxColumn,
            this.empresaExpLaboralesDataGridViewTextBoxColumn,
            this.puestoOcupadoExpLaboralesDataGridViewTextBoxColumn,
            this.fechaDesdeExpLaboralesDataGridViewTextBoxColumn,
            this.fechaHastaExpLaboralesDataGridViewTextBoxColumn,
            this.salarioExpLaboralesDataGridViewTextBoxColumn});
            this.DgvExpLaboral.DataSource = this.expLaboralesBindingSource;
            this.DgvExpLaboral.Location = new System.Drawing.Point(3, -1);
            this.DgvExpLaboral.MultiSelect = false;
            this.DgvExpLaboral.Name = "DgvExpLaboral";
            this.DgvExpLaboral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvExpLaboral.Size = new System.Drawing.Size(592, 319);
            this.DgvExpLaboral.TabIndex = 1;
            // 
            // idExpLaboralDataGridViewTextBoxColumn
            // 
            this.idExpLaboralDataGridViewTextBoxColumn.DataPropertyName = "IdExpLaboral";
            this.idExpLaboralDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idExpLaboralDataGridViewTextBoxColumn.Name = "idExpLaboralDataGridViewTextBoxColumn";
            this.idExpLaboralDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaExpLaboralesDataGridViewTextBoxColumn
            // 
            this.empresaExpLaboralesDataGridViewTextBoxColumn.DataPropertyName = "Empresa_ExpLaborales";
            this.empresaExpLaboralesDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaExpLaboralesDataGridViewTextBoxColumn.Name = "empresaExpLaboralesDataGridViewTextBoxColumn";
            // 
            // puestoOcupadoExpLaboralesDataGridViewTextBoxColumn
            // 
            this.puestoOcupadoExpLaboralesDataGridViewTextBoxColumn.DataPropertyName = "PuestoOcupado_ExpLaborales";
            this.puestoOcupadoExpLaboralesDataGridViewTextBoxColumn.HeaderText = "Puesto Ocupado";
            this.puestoOcupadoExpLaboralesDataGridViewTextBoxColumn.Name = "puestoOcupadoExpLaboralesDataGridViewTextBoxColumn";
            // 
            // fechaDesdeExpLaboralesDataGridViewTextBoxColumn
            // 
            this.fechaDesdeExpLaboralesDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde_ExpLaborales";
            this.fechaDesdeExpLaboralesDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.fechaDesdeExpLaboralesDataGridViewTextBoxColumn.Name = "fechaDesdeExpLaboralesDataGridViewTextBoxColumn";
            // 
            // fechaHastaExpLaboralesDataGridViewTextBoxColumn
            // 
            this.fechaHastaExpLaboralesDataGridViewTextBoxColumn.DataPropertyName = "FechaHasta_ExpLaborales";
            this.fechaHastaExpLaboralesDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.fechaHastaExpLaboralesDataGridViewTextBoxColumn.Name = "fechaHastaExpLaboralesDataGridViewTextBoxColumn";
            // 
            // salarioExpLaboralesDataGridViewTextBoxColumn
            // 
            this.salarioExpLaboralesDataGridViewTextBoxColumn.DataPropertyName = "Salario_ExpLaborales";
            this.salarioExpLaboralesDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioExpLaboralesDataGridViewTextBoxColumn.Name = "salarioExpLaboralesDataGridViewTextBoxColumn";
            // 
            // expLaboralesBindingSource1
            // 
            this.expLaboralesBindingSource1.DataMember = "ExpLaborales";
            this.expLaboralesBindingSource1.DataSource = this.rRHHDataSet;
            // 
            // FrmGestionExpLaboral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionExpLaboral";
            this.Text = "Experiencia Laboral";
            this.Load += new System.EventHandler(this.FrmGestionExpLaboral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expLaboralesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpLaboral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expLaboralesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource expLaboralesBindingSource;
        private RRHHDataSetTableAdapters.ExpLaboralesTableAdapter expLaboralesTableAdapter;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvExpLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExpLaboralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCandidatoExpLaboralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaExpLaboralesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoOcupadoExpLaboralesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesdeExpLaboralesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHastaExpLaboralesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioExpLaboralesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource expLaboralesBindingSource1;
    }
}