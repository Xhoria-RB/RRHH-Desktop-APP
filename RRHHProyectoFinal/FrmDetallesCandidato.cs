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
    public partial class FrmDetallesCandidato : Form
    {
        RRHHEntities entities = new RRHHEntities();
        private int idPersona = 0;
        public FrmDetallesCandidato()
        {
            InitializeComponent();
        }

        private void FrmDetallesCandidato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'rRHHDataSet1.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.rRHHDataSet1.Puestos);
            CbxPuesto.SelectedIndex = 0;
            LoadData();

        }

        public void LoadData()
        {
            int idCandidato = Global.GlobalCandidatoID;
            var candidato = entities.Candidatos.Where(p => p.IdCandidato.Equals(idCandidato)).FirstOrDefault();
            idPersona = candidato.IdPersona_Candidatos;
            var persona = entities.Personas.Where(p => p.IdPersona.Equals(idPersona)).FirstOrDefault();
            var listaCapacitaciones = from capacitaciones in entities.Capacitaciones
                                      join relCapacitaciones in entities.REL_Capacitaciones_Candidatos
                                      on capacitaciones.IdCapacitacion equals relCapacitaciones.IdCapacitacion_Rel_Capacitaciones_Candidatos
                                      where relCapacitaciones.IdCandidato_Rel_Capacitaciones_Candidatos == idCandidato
                                      select new
                                      {
                                          Descripcion = capacitaciones.Descripcion_Capacitaciones,
                                          Grado = capacitaciones.Nivel_Capacitaciones,
                                          Desde = capacitaciones.FechaDesde_Capacitaciones,
                                          Hasta = capacitaciones.FechaHasta_Capacitaciones,
                                          Institucion = capacitaciones.Institucion_Capacitaciones
                                      };

            var listaIdiomas = from idiomas in entities.Idiomas
                               join relIdiomas in entities.REL_Idioma_Candidatos
                               on idiomas.IdIdioma equals relIdiomas.IdIdioma_Rel_Idioma_Candidatos
                               where relIdiomas.IdCandidato_Rel_Idioma_Candidatos == idCandidato
                               select new
                               {
                                   Idiomas = idiomas.Nombre_Idiomas
                               };

            var listaCompetencias = from competencias in entities.Competencias
                                    join relCompetencias in entities.REL_Competencias_Candidatos
                                    on competencias.IdCompetencia equals relCompetencias.IdCompetencia_Rel_Competencias_Candidatos
                                    where relCompetencias.IdCandidato_Rel_Competencias_Candidatos == idCandidato
                                    select new
                                    {
                                        Competencias = competencias.Descripcion_Competencias
                                    };
            var listExpLaborales = entities.ExpLaborales.Where(p => p.IdPersona_ExpLaboral.Equals(idPersona));
            int puesto = (int)candidato.PuestoAspirado_Candidatos;
            var puestoSeleccionado = entities.Puestos.Where(p => p.IdPuesto.Equals(puesto)).FirstOrDefault();

            TxtNombre.Text = persona.Nombre_Personas;
            TxtApellido.Text = persona.Apellido_Personas;
            TxtSexo.Text = persona.Sexo_Personas;
            TxtCedula.Text = persona.Cedula_Personas;
            TxtPuestoAsp.Text = puestoSeleccionado.Nombre_Puestos;
            TxtSalarioAsp.Text = candidato.SalarioAspirado_Candidatos.ToString();
            TxtRecomendacion.Text = candidato.Recomendacion_Candidatos;

            DgvCapacitaciones.DataSource = listaCapacitaciones.ToList();
            DgvCapacitaciones.Refresh();
            DgvCompetencias.DataSource = listaCompetencias.ToList();
            DgvCompetencias.Refresh();
            DgvIdiomas.DataSource = listaIdiomas.ToList();
            DgvIdiomas.Refresh();
            DgvExpLaborales.DataSource = listExpLaborales.ToList();
            DgvExpLaborales.Refresh();
        }

        private void BtnContratar_Click(object sender, EventArgs e)
        {
            decimal salario = NudSalario.Value;
            int idPuesto = (int)CbxPuesto.SelectedValue;
            int idCandidato = Global.GlobalCandidatoID;

            var puesto = entities.Puestos.Where(p => p.IdPuesto.Equals(idPuesto)).FirstOrDefault();

            if (salario < puesto.SalarioMinimo_Puestos || salario > puesto.SalarioMaximo_Puestos)
            {
                MessageBox.Show("El salario no puede estar por debajo ni por encima del establecido en el puesto\n" +
                    "Salario minimo: " + puesto.SalarioMinimo_Puestos.ToString() +
                    " Salario maximo: " + puesto.SalarioMaximo_Puestos.ToString());

            }
            else
            {
                try
                {

                    entities.Empleados.Add(new Empleados
                    {
                        IdPersona_Empleados = idPersona,
                        IdPuesto_Empleados = idPersona,
                        Salario_Empleados = salario,
                        FechaIngreso_Empleados = DateTime.Now,
                        Estado_Empleados = true
                    });
                    var candidato = entities.Candidatos.Where(p => p.IdCandidato.Equals(idCandidato)).FirstOrDefault();
                    candidato.Estado_Candidatos = false;

                    var usuario = entities.Usuarios.Where(p => p.IdPersona_Usuarios.Equals(idPersona)).FirstOrDefault();
                    usuario.Roles_Usuarios = "RRHH";

                    entities.SaveChanges();
                    MessageBox.Show("Registro guardado exitosamente!!");
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
