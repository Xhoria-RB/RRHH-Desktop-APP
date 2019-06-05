using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHProyectoFinal
{
    public partial class FrmInicioCandidato : Form
    {
        public FrmInicioCandidato()
        {
            InitializeComponent();
        }

        private void FrmInicioCandidato_Load(object sender, EventArgs e)
        {
            LblUsername.Text = Global.GlobalUserName;
        }

        private void FrmInicioCandidato_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void CmdCerrarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnRegistrarExp_Click(object sender, EventArgs e)
        {
            FrmGestionExpLaboral frmGestionExpLaboral = new FrmGestionExpLaboral();
            Hide();
            frmGestionExpLaboral.ShowDialog();
            Show();
        }

        private void BtnRegistrarCandidato_Click(object sender, EventArgs e)
        {
            FrmNuevoCandidato frmNuevoCandidato = new FrmNuevoCandidato();
            Hide();
            frmNuevoCandidato.ShowDialog();
            Show();
        }
    }
}
