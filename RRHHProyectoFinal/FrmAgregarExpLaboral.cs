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
    public partial class FrmAgregarExpLaboral : Form
    {
        public FrmAgregarExpLaboral()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            string empresa = TxtEmpresa.Text;
            string puesto = TxtPuesto.Text;
            DateTime fechaDesde = DtpDesde.Value;
            DateTime fechaHasta = DtpHasta.Value;
            decimal salario = NudSalario.Value;

            if (ValidaForm(empresa, puesto, fechaDesde, fechaHasta))
            {
                try
                {

                    entities.ExpLaborales.Add(new ExpLaborales
                    {
                        IdPersona_ExpLaboral = Global.GlobalPersonID,
                        Empresa_ExpLaborales = empresa,
                        PuestoOcupado_ExpLaborales = puesto,
                        FechaDesde_ExpLaborales = fechaDesde,
                        FechaHasta_ExpLaborales = fechaHasta,
                        Salario_ExpLaborales = salario
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

        public bool ValidaForm(string empresa, string puesto, DateTime desde, DateTime hasta)
        {
            if (string.IsNullOrWhiteSpace(empresa))
            {
                MessageBox.Show("Empresa no puede ir vacio");
                TxtEmpresa.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(puesto))
            {

                MessageBox.Show("Puesto no puede ir vacio");
                TxtPuesto.Focus();
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
