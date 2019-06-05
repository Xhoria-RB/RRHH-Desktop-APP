namespace RRHHProyectoFinal
{
    partial class FrmInicioCandidato
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRegistrarCandidato = new System.Windows.Forms.Button();
            this.BtnRegistrarExp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.CmdCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegistrarCandidato
            // 
            this.BtnRegistrarCandidato.Location = new System.Drawing.Point(116, 68);
            this.BtnRegistrarCandidato.Name = "BtnRegistrarCandidato";
            this.BtnRegistrarCandidato.Size = new System.Drawing.Size(171, 85);
            this.BtnRegistrarCandidato.TabIndex = 0;
            this.BtnRegistrarCandidato.Text = "&Solicitar Puesto";
            this.BtnRegistrarCandidato.UseVisualStyleBackColor = true;
            this.BtnRegistrarCandidato.Click += new System.EventHandler(this.BtnRegistrarCandidato_Click);
            // 
            // BtnRegistrarExp
            // 
            this.BtnRegistrarExp.Location = new System.Drawing.Point(116, 213);
            this.BtnRegistrarExp.Name = "BtnRegistrarExp";
            this.BtnRegistrarExp.Size = new System.Drawing.Size(171, 85);
            this.BtnRegistrarExp.TabIndex = 1;
            this.BtnRegistrarExp.Text = "&Experiencia Laboral";
            this.BtnRegistrarExp.UseVisualStyleBackColor = true;
            this.BtnRegistrarExp.Click += new System.EventHandler(this.BtnRegistrarExp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido: ";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(86, 13);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(57, 13);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "UserName";
            // 
            // CmdCerrarSesion
            // 
            this.CmdCerrarSesion.Location = new System.Drawing.Point(299, 338);
            this.CmdCerrarSesion.Name = "CmdCerrarSesion";
            this.CmdCerrarSesion.Size = new System.Drawing.Size(97, 33);
            this.CmdCerrarSesion.TabIndex = 4;
            this.CmdCerrarSesion.Text = "Cerrar Sesion";
            this.CmdCerrarSesion.UseVisualStyleBackColor = true;
            this.CmdCerrarSesion.Click += new System.EventHandler(this.CmdCerrarSesion_Click);
            // 
            // FrmInicioCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 385);
            this.Controls.Add(this.CmdCerrarSesion);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRegistrarExp);
            this.Controls.Add(this.BtnRegistrarCandidato);
            this.Name = "FrmInicioCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Candidato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInicioCandidato_FormClosing);
            this.Load += new System.EventHandler(this.FrmInicioCandidato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegistrarCandidato;
        private System.Windows.Forms.Button BtnRegistrarExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button CmdCerrarSesion;
    }
}

