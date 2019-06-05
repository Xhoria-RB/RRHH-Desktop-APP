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
    public partial class FrmAgregarCompetencias : Form
    {
        public FrmAgregarCompetencias()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            string competencias = TxtCompetencia.Text;

            if (string.IsNullOrWhiteSpace(competencias))
            {
                MessageBox.Show("El campo competencias no puede estar vacio");
                TxtCompetencia.Focus();
            }
            else
            {
                try
                {
                    entities.Competencias.Add(new Competencias
                    {
                        Descripcion_Competencias = competencias,
                        Estado_Competencias = true
                    });
                    entities.SaveChanges();
                    MessageBox.Show("Registro guardado exitosamente!");
                    Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
