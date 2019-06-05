using Microsoft.Reporting.WinForms;
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
            // TODO: esta línea de código carga datos en la tabla 'RRHHDataSet.Reporte' Puede moverla o quitarla según sea necesario.
            this.reporteTableAdapter.Fill(this.RRHHDataSet.Reporte);
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.DataTable1' Puede moverla o quitarla según sea necesario.
            
            //// TODO: esta línea de código carga datos en la tabla 'rRHHDataSet.Competencias' Puede moverla o quitarla según sea necesario.
            //this.competenciasTableAdapter.Fill(this.rRHHDataSet.Competencias);
            RRHHEntities entities = new RRHHEntities();
            ////dataGridView1.DataSource = entities.Candidatos.Include(f => f.Personas.IdPersona).ToList(); ;
            //var resultados = from candidatos in entities.Candidatos
            //                           join persona in entities.Personas
            //                           on candidatos.IdPersona_Candidatos equals persona.IdPersona
            //                           join puestos in entities.Puestos
            //                           on candidatos.PuestoAspirado_Candidatos equals puestos.IdPuesto
            //                           select new
            //                           {
            //                               ID = candidatos.IdCandidato,
            //                               Nombre = persona.Nombre_Personas,
            //                               Apellido = persona.Apellido_Personas,
            //                               Cedula = persona.Cedula_Personas,
            //                               Puesto_Asp = puestos.Nombre_Puestos,
            //                               Salario = candidatos.SalarioAspirado_Candidatos,
            //                               Recomendacion = candidatos.Recomendacion_Candidatos
            //                           };
            //dataGridView1.DataSource = resultados.ToList();

            //this.reportViewer1.RefreshReport();

            DateTime fechaInicio = DateTime.Now.AddYears(-10);
            DateTime fechaFinal = DateTime.Now.AddYears(1);

            var empleadosNuevoIngreso = from empleados in entities.Empleados
                                        join persona in entities.Personas
                                        on empleados.IdPersona_Empleados equals persona.IdPersona
                                        join puesto in entities.Puestos
                                        on empleados.IdPuesto_Empleados equals puesto.IdPuesto
                                        where empleados.FechaIngreso_Empleados >= fechaInicio &&
                                        empleados.FechaIngreso_Empleados <= fechaFinal
                                        select new
                                        {
                                            IdEmpleado = empleados.IdEmpleado,
                                            Nombre_Personas = persona.Nombre_Personas,
                                            Apellido_Personas = persona.Apellido_Personas,
                                            Cedula_Personas = persona.Cedula_Personas,
                                            Sexo_Personas = persona.Sexo_Personas,
                                            Nombre_Puestos = puesto.Nombre_Puestos,
                                            FechaIngreso_Empleados = empleados.FechaIngreso_Empleados,
                                            Salario_Empleados = empleados.Salario_Empleados
                                        };
           
            reportViewer1.LocalReport.ReportEmbeddedResource = "RRHHProyectoFinal.Report1.rdlc";
            ReportDataSource rdl = new ReportDataSource("DataSet1", empleadosNuevoIngreso);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdl);
            reportViewer1.RefreshReport();






            this.reportViewer1.RefreshReport();
        }


    }
}