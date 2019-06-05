namespace RRHHProyectoFinal
{
    partial class FrmGestionDepartamento
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
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.departamentosTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.DepartamentosTableAdapter();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idDepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDepartamentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDepartamentosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(476, 461);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(136, 46);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.DgvDepartamentos);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 362);
            this.panel1.TabIndex = 18;
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
            // DgvDepartamentos
            // 
            this.DgvDepartamentos.AllowUserToAddRows = false;
            this.DgvDepartamentos.AllowUserToDeleteRows = false;
            this.DgvDepartamentos.AutoGenerateColumns = false;
            this.DgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamentoDataGridViewTextBoxColumn,
            this.descripcionDepartamentosDataGridViewTextBoxColumn,
            this.estadoDepartamentosDataGridViewCheckBoxColumn});
            this.DgvDepartamentos.DataSource = this.departamentosBindingSource;
            this.DgvDepartamentos.Location = new System.Drawing.Point(3, -1);
            this.DgvDepartamentos.MultiSelect = false;
            this.DgvDepartamentos.Name = "DgvDepartamentos";
            this.DgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDepartamentos.Size = new System.Drawing.Size(592, 319);
            this.DgvDepartamentos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestion de Departamentos";
            // 
            // idDepartamentoDataGridViewTextBoxColumn
            // 
            this.idDepartamentoDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento";
            this.idDepartamentoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDepartamentoDataGridViewTextBoxColumn.Name = "idDepartamentoDataGridViewTextBoxColumn";
            this.idDepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDepartamentosDataGridViewTextBoxColumn
            // 
            this.descripcionDepartamentosDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Departamentos";
            this.descripcionDepartamentosDataGridViewTextBoxColumn.HeaderText = "Departamentos";
            this.descripcionDepartamentosDataGridViewTextBoxColumn.Name = "descripcionDepartamentosDataGridViewTextBoxColumn";
            // 
            // estadoDepartamentosDataGridViewCheckBoxColumn
            // 
            this.estadoDepartamentosDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Departamentos";
            this.estadoDepartamentosDataGridViewCheckBoxColumn.HeaderText = "Estado_Departamentos";
            this.estadoDepartamentosDataGridViewCheckBoxColumn.Name = "estadoDepartamentosDataGridViewCheckBoxColumn";
            this.estadoDepartamentosDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FrmGestionDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionDepartamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.FrmGestionDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private RRHHDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvDepartamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDepartamentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDepartamentosDataGridViewCheckBoxColumn;
    }
}