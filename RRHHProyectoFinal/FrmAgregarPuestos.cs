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
    public partial class FrmAgregarPuestos : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmAgregarPuestos()
        {
            InitializeComponent();
        }

        private void FrmAgregarPuestos_Load(object sender, EventArgs e)
        {
            var departamentos = entities.Departamentos.Select(p => p.Descripcion_Departamentos).ToList();
            if (departamentos != null)
            {
                foreach (var departamento in departamentos)
                {
                    CbxDepartamento.Items.Add(departamento);
                }
                CbxDepartamento.SelectedIndex = 0;
                CbxNivelRiesgo.SelectedIndex = 0;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            var departamento = entities.Departamentos.Where(p => p.Descripcion_Departamentos == CbxDepartamento.Text).FirstOrDefault();
            decimal salarioMinimo = NudSalarioMinimo.Value;
            decimal salarioMaximo = NudSalarioMaximo.Value;
            string riesgo = CbxNivelRiesgo.Text;

            if (!string.IsNullOrWhiteSpace(nombre))
            {
                try
                {
                    entities.Puestos.Add(new Puestos
                    {
                        Nombre_Puestos = nombre,
                        IdDepartamento_Puestos = departamento.IdDepartamento,
                        SalarioMinimo_Puestos = salarioMinimo,
                        SalarioMaximo_Puestos = salarioMaximo,
                        NivelRiesgo_Puestos = riesgo,
                        Estado_Puestos = true
                    });
                    entities.SaveChanges();
                    MessageBox.Show("Registro guardado exitosamente!");
                    Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
