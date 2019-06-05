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
            this.label1 = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.CmdCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegistrarCandidato
            // 
            this.BtnRegistrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarCandidato.Location = new System.Drawing.Point(110, 76);
            this.BtnRegistrarCandidato.Name = "BtnRegistrarCandidato";
            this.BtnRegistrarCandidato.Size = new System.Drawing.Size(171, 85);
            this.BtnRegistrarCandidato.TabIndex = 0;
            this.BtnRegistrarCandidato.Text = "&Solicitar Puesto";
            this.BtnRegistrarCandidato.UseVisualStyleBackColor = true;
            this.BtnRegistrarCandidato.Click += new System.EventHandler(this.BtnRegistrarCandidato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(107, 13);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(80, 18);
            this.LblUsername.TabIndex = 3;
            this.LblUsername.Text = "UserName";
            this.LblUsername.Click += new System.EventHandler(this.LblUsername_Click);
            // 
            // CmdCerrarSesion
            // 
            this.CmdCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCerrarSesion.Location = new System.Drawing.Point(299, 194);
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
            this.ClientSize = new System.Drawing.Size(408, 249);
            this.Controls.Add(this.CmdCerrarSesion);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Button CmdCerrarSesion;
    }
}

