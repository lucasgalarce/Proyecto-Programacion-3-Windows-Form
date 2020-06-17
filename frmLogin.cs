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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if ((txtUsuario.Text == "Admin") && (txtContrasena.Text == "passadmin")) {

                MessageBox.Show("Bienvenido a WEST BYTE / Admin Mode", "Welcome",MessageBoxButtons.OK);
                
                
                 //frmAdmin administrador = new frmAdmin();
                 //administrador.show();
                 //this.hide();
            }

           


            frmInicio inicio = new frmInicio();
            inicio.Show();

            this.Hide();
        }

     

        private void link_Registrarse_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();

            this.Hide();
        }
    }
}
