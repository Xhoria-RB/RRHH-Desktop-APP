namespace RRHHProyectoFinal
{
    partial class FrmAgregarPuestos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxNivelRiesgo = new System.Windows.Forms.ComboBox();
            this.NudSalarioMaximo = new System.Windows.Forms.NumericUpDown();
            this.NudSalarioMinimo = new System.Windows.Forms.NumericUpDown();
            this.CbxDepartamento = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalarioMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalarioMinimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo puesto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CbxNivelRiesgo);
            this.panel1.Controls.Add(this.NudSalarioMaximo);
            this.panel1.Controls.Add(this.NudSalarioMinimo);
            this.panel1.Controls.Add(this.CbxDepartamento);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 226);
            this.panel1.TabIndex = 1;
            // 
            // CbxNivelRiesgo
            // 
            this.CbxNivelRiesgo.FormattingEnabled = true;
            this.CbxNivelRiesgo.Items.AddRange(new object[] {
            "Bajo",
            "Medio",
            "Alto"});
            this.CbxNivelRiesgo.Location = new System.Drawing.Point(126, 165);
            this.CbxNivelRiesgo.Name = "CbxNivelRiesgo";
            this.CbxNivelRiesgo.Size = new System.Drawing.Size(121, 21);
            this.CbxNivelRiesgo.TabIndex = 9;
            // 
            // NudSalarioMaximo
            // 
            this.NudSalarioMaximo.DecimalPlaces = 2;
            this.NudSalarioMaximo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudSalarioMaximo.Location = new System.Drawing.Point(381, 114);
            this.NudSalarioMaximo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudSalarioMaximo.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NudSalarioMaximo.Name = "NudSalarioMaximo";
            this.NudSalarioMaximo.Size = new System.Drawing.Size(121, 20);
            this.NudSalarioMaximo.TabIndex = 8;
            this.NudSalarioMaximo.ThousandsSeparator = true;
            this.NudSalarioMaximo.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // NudSalarioMinimo
            // 
            this.NudSalarioMinimo.DecimalPlaces = 2;
            this.NudSalarioMinimo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudSalarioMinimo.Location = new System.Drawing.Point(126, 114);
            this.NudSalarioMinimo.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NudSalarioMinimo.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudSalarioMinimo.Name = "NudSalarioMinimo";
            this.NudSalarioMinimo.Size = new System.Drawing.Size(124, 20);
            this.NudSalarioMinimo.TabIndex = 7;
            this.NudSalarioMinimo.ThousandsSeparator = true;
            this.NudSalarioMinimo.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // CbxDepartamento
            // 
            this.CbxDepartamento.FormattingEnabled = true;
            this.CbxDepartamento.Location = new System.Drawing.Point(376, 56);
            this.CbxDepartamento.Name = "CbxDepartamento";
            this.CbxDepartamento.Size = new System.Drawing.Size(126, 21);
            this.CbxDepartamento.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(85, 59);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(162, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nivel de riesgo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(268, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Salario maximo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salario minimo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(271, 341);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(111, 49);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(420, 341);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(111, 49);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmAgregarPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 402);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarPuestos";
            this.Text = "Agregar Puestos";
            this.Load += new System.EventHandler(this.FrmAgregarPuestos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalarioMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalarioMinimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CbxNivelRiesgo;
        private System.Windows.Forms.NumericUpDown NudSalarioMaximo;
        private System.Windows.Forms.NumericUpDown NudSalarioMinimo;
        private System.Windows.Forms.ComboBox CbxDepartamento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}