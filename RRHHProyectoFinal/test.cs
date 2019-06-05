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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Competencias' Puede moverla o quitarla según sea necesario.
            this.competenciasTableAdapter.Fill(this.rRHHDataSet.Competencias);
            RRHHEntities entities = new RRHHEntities();
            //dataGridView1.DataSource = entities.Candidatos.Include(f => f.Personas.IdPersona).ToList(); ;
            var resultados = from candidatos in entities.Candidatos
                                       join persona in entities.Personas
                                       on candidatos.IdPersona_Candidatos equals persona.IdPersona
                                       join puestos in entities.Puestos
                                       on candidatos.PuestoAspirado_Candidatos equals puestos.IdPuesto
                                       select new
                                       {
                                           ID = candidatos.IdCandidato,
                                           Nombre = persona.Nombre_Personas,
                                           Apellido = persona.Apellido_Personas,
                                           Cedula = persona.Cedula_Personas,
                                           Puesto_Asp = puestos.Nombre_Puestos,
                                           Salario = candidatos.SalarioAspirado_Candidatos,
                                           Recomendacion = candidatos.Recomendacion_Candidatos
                                       };
            dataGridView1.DataSource = resultados.ToList();
                                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = listBox1.SelectedItems.Cast<DataRowView>();
            foreach (var item in lst)
            {
                MessageBox.Show(item.Row[0].ToString());
            }
        }
    }
}
