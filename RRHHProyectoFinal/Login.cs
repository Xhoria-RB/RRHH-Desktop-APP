using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RRHHProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrarse frmRegistrarse = new FrmRegistrarse();
            Hide();
            frmRegistrarse.ShowDialog();
            Show();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            RRHHEntities entities = new RRHHEntities();
            Utilidades util = new Utilidades();

            string userEmail = TxtUsuario.Text;
            string password = TxtPassword.Text;

            if (util.IsValidEmail(userEmail))
            {

                var resultado = entities.Usuarios.Where(p => p.Email_Usuarios.Equals(userEmail.ToLower()))
                    .FirstOrDefault();

                if (resultado == null)
                {
                    MessageBox.Show("El email es incorrecto o invalido");
                    clearText();
                    return;
                }

                if (BCrypt.Net.BCrypt.Verify(password, resultado.Contrasena_Usuarios))
                {
                    Global.GlobalUserID = resultado.IdUsuario;
                    Global.GlobalUserName = resultado.NombreUsuario_Usuarios;
                    Global.GlobalPersonID = resultado.IdPersona_Usuarios;

                    if (resultado.Roles_Usuarios.ToString() == "Candidato")
                    {
                        FrmInicioCandidato frmCandidato = new FrmInicioCandidato();
                        Hide();
                        clearText();
                        frmCandidato.ShowDialog();
                        Show();
                    }
                    else
                    {
                        FrmInicioRRHH frmInicio = new FrmInicioRRHH();
                        Hide();
                        clearText();
                        frmInicio.ShowDialog();
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la password fue incorrecto");
                }


            }
            else
            {
                MessageBox.Show("Email no valido!");
            }

        }

        private void clearText()
        {

            TxtUsuario.Clear();
            TxtPassword.Clear();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
