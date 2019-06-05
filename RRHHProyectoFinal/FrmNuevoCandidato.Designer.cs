namespace RRHHProyectoFinal
{
    partial class FrmNuevoCandidato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LtbIdiomas = new System.Windows.Forms.ListBox();
            this.idiomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvCapacitaciones = new System.Windows.Forms.DataGridView();
            this.idCapacitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institucionCapacitacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LtbCompetencias = new System.Windows.Forms.ListBox();
            this.competenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRecomendacion = new System.Windows.Forms.TextBox();
            this.NudSalario = new System.Windows.Forms.NumericUpDown();
            this.LtbPuestos = new System.Windows.Forms.ListBox();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capacitacionesTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.CapacitacionesTableAdapter();
            this.puestosTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.PuestosTableAdapter();
            this.competenciasTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.CompetenciasTableAdapter();
            this.idiomasTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.IdiomasTableAdapter();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExpLaborales = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCapacitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 403);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LtbIdiomas);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(493, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 176);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Idiomas";
            // 
            // LtbIdiomas
            // 
            this.LtbIdiomas.DataSource = this.idiomasBindingSource;
            this.LtbIdiomas.DisplayMember = "Nombre_Idiomas";
            this.LtbIdiomas.FormattingEnabled = true;
            this.LtbIdiomas.ItemHeight = 18;
            this.LtbIdiomas.Location = new System.Drawing.Point(10, 59);
            this.LtbIdiomas.Name = "LtbIdiomas";
            this.LtbIdiomas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LtbIdiomas.Size = new System.Drawing.Size(205, 94);
            this.LtbIdiomas.TabIndex = 1;
            this.LtbIdiomas.ValueMember = "IdIdioma";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Seleccione uno o mas idiomas:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvCapacitaciones);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 174);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Capacitaciones";
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
            this.DgvCapacitaciones.Location = new System.Drawing.Point(10, 20);
            this.DgvCapacitaciones.Name = "DgvCapacitaciones";
            this.DgvCapacitaciones.ReadOnly = true;
            this.DgvCapacitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCapacitaciones.Size = new System.Drawing.Size(467, 150);
            this.DgvCapacitaciones.TabIndex = 0;
            // 
            // idCapacitacionDataGridViewTextBoxColumn
            // 
            this.idCapacitacionDataGridViewTextBoxColumn.DataPropertyName = "IdCapacitacion";
            this.idCapacitacionDataGridViewTextBoxColumn.HeaderText = "IdCapacitacion";
            this.idCapacitacionDataGridViewTextBoxColumn.Name = "idCapacitacionDataGridViewTextBoxColumn";
            this.idCapacitacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCapacitacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcionCapacitacionesDataGridViewTextBoxColumn
            // 
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Capacitaciones";
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.Name = "descripcionCapacitacionesDataGridViewTextBoxColumn";
            this.descripcionCapacitacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelCapacitacionesDataGridViewTextBoxColumn
            // 
            this.nivelCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "Nivel_Capacitaciones";
            this.nivelCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Nivel";
            this.nivelCapacitacionesDataGridViewTextBoxColumn.Name = "nivelCapacitacionesDataGridViewTextBoxColumn";
            this.nivelCapacitacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDesdeCapacitacionesDataGridViewTextBoxColumn
            // 
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde_Capacitaciones";
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.Name = "fechaDesdeCapacitacionesDataGridViewTextBoxColumn";
            this.fechaDesdeCapacitacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHastaCapacitacionesDataGridViewTextBoxColumn
            // 
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "FechaHasta_Capacitaciones";
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Hasta";
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.Name = "fechaHastaCapacitacionesDataGridViewTextBoxColumn";
            this.fechaHastaCapacitacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // institucionCapacitacionesDataGridViewTextBoxColumn
            // 
            this.institucionCapacitacionesDataGridViewTextBoxColumn.DataPropertyName = "Institucion_Capacitaciones";
            this.institucionCapacitacionesDataGridViewTextBoxColumn.HeaderText = "Institucion";
            this.institucionCapacitacionesDataGridViewTextBoxColumn.Name = "institucionCapacitacionesDataGridViewTextBoxColumn";
            this.institucionCapacitacionesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacitacionesBindingSource
            // 
            this.capacitacionesBindingSource.DataMember = "Capacitaciones";
            this.capacitacionesBindingSource.DataSource = this.rRHHDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LtbCompetencias);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(445, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Competencias";
            // 
            // LtbCompetencias
            // 
            this.LtbCompetencias.DataSource = this.competenciasBindingSource;
            this.LtbCompetencias.DisplayMember = "Descripcion_Competencias";
            this.LtbCompetencias.FormattingEnabled = true;
            this.LtbCompetencias.ItemHeight = 18;
            this.LtbCompetencias.Location = new System.Drawing.Point(10, 57);
            this.LtbCompetencias.Name = "LtbCompetencias";
            this.LtbCompetencias.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LtbCompetencias.Size = new System.Drawing.Size(253, 94);
            this.LtbCompetencias.TabIndex = 1;
            this.LtbCompetencias.ValueMember = "IdCompetencia";
            // 
            // competenciasBindingSource
            // 
            this.competenciasBindingSource.DataMember = "Competencias";
            this.competenciasBindingSource.DataSource = this.rRHHDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione una o mas competencias:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRecomendacion);
            this.groupBox1.Controls.Add(this.NudSalario);
            this.groupBox1.Controls.Add(this.LtbPuestos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidato";
            // 
            // TxtRecomendacion
            // 
            this.TxtRecomendacion.Location = new System.Drawing.Point(198, 89);
            this.TxtRecomendacion.Multiline = true;
            this.TxtRecomendacion.Name = "TxtRecomendacion";
            this.TxtRecomendacion.Size = new System.Drawing.Size(218, 63);
            this.TxtRecomendacion.TabIndex = 5;
            // 
            // NudSalario
            // 
            this.NudSalario.DecimalPlaces = 2;
            this.NudSalario.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudSalario.Location = new System.Drawing.Point(280, 23);
            this.NudSalario.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudSalario.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudSalario.Name = "NudSalario";
            this.NudSalario.Size = new System.Drawing.Size(120, 24);
            this.NudSalario.TabIndex = 4;
            this.NudSalario.ThousandsSeparator = true;
            this.NudSalario.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // LtbPuestos
            // 
            this.LtbPuestos.DataSource = this.puestosBindingSource;
            this.LtbPuestos.DisplayMember = "Nombre_Puestos";
            this.LtbPuestos.FormattingEnabled = true;
            this.LtbPuestos.ItemHeight = 18;
            this.LtbPuestos.Location = new System.Drawing.Point(10, 49);
            this.LtbPuestos.Name = "LtbPuestos";
            this.LtbPuestos.Size = new System.Drawing.Size(179, 94);
            this.LtbPuestos.TabIndex = 3;
            this.LtbPuestos.ValueMember = "IdPuesto";
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataMember = "Puestos";
            this.puestosBindingSource.DataSource = this.rRHHDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recomendacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puesto:";
            // 
            // capacitacionesTableAdapter
            // 
            this.capacitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // puestosTableAdapter
            // 
            this.puestosTableAdapter.ClearBeforeFill = true;
            // 
            // competenciasTableAdapter
            // 
            this.competenciasTableAdapter.ClearBeforeFill = true;
            // 
            // idiomasTableAdapter
            // 
            this.idiomasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(507, 422);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(102, 57);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Guardar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(640, 422);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(102, 57);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnExpLaborales
            // 
            this.BtnExpLaborales.Location = new System.Drawing.Point(18, 422);
            this.BtnExpLaborales.Name = "BtnExpLaborales";
            this.BtnExpLaborales.Size = new System.Drawing.Size(163, 56);
            this.BtnExpLaborales.TabIndex = 3;
            this.BtnExpLaborales.Text = " Experiencias Laborales";
            this.BtnExpLaborales.UseVisualStyleBackColor = true;
            this.BtnExpLaborales.Click += new System.EventHandler(this.BtnExpLaborales_Click);
            // 
            // FrmNuevoCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 491);
            this.Controls.Add(this.BtnExpLaborales);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmNuevoCandidato";
            this.Text = "Nuevo Candidato";
            this.Load += new System.EventHandler(this.FrmNuevoCandidato_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCapacitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capacitacionesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competenciasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvCapacitaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox LtbCompetencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRecomendacion;
        private System.Windows.Forms.NumericUpDown NudSalario;
        private System.Windows.Forms.ListBox LtbPuestos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource capacitacionesBindingSource;
        private RRHHDataSetTableAdapters.CapacitacionesTableAdapter capacitacionesTableAdapter;
        private System.Windows.Forms.ListBox LtbIdiomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCapacitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesdeCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHastaCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn institucionCapacitacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private RRHHDataSetTableAdapters.PuestosTableAdapter puestosTableAdapter;
        private System.Windows.Forms.BindingSource competenciasBindingSource;
        private RRHHDataSetTableAdapters.CompetenciasTableAdapter competenciasTableAdapter;
        private System.Windows.Forms.BindingSource idiomasBindingSource;
        private RRHHDataSetTableAdapters.IdiomasTableAdapter idiomasTableAdapter;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExpLaborales;
    }
}