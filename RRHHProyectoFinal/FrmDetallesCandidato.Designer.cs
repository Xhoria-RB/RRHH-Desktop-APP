namespace RRHHProyectoFinal
{
    partial class FrmDetallesCandidato
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtRecomendacion = new System.Windows.Forms.TextBox();
            this.TxtSalarioAsp = new System.Windows.Forms.TextBox();
            this.TxtPuestoAsp = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtSexo = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvIdiomas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvCompetencias = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgvExpLaborales = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvCapacitaciones = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnContratar = new System.Windows.Forms.Button();
            this.CbxPuesto = new System.Windows.Forms.ComboBox();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rRHHDataSet = new RRHHProyectoFinal.RRHHDataSet();
            this.NudSalario = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.puestosTableAdapter = new RRHHProyectoFinal.RRHHDataSetTableAdapters.PuestosTableAdapter();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdiomas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompetencias)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpLaborales)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCapacitaciones)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtRecomendacion);
            this.groupBox1.Controls.Add(this.TxtSalarioAsp);
            this.groupBox1.Controls.Add(this.TxtPuestoAsp);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.TxtSexo);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // TxtRecomendacion
            // 
            this.TxtRecomendacion.Location = new System.Drawing.Point(132, 202);
            this.TxtRecomendacion.Multiline = true;
            this.TxtRecomendacion.Name = "TxtRecomendacion";
            this.TxtRecomendacion.ReadOnly = true;
            this.TxtRecomendacion.Size = new System.Drawing.Size(266, 68);
            this.TxtRecomendacion.TabIndex = 13;
            // 
            // TxtSalarioAsp
            // 
            this.TxtSalarioAsp.Location = new System.Drawing.Point(132, 158);
            this.TxtSalarioAsp.Name = "TxtSalarioAsp";
            this.TxtSalarioAsp.ReadOnly = true;
            this.TxtSalarioAsp.Size = new System.Drawing.Size(144, 24);
            this.TxtSalarioAsp.TabIndex = 12;
            // 
            // TxtPuestoAsp
            // 
            this.TxtPuestoAsp.Location = new System.Drawing.Point(132, 122);
            this.TxtPuestoAsp.Name = "TxtPuestoAsp";
            this.TxtPuestoAsp.ReadOnly = true;
            this.TxtPuestoAsp.Size = new System.Drawing.Size(144, 24);
            this.TxtPuestoAsp.TabIndex = 11;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(262, 70);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.ReadOnly = true;
            this.TxtCedula.Size = new System.Drawing.Size(136, 24);
            this.TxtCedula.TabIndex = 10;
            // 
            // TxtSexo
            // 
            this.TxtSexo.Location = new System.Drawing.Point(75, 70);
            this.TxtSexo.Name = "TxtSexo";
            this.TxtSexo.ReadOnly = true;
            this.TxtSexo.Size = new System.Drawing.Size(100, 24);
            this.TxtSexo.TabIndex = 9;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(262, 27);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.ReadOnly = true;
            this.TxtApellido.Size = new System.Drawing.Size(100, 24);
            this.TxtApellido.TabIndex = 8;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(75, 30);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(100, 24);
            this.TxtNombre.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Recomendacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salario aspirado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puesto aspirado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cedula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvIdiomas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(511, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Idiomas";
            // 
            // DgvIdiomas
            // 
            this.DgvIdiomas.AllowUserToAddRows = false;
            this.DgvIdiomas.AllowUserToDeleteRows = false;
            this.DgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIdiomas.Location = new System.Drawing.Point(7, 20);
            this.DgvIdiomas.Name = "DgvIdiomas";
            this.DgvIdiomas.ReadOnly = true;
            this.DgvIdiomas.Size = new System.Drawing.Size(433, 118);
            this.DgvIdiomas.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvCompetencias);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(510, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Competencias";
            // 
            // DgvCompetencias
            // 
            this.DgvCompetencias.AllowUserToAddRows = false;
            this.DgvCompetencias.AllowUserToDeleteRows = false;
            this.DgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompetencias.Location = new System.Drawing.Point(6, 19);
            this.DgvCompetencias.Name = "DgvCompetencias";
            this.DgvCompetencias.ReadOnly = true;
            this.DgvCompetencias.Size = new System.Drawing.Size(433, 118);
            this.DgvCompetencias.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 599);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DgvExpLaborales);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(450, 326);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 257);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Experiencias Laborales";
            // 
            // DgvExpLaborales
            // 
            this.DgvExpLaborales.AllowUserToAddRows = false;
            this.DgvExpLaborales.AllowUserToDeleteRows = false;
            this.DgvExpLaborales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpLaborales.Location = new System.Drawing.Point(10, 19);
            this.DgvExpLaborales.Name = "DgvExpLaborales";
            this.DgvExpLaborales.ReadOnly = true;
            this.DgvExpLaborales.Size = new System.Drawing.Size(399, 232);
            this.DgvExpLaborales.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvCapacitaciones);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(4, 326);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 257);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Capacitaciones";
            // 
            // DgvCapacitaciones
            // 
            this.DgvCapacitaciones.AllowUserToAddRows = false;
            this.DgvCapacitaciones.AllowUserToDeleteRows = false;
            this.DgvCapacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCapacitaciones.Location = new System.Drawing.Point(6, 19);
            this.DgvCapacitaciones.Name = "DgvCapacitaciones";
            this.DgvCapacitaciones.ReadOnly = true;
            this.DgvCapacitaciones.Size = new System.Drawing.Size(428, 232);
            this.DgvCapacitaciones.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnContratar);
            this.groupBox6.Controls.Add(this.CbxPuesto);
            this.groupBox6.Controls.Add(this.NudSalario);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(13, 624);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(403, 99);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Contratar candidato";
            // 
            // BtnContratar
            // 
            this.BtnContratar.Location = new System.Drawing.Point(267, 26);
            this.BtnContratar.Name = "BtnContratar";
            this.BtnContratar.Size = new System.Drawing.Size(110, 51);
            this.BtnContratar.TabIndex = 19;
            this.BtnContratar.Text = "Contratar";
            this.BtnContratar.UseVisualStyleBackColor = true;
            this.BtnContratar.Click += new System.EventHandler(this.BtnContratar_Click);
            // 
            // CbxPuesto
            // 
            this.CbxPuesto.DataSource = this.puestosBindingSource;
            this.CbxPuesto.DisplayMember = "Nombre_Puestos";
            this.CbxPuesto.FormattingEnabled = true;
            this.CbxPuesto.Location = new System.Drawing.Point(72, 55);
            this.CbxPuesto.Name = "CbxPuesto";
            this.CbxPuesto.Size = new System.Drawing.Size(161, 26);
            this.CbxPuesto.TabIndex = 18;
            this.CbxPuesto.ValueMember = "IdPuesto";
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
            // NudSalario
            // 
            this.NudSalario.DecimalPlaces = 2;
            this.NudSalario.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudSalario.Location = new System.Drawing.Point(71, 23);
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
            this.NudSalario.TabIndex = 17;
            this.NudSalario.ThousandsSeparator = true;
            this.NudSalario.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Puesto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salario:";
            // 
            // puestosTableAdapter
            // 
            this.puestosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(774, 668);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 51);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmDetallesCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 734);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetallesCandidato";
            this.Text = "Detalles Candidato";
            this.Load += new System.EventHandler(this.FrmDetallesCandidato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvIdiomas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompetencias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpLaborales)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCapacitaciones)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rRHHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRecomendacion;
        private System.Windows.Forms.TextBox TxtSalarioAsp;
        private System.Windows.Forms.TextBox TxtPuestoAsp;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtSexo;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvIdiomas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvCompetencias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgvExpLaborales;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvCapacitaciones;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox CbxPuesto;
        private System.Windows.Forms.NumericUpDown NudSalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private RRHHDataSet rRHHDataSet;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private RRHHDataSetTableAdapters.PuestosTableAdapter puestosTableAdapter;
        private System.Windows.Forms.Button BtnContratar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}