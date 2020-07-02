using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_programacion_3
{
    public partial class frmRegistro : Form
    {
        private frmLogin login;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(Usuario.Text, Contra.Text);

            if ((Usuario.Text != "") && (Contra.Text != "") && (confirmContra.Text != "") && (Mail.Text != ""))
            {

                if (Contra.Text == confirmContra.Text)
                {
                    Program.getEmpresa().agregarUsuario(u);

                    MessageBox.Show("Se registro Satisfactoriamente", "Registro con Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    login = new frmLogin();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contrasenas no coinciden", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else
            {
                MessageBox.Show("Complete todos los campos", "Error 500", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}