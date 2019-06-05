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
    public partial class FrmGestionCompetencias : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmGestionCompetencias()
        {
            InitializeComponent();
        }

        private void FrmGestionCompetencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Competencias' Puede moverla o quitarla según sea necesario.
            LoadData();

        }

        public void LoadData()
        {
            var competencias = entities.Competencias.Where(p => p.Estado_Competencias == true);
            DgvCompetencias.DataSource = competencias.ToList();
            DgvCompetencias.Refresh();
            DgvCompetencias.Update();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCompetencias frmAgregarCompetencias = new FrmAgregarCompetencias();
            Hide();
            frmAgregarCompetencias.ShowDialog();
            Show();
            LoadData();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int row = DgvCompetencias.CurrentCell.RowIndex;
            int idCompetencia = (int)DgvCompetencias[0, row].Value;
            var competenciaBorrada = entities.Competencias
                .Where(p => p.IdCompetencia.Equals(idCompetencia)).FirstOrDefault();
            competenciaBorrada.Estado_Competencias = false;
            entities.SaveChanges();
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
