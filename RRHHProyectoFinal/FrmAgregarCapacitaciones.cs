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
    public partial class FrmAgregarCapacitaciones : Form
    {
        public FrmAgregarCapacitaciones()
        {
            InitializeComponent();
        }

        private void FrmAgregarCapacitaciones_Load(object sender, EventArgs e)
        {
            CbxNivel.SelectedIndex = 0;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            string capacitaciones = TxtCapacitacion.Text;
            string nivel = CbxNivel.Text;
            DateTime fechaDesde = DtpDesde.Value;
            DateTime fechaHasta = DtpHasta.Value;
            string institucion = TxtInstitucion.Text;

            if (ValidaForm(capacitaciones, institucion, fechaDesde, fechaHasta))
            {
                try
                {
                    entities.Capacitaciones.Add(new Capacitaciones
                    {
                        Descripcion_Capacitaciones = capacitaciones,
                        Nivel_Capacitaciones = nivel,
                        FechaDesde_Capacitaciones = fechaDesde,
                        FechaHasta_Capacitaciones = fechaHasta,
                        Institucion_Capacitaciones = institucion
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
        public bool ValidaForm(string capacitacion, string institucion, DateTime desde, DateTime hasta)
        {
            if (string.IsNullOrWhiteSpace(capacitacion))
            {
                MessageBox.Show("Empresa no puede ir vacio");
                TxtCapacitacion.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(institucion))
            {
                MessageBox.Show("Puesto no puede ir vacio");
                TxtInstitucion.Focus();
                return false;
            }
            if (!(desde < DateTime.Now))
            {
                MessageBox.Show("La fecha desde no puede ser mayor o igual a la fecha actual");
                return false;
            }
            if (!(hasta > desde))
            {
                MessageBox.Show("La fecha desde no puede ser mayor o igual a la fecha hasta");
                return false;
            }
            return true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
