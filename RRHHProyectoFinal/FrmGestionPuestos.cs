using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHProyectoFinal
{
    public partial class FrmGestionPuestos : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmGestionPuestos()
        {
            InitializeComponent();
        }

        private void FrmGestionPuestos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Puestos' Puede moverla o quitarla según sea necesario.
            //this.puestosTableAdapter.Fill(this.rRHHDataSet.Puestos);
            LoadData();
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarPuestos frmAgregarPuestos = new FrmAgregarPuestos();
            Hide();
            frmAgregarPuestos.ShowDialog();
            LoadData();
            Show();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int row = DgvPuestos.CurrentCell.RowIndex;
            int puestoId = (int)DgvPuestos[0,row].Value;
            var puestoBorrado = entities.Puestos.Where(p => p.IdPuesto.Equals(puestoId)).FirstOrDefault();
            puestoBorrado.Estado_Puestos = false;
            entities.SaveChanges();
            MessageBox.Show("Done");
            LoadData();

        }

        public void LoadData()
        {
            var puestos = entities.Puestos.Where(p => p.Estado_Puestos == true);
            DgvPuestos.DataSource = puestos.ToList();
            DgvPuestos.Refresh();
            DgvPuestos.Update();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
