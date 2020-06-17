namespace Proyecto_programacion_3
{
    partial class frmInicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.micro = new System.Windows.Forms.Button();
            this.mother = new System.Windows.Forms.Button();
            this.ram = new System.Windows.Forms.Button();
            this.disk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.preArmados = new System.Windows.Forms.ComboBox();
            this.checkBoxMicro1 = new System.Windows.Forms.CheckBox();
            this.checkBoxMicro4 = new System.Windows.Forms.CheckBox();
            this.checkBoxMicro3 = new System.Windows.Forms.CheckBox();
            this.lblMicro1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imgMicro4 = new System.Windows.Forms.PictureBox();
            this.imgMicro3 = new System.Windows.Forms.PictureBox();
            this.imgMicro1 = new System.Windows.Forms.PictureBox();
            this.stockMicro1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupMicros1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMicro2 = new System.Windows.Forms.CheckBox();
            this.imgMicro2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro1)).BeginInit();
            this.groupMicros1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(857, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "user";
            // 
            // micro
            // 
            this.micro.Location = new System.Drawing.Point(73, 111);
            this.micro.Name = "micro";
            this.micro.Size = new System.Drawing.Size(187, 55);
            this.micro.TabIndex = 2;
            this.micro.Text = "Microprocesadores";
            this.micro.UseVisualStyleBackColor = true;
            this.micro.Click += new System.EventHandler(this.button1_Click);
            // 
            // mother
            // 
            this.mother.Location = new System.Drawing.Point(266, 111);
            this.mother.Name = "mother";
            this.mother.Size = new System.Drawing.Size(187, 55);
            this.mother.TabIndex = 2;
            this.mother.Text = "Mother";
            this.mother.UseVisualStyleBackColor = true;
            this.mother.Click += new System.EventHandler(this.mother_Click);
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(459, 111);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(187, 55);
            this.ram.TabIndex = 2;
            this.ram.Text = "Memorias ram";
            this.ram.UseVisualStyleBackColor = true;
            // 
            // disk
            // 
            this.disk.Location = new System.Drawing.Point(652, 111);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(187, 55);
            this.disk.TabIndex = 2;
            this.disk.Text = "Disco";
            this.disk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(752, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Proceder a pago";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(39, 546);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(50, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Contacto";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // preArmados
            // 
            this.preArmados.FormattingEnabled = true;
            this.preArmados.Location = new System.Drawing.Point(73, 41);
            this.preArmados.Name = "preArmados";
            this.preArmados.Size = new System.Drawing.Size(271, 21);
            this.preArmados.TabIndex = 6;
            // 
            // checkBoxMicro1
            // 
            this.checkBoxMicro1.AutoSize = true;
            this.checkBoxMicro1.Location = new System.Drawing.Point(271, 40);
            this.checkBoxMicro1.Name = "checkBoxMicro1";
            this.checkBoxMicro1.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMicro1.TabIndex = 8;
            this.checkBoxMicro1.Text = "i3 7800k";
            this.checkBoxMicro1.UseVisualStyleBackColor = true;
            // 
            // checkBoxMicro4
            // 
            this.checkBoxMicro4.AutoSize = true;
            this.checkBoxMicro4.Location = new System.Drawing.Point(605, 195);
            this.checkBoxMicro4.Name = "checkBoxMicro4";
            this.checkBoxMicro4.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMicro4.TabIndex = 8;
            this.checkBoxMicro4.Text = "i9 9900k";
            this.checkBoxMicro4.UseVisualStyleBackColor = true;
            // 
            // checkBoxMicro3
            // 
            this.checkBoxMicro3.AutoSize = true;
            this.checkBoxMicro3.Location = new System.Drawing.Point(271, 195);
            this.checkBoxMicro3.Name = "checkBoxMicro3";
            this.checkBoxMicro3.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMicro3.TabIndex = 8;
            this.checkBoxMicro3.Text = "i7 8800k";
            this.checkBoxMicro3.UseVisualStyleBackColor = true;
            // 
            // lblMicro1
            // 
            this.lblMicro1.AutoSize = true;
            this.lblMicro1.Location = new System.Drawing.Point(272, 80);
            this.lblMicro1.Name = "lblMicro1";
            this.lblMicro1.Size = new System.Drawing.Size(37, 13);
            this.lblMicro1.TabIndex = 10;
            this.lblMicro1.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Precio";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // imgMicro4
            // 
            this.imgMicro4.Image = global::Proyecto_programacion_3.Properties.Resources.core_i7;
            this.imgMicro4.Location = new System.Drawing.Point(421, 184);
            this.imgMicro4.Name = "imgMicro4";
            this.imgMicro4.Size = new System.Drawing.Size(139, 107);
            this.imgMicro4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMicro4.TabIndex = 9;
            this.imgMicro4.TabStop = false;
            // 
            // imgMicro3
            // 
            this.imgMicro3.Image = global::Proyecto_programacion_3.Properties.Resources.core_i7;
            this.imgMicro3.Location = new System.Drawing.Point(96, 184);
            this.imgMicro3.Name = "imgMicro3";
            this.imgMicro3.Size = new System.Drawing.Size(139, 107);
            this.imgMicro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMicro3.TabIndex = 9;
            this.imgMicro3.TabStop = false;
            this.imgMicro3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // imgMicro1
            // 
            this.imgMicro1.Image = global::Proyecto_programacion_3.Properties.Resources.core_i7;
            this.imgMicro1.Location = new System.Drawing.Point(96, 40);
            this.imgMicro1.Name = "imgMicro1";
            this.imgMicro1.Size = new System.Drawing.Size(139, 107);
            this.imgMicro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMicro1.TabIndex = 9;
            this.imgMicro1.TabStop = false;
            // 
            // stockMicro1
            // 
            this.stockMicro1.AutoSize = true;
            this.stockMicro1.Location = new System.Drawing.Point(274, 121);
            this.stockMicro1.Name = "stockMicro1";
            this.stockMicro1.Size = new System.Drawing.Size(35, 13);
            this.stockMicro1.TabIndex = 11;
            this.stockMicro1.Text = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(268, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Stock";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Stock";
            // 
            // groupMicros1
            // 
            this.groupMicros1.Controls.Add(this.label11);
            this.groupMicros1.Controls.Add(this.label10);
            this.groupMicros1.Controls.Add(this.stockMicro1);
            this.groupMicros1.Controls.Add(this.label7);
            this.groupMicros1.Controls.Add(this.label6);
            this.groupMicros1.Controls.Add(this.label9);
            this.groupMicros1.Controls.Add(this.imgMicro4);
            this.groupMicros1.Controls.Add(this.checkBoxMicro4);
            this.groupMicros1.Controls.Add(this.imgMicro3);
            this.groupMicros1.Controls.Add(this.checkBoxMicro3);
            this.groupMicros1.Controls.Add(this.lblMicro1);
            this.groupMicros1.Controls.Add(this.label5);
            this.groupMicros1.Controls.Add(this.imgMicro1);
            this.groupMicros1.Controls.Add(this.checkBoxMicro1);
            this.groupMicros1.Controls.Add(this.imgMicro2);
            this.groupMicros1.Controls.Add(this.checkBoxMicro2);
            this.groupMicros1.Location = new System.Drawing.Point(99, 178);
            this.groupMicros1.Margin = new System.Windows.Forms.Padding(0);
            this.groupMicros1.Name = "groupMicros1";
            this.groupMicros1.Size = new System.Drawing.Size(770, 342);
            this.groupMicros1.TabIndex = 16;
            this.groupMicros1.TabStop = false;
            this.groupMicros1.Text = "Micros";
            this.groupMicros1.Visible = false;
            // 
            // checkBoxMicro2
            // 
            this.checkBoxMicro2.AutoSize = true;
            this.checkBoxMicro2.Location = new System.Drawing.Point(605, 42);
            this.checkBoxMicro2.Name = "checkBoxMicro2";
            this.checkBoxMicro2.Size = new System.Drawing.Size(67, 17);
            this.checkBoxMicro2.TabIndex = 8;
            this.checkBoxMicro2.Text = "i5 7600k";
            this.checkBoxMicro2.UseVisualStyleBackColor = true;
            // 
            // imgMicro2
            // 
            this.imgMicro2.Image = global::Proyecto_programacion_3.Properties.Resources.core_i7;
            this.imgMicro2.Location = new System.Drawing.Point(421, 40);
            this.imgMicro2.Name = "imgMicro2";
            this.imgMicro2.Size = new System.Drawing.Size(139, 107);
            this.imgMicro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMicro2.TabIndex = 9;
            this.imgMicro2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(604, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Stock";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 590);
            this.Controls.Add(this.groupMicros1);
            this.Controls.Add(this.preArmados);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.disk);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.mother);
            this.Controls.Add(this.micro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro1)).EndInit();
            this.groupMicros1.ResumeLayout(false);
            this.groupMicros1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMicro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button micro;
        private System.Windows.Forms.Button mother;
        private System.Windows.Forms.Button ram;
        private System.Windows.Forms.Button disk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox preArmados;
        private System.Windows.Forms.CheckBox checkBoxMicro1;
        private System.Windows.Forms.CheckBox checkBoxMicro4;
        private System.Windows.Forms.PictureBox imgMicro1;
        private System.Windows.Forms.CheckBox checkBoxMicro3;
        private System.Windows.Forms.PictureBox imgMicro4;
        private System.Windows.Forms.Label lblMicro1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgMicro3;
        private System.Windows.Forms.Label stockMicro1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupMicros1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox imgMicro2;
        private System.Windows.Forms.CheckBox checkBoxMicro2;
    }
}