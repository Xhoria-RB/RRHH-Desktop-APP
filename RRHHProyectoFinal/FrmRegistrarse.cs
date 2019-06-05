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
    public partial class FrmRegistrarse : Form
    {
        public FrmRegistrarse()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            Utilidades util = new Utilidades();
            string username = TxtUsuario.Text;
            string email = TxtEmail.Text.ToLower();
            string password = TxtPassword.Text;
            string confirmPassw = TxtConfirmPassw.Text;
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string cedula = TxtCedula.Text;
            string sexo = CbxSexo.Text;


            if (ValidateForm())
            {
                //Usuario
                if (util.IsValidEmail(email))
                {
                    if (password.Equals(confirmPassw))
                    {
                        //Datos personales
                        if (util.validaCedula(cedula))
                        {
                            try
                            {
                                entities.Personas.Add(new Personas
                                {
                                    Nombre_Personas = nombre,
                                    Apellido_Personas = apellido,
                                    Cedula_Personas = cedula,
                                    Sexo_Personas = sexo
                                });
                                entities.SaveChanges();

                                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                                var usuario = entities.Personas.Where(p => p.Cedula_Personas.Equals(cedula)).FirstOrDefault();
                                entities.Usuarios.Add(new Usuarios
                                {
                                    Email_Usuarios = email,
                                    Contrasena_Usuarios = passwordHash,
                                    NombreUsuario_Usuarios = username,
                                    IdPersona_Usuarios = usuario.IdPersona,
                                    Roles_Usuarios = "Candidato"

                                });
                                entities.SaveChanges();
                                MessageBox.Show("Registrado exitosamente!");
                                Dispose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Cedula no valida!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contrasenas no coinciden!");
                    }
                }
                else
                {
                    MessageBox.Show("El email no es valido!");
                }

            }



        }

        private bool ValidateForm()
        {

            foreach (Control control in groupBox1.Controls.OfType<TextBox>().OrderBy(c => c.TabIndex))
            {
                TextBox textBox = control as TextBox;

                if (textBox == null)
                {
                    return true;
                }
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Focus();
                    var fieldName = textBox.Name.Substring(3);
                    MessageBox.Show("El campo " + fieldName + " es requerido.");
                    return false;
                }

            }

            return true;
        }

        private void FrmRegistrarse_Load(object sender, EventArgs e)
        {
            CbxSexo.SelectedIndex = 0;
        }
    }
}
