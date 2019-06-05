namespace RRHHProyectoFinal
{
    partial class FrmGestionIdiomas
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
            this.idiomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.idiomasTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.IdiomasTableAdapter();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvIdiomas = new System.Windows.Forms.DataGridView();
            this.idIdiomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreIdiomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoIdiomasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // idiomasBindingSource
            // 
            this.idiomasBindingSource.DataMember = "Idiomas";
            this.idiomasBindingSource.DataSource = this.rRHHDataSet;
            // 
            // rRHHDataSet
            // 
            this.rRHHDataSet.DataSetName = "RRHHDataSet";
            this.rRHHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomasTableAdapter
            // 
            this.idiomasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(476, 461);
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
            this.panel1.Controls.Add(this.DgvIdiomas);
            this.panel1.Location = new System.Drawing.Point(12, 77);
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
            // DgvIdiomas
            // 
            this.DgvIdiomas.AllowUserToAddRows = false;
            this.DgvIdiomas.AllowUserToDeleteRows = false;
            this.DgvIdiomas.AutoGenerateColumns = false;
            this.DgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIdiomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idIdiomaDataGridViewTextBoxColumn,
            this.nombreIdiomasDataGridViewTextBoxColumn,
            this.estadoIdiomasDataGridViewCheckBoxColumn});
            this.DgvIdiomas.DataSource = this.idiomasBindingSource;
            this.DgvIdiomas.Location = new System.Drawing.Point(3, -1);
            this.DgvIdiomas.MultiSelect = false;
            this.DgvIdiomas.Name = "DgvIdiomas";
            this.DgvIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIdiomas.Size = new System.Drawing.Size(592, 319);
            this.DgvIdiomas.TabIndex = 1;
            // 
            // idIdiomaDataGridViewTextBoxColumn
            // 
            this.idIdiomaDataGridViewTextBoxColumn.DataPropertyName = "IdIdioma";
            this.idIdiomaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idIdiomaDataGridViewTextBoxColumn.Name = "idIdiomaDataGridViewTextBoxColumn";
            this.idIdiomaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreIdiomasDataGridViewTextBoxColumn
            // 
            this.nombreIdiomasDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Idiomas";
            this.nombreIdiomasDataGridViewTextBoxColumn.HeaderText = "Idiomas";
            this.nombreIdiomasDataGridViewTextBoxColumn.Name = "nombreIdiomasDataGridViewTextBoxColumn";
            // 
            // estadoIdiomasDataGridViewCheckBoxColumn
            // 
            this.estadoIdiomasDataGridViewCheckBoxColumn.DataPropertyName = "Estado_Idiomas";
            this.estadoIdiomasDataGridViewCheckBoxColumn.HeaderText = "Estado_Idiomas";
            this.estadoIdiomasDataGridViewCheckBoxColumn.Name = "estadoIdiomasDataGridViewCheckBoxColumn";
            this.estadoIdiomasDataGridViewCheckBoxColumn.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestion de Idiomas";
            // 
            // FrmGestionIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 518);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionIdiomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idiomas";
            this.Load += new System.EventHandler(this.FrmGestionIdiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdiomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource idiomasBindingSource;
        private RRHHDataSetTableAdapters.IdiomasTableAdapter idiomasTableAdapter;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvIdiomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idIdiomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreIdiomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoIdiomasDataGridViewCheckBoxColumn;
    }
}