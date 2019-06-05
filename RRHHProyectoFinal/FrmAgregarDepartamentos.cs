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
    public partial class FrmAgregarDepartamentos : Form
    {
        public FrmAgregarDepartamentos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            string departamento = TxtDepartamento.Text;
            if (string.IsNullOrWhiteSpace(departamento))
            {
                MessageBox.Show("El campo departamentos no puede estar vacio!");
                TxtDepartamento.Focus();
            }
            else
            {
                try
                {

                    entities.Departamentos.Add(new Departamentos
                    {
                        Descripcion_Departamentos = departamento,
                        Estado_Departamentos = true
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
