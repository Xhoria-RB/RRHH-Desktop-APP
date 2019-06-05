namespace RRHHProyectoFinal
{
    partial class FrmGestionPuestos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvPuestos = new System.Windows.Forms.DataGridView();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.puestosTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.PuestosTableAdapter();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.idPuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePuestosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamentoPuestosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelRiesgoPuestosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioMinimoPuestosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioMaximoPuestosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPuestosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de Puestos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnBorrar);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.DgvPuestos);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 362);
            this.panel1.TabIndex = 6;
            // 
            // DgvPuestos
            // 
            this.DgvPuestos.AllowUserToAddRows = false;
            this.DgvPuestos.AllowUserToDeleteRows = false;
            this.DgvPuestos.AutoGenerateColumns = false;
            this.DgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPuestoDataGridViewTextBoxColumn,
            this.nombrePuestosDataGridViewTextBoxColumn,
            this.idDepartamentoPuestosDataGridViewTextBoxColumn,
            this.nivelRiesgoPuestosDataGridViewTextBoxColumn,
            this.salarioMinimoPuestosDataGridViewTextBoxColumn,
            this.salarioMaximoPuestosDataGridViewTextBoxColumn,
            this.estadoPuestosDataGridViewCheckBoxColumn});
            this.DgvPuestos.DataSource = this.puestosBindingSource;
            this.DgvPuestos.Location = new System.Drawing.Point(3, -1);
            this.DgvPuestos.MultiSelect = false;
            this.DgvPuestos.Name = "DgvPuestos";
            this.DgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPuestos.Size = new System.Drawing.Size(592, 319);
            this.DgvPuestos.TabIndex = 1;
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataMember = "Puestos";
            this.puestosBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // puestosTableAdapter
            // 
            this.puestosTableAdapter.ClearBeforeFill = true;
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
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(476, 460);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(136, 46);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // idPuestoDataGridViewTextBoxColumn
            // 
            this.idPuestoDataGridViewTextBoxColumn.DataPropertyName = "IdPuesto";
            this.idPuestoDataGridViewTextBoxColumn.HeaderText = "No. Puesto";
            this.idPuestoDataGridViewTextBoxColumn.Name = "idPuestoDataGridViewTextBoxColumn";
            this.idPuestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePuestosDataGridViewTextBoxColumn
            // 
            this.nombrePuestosDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Puestos";
            this.nombrePuestosDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.nombrePuestosDataGridViewTextBoxColumn.Name = "nombrePuestosDataGridViewTextBoxColumn";
            // 
            // idDepartamentoPuestosDataGridViewTextBoxColumn
            // 
            this.idDepartamentoPuestosDataGridViewTextBoxColumn.DataPropertyName = "IdDepartamento_Puestos";
            this.idDepartamentoPuestosDataGridViewTextBoxColumn.HeaderText = "Departamento";
            this.idDepartamentoPuestosDataGridViewTextBoxColumn.Name = "idDepartamentoPuestosDataGridViewTextBoxColumn";
            // 
            // nivelRiesgoPuestosDataGridViewTextBoxColumn
            // 
            this.nivelRiesgoPuestosDataGridViewTextBoxColumn.DataPropertyName = "NivelRiesgo_Puestos";
            this.nivelRiesgoPuestosDataGridViewTextBoxColumn.HeaderText = "Riesgo";
            this.nivelRiesgoPuestosDataGridViewTextBoxColumn.Name = "nivelRiesgoPuestosDataGridViewTextBoxColumn";
            // 
            // salarioMinimoPuestosDataGridViewTextBoxColumn
            // 
            this.salarioMinimoPuestosDataGridViewTextBoxColumn.DataPropertyName = "SalarioMinimo_Puestos";
            this.salarioMinimoPuestosDataGridViewTextBoxColumn.HeaderText = "Salario Minimo";
            this.salarioMinimoPuestosDataGridViewTextBoxColumn.Name = "salarioMinimoPuestosDataGridViewTextBoxColumn";
            // 
            // salarioMaximoPuestosDataGridViewTextBoxColumn
            // 
            this.salarioMaximoPuestosDataGridViewTextBoxColumn.DataPropertyName = "SalarioMaximo_Puestos";
            this.salarioMaximoPuestosDataGridViewTextBoxColumn.HeaderText = "Salario Maximo";
            this.salarioMaximoPuestosDataGridViewTextBoxColumn.Name = "salarioMaximoPuestosDataGridViewTextBoxColumn";
            // 
            // estadoPuestosDataGridViewCheckBoxColumn
            // 
            this.estadoPuestosDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Puestos";
            this.estadoPuestosDataGridViewCheckBoxColumn.HeaderText = "Estado_Puestos";
            this.estadoPuestosDataGridViewCheckBoxColumn.Name = "estadoPuestosDataGridViewCheckBoxColumn";
            this.estadoPuestosDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FrmGestionPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestionPuestos";
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.FrmGestionPuestos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvPuestos;
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private RRHHDataSetTableAdapters.PuestosTableAdapter puestosTableAdapter;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePuestosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamentoPuestosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelRiesgoPuestosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioMinimoPuestosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioMaximoPuestosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoPuestosDataGridViewCheckBoxColumn;
    }
}