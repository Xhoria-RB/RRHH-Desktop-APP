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
    public partial class FrmSeleccionCandidato : Form
    {
        RRHHEntities entities = new RRHHEntities();

        public FrmSeleccionCandidato()
        {
            InitializeComponent();
        }

        private void FrmSeleccionCandidato_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData(string criterio = null )
        {
            var listaCandidatos = from candidatos in entities.Candidatos
                                  where candidatos.Estado_Candidatos == true
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
            
            DgvSeleccionCandidatos.DataSource = listaCandidatos.Where(p => criterio == null 
            || p.Nombre.Contains(criterio) || p.Apellido.Contains(criterio) || p.Cedula.Equals(criterio)
            || p.Puesto_Asp.Contains(criterio) || p.Recomendacion.Contains(criterio)).ToList();

            DgvSeleccionCandidatos.Refresh();
            DgvSeleccionCandidatos.Update();

            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = TxtBuscar.Text;
            LoadData(criterio);
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            int row = DgvSeleccionCandidatos.CurrentCell.RowIndex;
            int idCandidato = (int)DgvSeleccionCandidatos[0, row].Value;
            Global.GlobalCandidatoID = idCandidato;
            FrmDetallesCandidato frmDetallesCandidato = new FrmDetallesCandidato();
            Hide();
            frmDetallesCandidato.ShowDialog();
            Show();
            LoadData();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
