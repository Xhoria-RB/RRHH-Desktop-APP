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
    public partial class FrmGestionDepartamento : Form
    {
        RRHHEntities entities = new RRHHEntities();

        public FrmGestionDepartamento()
        {
            InitializeComponent();
        }

        private void FrmGestionDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            LoadData();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarDepartamentos frmAgregarDepartamentos = new FrmAgregarDepartamentos();
            Hide();
            frmAgregarDepartamentos.ShowDialog();
            Show();
            LoadData();
        }

        public void LoadData()
        {
            var departamentos = entities.Departamentos.Where(p => p.Estado_Departamentos == true);
            DgvDepartamentos.DataSource = departamentos.ToList();
            DgvDepartamentos.Refresh();
            DgvDepartamentos.Update();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int row = DgvDepartamentos.CurrentCell.RowIndex;
            int IdDepartamento = (int)DgvDepartamentos[0, row].Value;
            var departamentoBorrado = entities.Departamentos
                .Where(p => p.IdDepartamento.Equals(IdDepartamento)).FirstOrDefault();
            departamentoBorrado.Estado_Departamentos = false;
            entities.SaveChanges();
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
