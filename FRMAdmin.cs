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
    public partial class frmAdmin : Form
    {
        private frmLogin login;
        public frmAdmin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Mother")
            {
                comboBoxMothers.Visible = true;
                comboBoxMicros.Visible = false;
                comboBoxMemorias.Visible = false;
                comboBoxDiscos.Visible = false;
            }
            if (comboBox1.Text == "Micro")
            {
                
                comboBoxMicros.Visible = true;
                comboBoxMothers.Visible = false;                
                comboBoxMemorias.Visible = false;
                comboBoxDiscos.Visible = false;
                comboBoxMicros.Location = new Point(87, 61);


            }
            if (comboBox1.Text == "Memorias")
            {
                
                comboBoxMemorias.Visible = true;
                comboBoxMothers.Visible = false;
                comboBoxMicros.Visible = false;               
                comboBoxDiscos.Visible = false;
                comboBoxMemorias.Location = new Point(87, 61);

            }
            if (comboBox1.Text == "Disco")
            {
                
                comboBoxDiscos.Visible = true;
                comboBoxMothers.Visible = false;
                comboBoxMicros.Visible = false;
                comboBoxMemorias.Visible = false;
                comboBoxDiscos.Location = new Point(87, 61);


            }

        }

        private void comboBoxMothers_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void comboBoxMicros_SelectedIndexChanged(object sender, EventArgs e)
        {

            Micro temporal = Program.getEmpresa().buscarMicro(comboBoxMicros.Text);

            precio.Text = temporal.precio.ToString();
            stock.Text = temporal.stock.ToString();
           
        }

        private void modificarStock_Click(object sender, EventArgs e)
        {
            
            Micro temporal = Program.getEmpresa().buscarMicro(comboBoxMicros.Text);
            temporal.precio = Int32.Parse(precio.Text);
            temporal.stock = Int32.Parse(stock.Text);

            MessageBox.Show("Se modifico el stock CORRECTAMENTE!", "Moficar Stock", MessageBoxButtons.OK);


        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login = new frmLogin();
            login.Show();
            this.Hide();

        }
    }
}
