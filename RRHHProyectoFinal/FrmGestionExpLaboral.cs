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
    public partial class FrmGestionExpLaboral : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmGestionExpLaboral()
        {
            InitializeComponent();
        }

        private void FrmGestionExpLaboral_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.ExpLaborales' Puede moverla o quitarla según sea necesario.
            //this.expLaboralesTableAdapter.Fill(this.rRHHDataSet.ExpLaborales);

            LoadData();

        }

        public void LoadData()
        {
            var expLaboral = entities.ExpLaborales.Where(p => p.IdPersona_ExpLaboral.Equals(Global.GlobalPersonID));
            DgvExpLaboral.DataSource = expLaboral.ToList();
            DgvExpLaboral.Refresh();
            DgvExpLaboral.Update();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarExpLaboral frmAgregarExpLaboral = new FrmAgregarExpLaboral();
            Hide();
            frmAgregarExpLaboral.ShowDialog();
            LoadData();
            Show();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int row = DgvExpLaboral.CurrentCell.RowIndex;
            int expLaboralID = (int)DgvExpLaboral[0, row].Value;
            var expLaboralBorrada = entities.ExpLaborales.Where(p => p.IdExpLaboral.Equals(expLaboralID)).FirstOrDefault();
            entities.ExpLaborales.Remove(expLaboralBorrada);
            entities.SaveChanges();
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
