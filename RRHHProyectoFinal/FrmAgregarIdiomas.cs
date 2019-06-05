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
    public partial class FrmAgregarIdiomas : Form
    {
        public FrmAgregarIdiomas()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            string idioma = TxtIdioma.Text;

            if (string.IsNullOrWhiteSpace(idioma))
            {
                MessageBox.Show("La casilla idioma no puede ir vacia!");
            }
            else
            {
                try
                {

                    entities.Idiomas.Add(new Idiomas
                    {
                        Nombre_Idiomas = idioma,
                        Estado_Idiomas = true
                    });
                    entities.SaveChanges();
                    MessageBox.Show("Registro guardado con exito!");
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
