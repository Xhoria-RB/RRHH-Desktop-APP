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
    public partial class FrmGestionIdiomas : Form
    {
        RRHHEntities entities = new RRHHEntities();

        public FrmGestionIdiomas()
        {
            InitializeComponent();
        }

        private void FrmGestionIdiomas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Idiomas' Puede moverla o quitarla según sea necesario.
            LoadData();

        }

        public void LoadData()
        {
            var idiomas = entities.Idiomas.Where(p => p.Estado_Idiomas == true);
            DgvIdiomas.DataSource = idiomas.ToList();
            DgvIdiomas.Refresh();
            DgvIdiomas.Update();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarIdiomas frmAgregarIdiomas = new FrmAgregarIdiomas();
            frmAgregarIdiomas.ShowDialog();
            LoadData();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int row = DgvIdiomas.CurrentCell.RowIndex;
            int idIdiomaBorrado = (int)DgvIdiomas[0, row].Value;
            var idiomaBorrado = entities.Idiomas.Where(p => p.IdIdioma.Equals(idIdiomaBorrado)).FirstOrDefault();
            idiomaBorrado.Estado_Idiomas = false;
            entities.SaveChanges();
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
