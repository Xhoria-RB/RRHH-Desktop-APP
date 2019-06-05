using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporte : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'RRHHDataSet.Reporte' Puede moverla o quitarla según sea necesario.
            LoadData();
        }

        public void LoadData()
        {

            DateTime fechaInicio = DtpDesde.Value;
            DateTime fechaFinal = DtpHasta.Value;

            var empleadosNuevoIngreso = from empleados in entities.Empleados
                                        join persona in entities.Personas
                                        on empleados.IdPersona_Empleados equals persona.IdPersona
                                        join puesto in entities.Puestos
                                        on empleados.IdPuesto_Empleados equals puesto.IdPuesto
                                        where (empleados.FechaIngreso_Empleados >= fechaInicio &&
                                        empleados.FechaIngreso_Empleados <= fechaFinal)
                                        && (empleados.Estado_Empleados == true)
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
            RvEmpleados.LocalReport.ReportEmbeddedResource = "RRHHProyectoFinal.Report1.rdlc";
            ReportDataSource rdl = new ReportDataSource("DataSet1", empleadosNuevoIngreso);
            RvEmpleados.LocalReport.DataSources.Clear();
            RvEmpleados.LocalReport.DataSources.Add(rdl);
            RvEmpleados.RefreshReport();

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
