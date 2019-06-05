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
    public partial class FrmGestionCapacitaciones : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmGestionCapacitaciones()
        {
            InitializeComponent();
        }

        private void FrmGestionCapacitaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Capacitaciones' Puede moverla o quitarla según sea necesario.
            LoadData();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCapacitaciones frmAgregarCapacitaciones = new FrmAgregarCapacitaciones();
            Hide();
            frmAgregarCapacitaciones.ShowDialog();
            Show();
            LoadData();
        }

        public void LoadData()
        {
            var capacitaciones = entities.Capacitaciones.ToList();
            DgvCapacitaciones.DataSource = capacitaciones;
            DgvCapacitaciones.Refresh();
            DgvCapacitaciones.Update();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int row = DgvCapacitaciones.CurrentCell.RowIndex;
            int idCapacitaciones = (int)DgvCapacitaciones[0, row].Value;
            var CapacitacionBorrada = entities.Capacitaciones
                .Where(p => p.IdCapacitacion.Equals(idCapacitaciones)).FirstOrDefault();
            entities.Capacitaciones.Remove(CapacitacionBorrada);
            entities.SaveChanges();
            MessageBox.Show("Registro borrado con exito!");
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
