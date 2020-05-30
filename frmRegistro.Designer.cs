namespace Proyecto_programacion_3
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.volverLogin = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUser
            // 
            this.newUser.AutoSize = true;
            this.newUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.Location = new System.Drawing.Point(48, 83);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(70, 18);
            this.newUser.TabIndex = 0;
            this.newUser.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar contraseña";
            // 
            // volverLogin
            // 
            this.volverLogin.AutoSize = true;
            this.volverLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverLogin.Location = new System.Drawing.Point(440, 307);
            this.volverLogin.Name = "volverLogin";
            this.volverLogin.Size = new System.Drawing.Size(119, 18);
            this.volverLogin.TabIndex = 3;
            this.volverLogin.TabStop = true;
            this.volverLogin.Text = "Volver al login";
            this.volverLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(239, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 4;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(239, 118);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(200, 26);
            this.password.TabIndex = 4;
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.Location = new System.Drawing.Point(239, 158);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(200, 26);
            this.confirmPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mail";
            // 
            // mail
            // 
            this.mail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.Location = new System.Drawing.Point(239, 209);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(200, 26);
            this.mail.TabIndex = 6;
            // 
            // registrarse
            // 
            this.registrarse.Location = new System.Drawing.Point(263, 297);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(127, 40);
            this.registrarse.TabIndex = 7;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 448);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.volverLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newUser);
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel volverLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Button registrarse;
    }
}