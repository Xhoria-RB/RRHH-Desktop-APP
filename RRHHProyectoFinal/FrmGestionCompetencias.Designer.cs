namespace RRHHProyectoFinal
{
    partial class FrmGestionCompetencias
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
            this.competenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.competenciasTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.CompetenciasTableAdapter();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvCompetencias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idCompetenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCompetenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCompetenciasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // competenciasBindingSource
            // 
            this.competenciasBindingSource.DataMember = "Competencias";
            this.competenciasBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // competenciasTableAdapter
            // 
            this.competenciasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(476, 460);
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
            this.panel1.Controls.Add(this.DgvCompetencias);
            this.panel1.Location = new System.Drawing.Point(12, 76);
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
            // DgvCompetencias
            // 
            this.DgvCompetencias.AllowUserToAddRows = false;
            this.DgvCompetencias.AllowUserToDeleteRows = false;
            this.DgvCompetencias.AutoGenerateColumns = false;
            this.DgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompetenciaDataGridViewTextBoxColumn,
            this.descripcionCompetenciasDataGridViewTextBoxColumn,
            this.estadoCompetenciasDataGridViewCheckBoxColumn});
            this.DgvCompetencias.DataSource = this.competenciasBindingSource;
            this.DgvCompetencias.Location = new System.Drawing.Point(3, -1);
            this.DgvCompetencias.MultiSelect = false;
            this.DgvCompetencias.Name = "DgvCompetencias";
            this.DgvCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCompetencias.Size = new System.Drawing.Size(592, 319);
            this.DgvCompetencias.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestion de Competencias";
            // 
            // idCompetenciaDataGridViewTextBoxColumn
            // 
            this.idCompetenciaDataGridViewTextBoxColumn.DataPropertyName = "IdCompetencia";
            this.idCompetenciaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCompetenciaDataGridViewTextBoxColumn.Name = "idCompetenciaDataGridViewTextBoxColumn";
            this.idCompetenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionCompetenciasDataGridViewTextBoxColumn
            // 
            this.descripcionCompetenciasDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Competencias";
            this.descripcionCompetenciasDataGridViewTextBoxColumn.HeaderText = "Competencias";
            this.descripcionCompetenciasDataGridViewTextBoxColumn.Name = "descripcionCompetenciasDataGridViewTextBoxColumn";
            // 
            // estadoCompetenciasDataGridViewCheckBoxColumn
            // 
            this.estadoCompetenciasDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Competencias";
            this.estadoCompetenciasDataGridViewCheckBoxColumn.HeaderText = "Estado_Competencias";
            this.estadoCompetenciasDataGridViewCheckBoxColumn.Name = "estadoCompetenciasDataGridViewCheckBoxColumn";
            this.estadoCompetenciasDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FrmGestionCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionCompetencias";
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.FrmGestionCompetencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource competenciasBindingSource;
        private RRHHDataSetTableAdapters.CompetenciasTableAdapter competenciasTableAdapter;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvCompetencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCompetenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoCompetenciasDataGridViewCheckBoxColumn;
    }
}