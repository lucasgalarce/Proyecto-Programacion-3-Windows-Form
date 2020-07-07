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
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.confirmContra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUser
            // 
            this.newUser.AutoSize = true;
            this.newUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.Location = new System.Drawing.Point(26, 27);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(70, 18);
            this.newUser.TabIndex = 0;
            this.newUser.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Confirmar contraseña";
            // 
            // volverLogin
            // 
            this.volverLogin.AutoSize = true;
            this.volverLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverLogin.Location = new System.Drawing.Point(303, 220);
            this.volverLogin.Name = "volverLogin";
            this.volverLogin.Size = new System.Drawing.Size(119, 18);
            this.volverLogin.TabIndex = 6;
            this.volverLogin.TabStop = true;
            this.volverLogin.Text = "Volver al login";
            this.volverLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(217, 24);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(200, 26);
            this.Usuario.TabIndex = 1;
            // 
            // Contra
            // 
            this.Contra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra.Location = new System.Drawing.Point(217, 62);
            this.Contra.Name = "Contra";
            this.Contra.PasswordChar = '*';
            this.Contra.Size = new System.Drawing.Size(200, 26);
            this.Contra.TabIndex = 2;
            // 
            // confirmContra
            // 
            this.confirmContra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmContra.Location = new System.Drawing.Point(217, 102);
            this.confirmContra.Name = "confirmContra";
            this.confirmContra.PasswordChar = '*';
            this.confirmContra.Size = new System.Drawing.Size(200, 26);
            this.confirmContra.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mail";
            // 
            // Mail
            // 
            this.Mail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.Location = new System.Drawing.Point(217, 153);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(200, 26);
            this.Mail.TabIndex = 4;
            // 
            // registrarse
            // 
            this.registrarse.Location = new System.Drawing.Point(156, 210);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(127, 40);
            this.registrarse.TabIndex = 5;
            this.registrarse.Text = "Registrarse";
            this.registrarse.UseVisualStyleBackColor = true;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 267);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmContra);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.volverLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newUser);
            this.Name = "frmRegistro";
            this.Text = "Registrarse - West Byte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel volverLogin;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.TextBox confirmContra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Button registrarse;
    }
}