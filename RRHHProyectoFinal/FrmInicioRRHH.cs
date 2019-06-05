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
    public partial class FrmInicioRRHH : Form
    {
        public FrmInicioRRHH()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmInicioRRHH_Load(object sender, EventArgs e)
        {
            LblUsername.Text = Global.GlobalUserName;
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionPuestos frmGestionPuestos = new FrmGestionPuestos();
            Hide();
            frmGestionPuestos.ShowDialog();
            Show();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionIdiomas frmGestionIdiomas = new FrmGestionIdiomas();
            Hide();
            frmGestionIdiomas.ShowDialog();
            Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionDepartamento frmGestionDepartamento = new FrmGestionDepartamento();
            Hide();
            frmGestionDepartamento.ShowDialog();
            Show();
        }

        private void capacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCapacitaciones frmGestionCapacitaciones = new FrmGestionCapacitaciones();
            Hide();
            frmGestionCapacitaciones.ShowDialog();
            Show();
        }

        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCompetencias frmGestionCompetencias = new FrmGestionCompetencias();
            Hide();
            frmGestionCompetencias.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSeleccionCandidato frmSeleccionCandidato = new FrmSeleccionCandidato();
            Hide();
            frmSeleccionCandidato.ShowDialog();
            Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporte frmReporte = new FrmReporte();
            Hide();
            frmReporte.ShowDialog();
            Show();
        }
    }
}
