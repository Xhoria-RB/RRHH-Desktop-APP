using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHProyectoFinal
{
    public partial class FrmNuevoCandidato : Form
    {
        RRHHEntities entities = new RRHHEntities();
        public FrmNuevoCandidato()
        {
            InitializeComponent();
        }

        private void FrmNuevoCandidato_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        public void LoadData()
        {
            var puestos = entities.Puestos.Where(p => p.Estado_Puestos == true);
            var competencias = entities.Competencias.Where(p => p.Estado_Competencias == true);
            var idiomas = entities.Idiomas.Where(p => p.Estado_Idiomas == true);
            var capacitaciones = entities.Capacitaciones;

            LtbPuestos.BeginUpdate();
            LtbPuestos.DataSource = puestos.ToList();
            LtbPuestos.EndUpdate();

            LtbCompetencias.BeginUpdate();
            LtbCompetencias.DataSource = competencias.ToList();
            LtbCompetencias.EndUpdate();

            LtbIdiomas.BeginUpdate();
            LtbIdiomas.DataSource = idiomas.ToList();
            LtbIdiomas.EndUpdate();

            DgvCapacitaciones.DataSource = capacitaciones.ToList();
            DgvCapacitaciones.Refresh();
            DgvCapacitaciones.Update();

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int puesto = (int)LtbPuestos.SelectedValue;
            var listaIdiomas = LtbIdiomas.SelectedItems.Cast<Idiomas>();
            var listaCompetencias = LtbCompetencias.SelectedItems.Cast<Competencias>();
            var listaCapacitaciones = DgvCapacitaciones.SelectedRows
                .OfType<DataGridViewRow>()
                .ToList();
            string recomendaciones = TxtRecomendacion.Text;
            decimal salario = NudSalario.Value;


            if (string.IsNullOrWhiteSpace(recomendaciones))
            {
                MessageBox.Show("La casilla recomendaciones no puede estar vacia!");
            }
            else
            {
                try
                {

                    entities.Candidatos.Add(new Candidatos
                    {
                        IdPersona_Candidatos = Global.GlobalPersonID,
                        PuestoAspirado_Candidatos = puesto,
                        SalarioAspirado_Candidatos = salario,
                        Recomendacion_Candidatos = recomendaciones,
                        Estado_Candidatos = true
                    });
                    entities.SaveChanges();

                    var candidato = entities.Candidatos
                        .Where(p => p.IdPersona_Candidatos.Equals(Global.GlobalPersonID))
                        .FirstOrDefault();

                    try
                    {
                        foreach (var item in listaIdiomas)
                        {
                            entities.REL_Idioma_Candidatos.Add(new REL_Idioma_Candidatos
                            {
                                IdCandidato_Rel_Idioma_Candidatos = candidato.IdCandidato,
                                IdIdioma_Rel_Idioma_Candidatos = item.IdIdioma
                            });
                        }
                        
                        foreach (var item in listaCompetencias)
                        {
                            entities.REL_Competencias_Candidatos.Add(new REL_Competencias_Candidatos
                            {
                                IdCandidato_Rel_Competencias_Candidatos = candidato.IdCandidato,
                                IdCompetencia_Rel_Competencias_Candidatos = item.IdCompetencia
                            });
                        }

                        foreach (var item in listaCapacitaciones)
                        {
                            entities.REL_Capacitaciones_Candidatos.Add(new REL_Capacitaciones_Candidatos
                            {
                                IdCandidato_Rel_Capacitaciones_Candidatos = candidato.IdCandidato,
                                IdCapacitacion_Rel_Capacitaciones_Candidatos = (int)DgvCapacitaciones[0, item.Index].Value
                            });
                        }
                        entities.SaveChanges();
                        MessageBox.Show("Solicitud realizada exitosamente!");
                        Dispose();
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show("Error guardando registros, puede que algunos campos " +
                            "ya se hayan seleccionado anteriormente" + ex.Message + "\n" + ex.InnerException);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void BtnExpLaborales_Click(object sender, EventArgs e)
        {
            FrmGestionExpLaboral frmGestionExpLaboral = new FrmGestionExpLaboral();
            frmGestionExpLaboral.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
