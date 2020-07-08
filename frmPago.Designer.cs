namespace Proyecto_programacion_3
{
    partial class frmPago
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.efectivo = new System.Windows.Forms.RadioButton();
            this.tarjCredito = new System.Windows.Forms.RadioButton();
            this.tarjDebito = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.totalPago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total  $";
            // 
            // efectivo
            // 
            this.efectivo.AutoSize = true;
            this.efectivo.Location = new System.Drawing.Point(34, 67);
            this.efectivo.Name = "efectivo";
            this.efectivo.Size = new System.Drawing.Size(64, 17);
            this.efectivo.TabIndex = 1;
            this.efectivo.TabStop = true;
            this.efectivo.Text = "Efectivo";
            this.efectivo.UseVisualStyleBackColor = true;
            // 
            // tarjCredito
            // 
            this.tarjCredito.AutoSize = true;
            this.tarjCredito.Location = new System.Drawing.Point(138, 67);
            this.tarjCredito.Name = "tarjCredito";
            this.tarjCredito.Size = new System.Drawing.Size(108, 17);
            this.tarjCredito.TabIndex = 2;
            this.tarjCredito.TabStop = true;
            this.tarjCredito.Text = "Tarjeta de credito";
            this.tarjCredito.UseVisualStyleBackColor = true;
            // 
            // tarjDebito
            // 
            this.tarjDebito.AutoSize = true;
            this.tarjDebito.BackColor = System.Drawing.SystemColors.Control;
            this.tarjDebito.Location = new System.Drawing.Point(277, 67);
            this.tarjDebito.Name = "tarjDebito";
            this.tarjDebito.Size = new System.Drawing.Size(105, 17);
            this.tarjDebito.TabIndex = 3;
            this.tarjDebito.TabStop = true;
            this.tarjDebito.Text = "Tarjeta de debito";
            this.tarjDebito.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(296, 106);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Volver a inicio";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(296, 136);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cerrar Sesion";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // totalPago
            // 
            this.totalPago.Enabled = false;
            this.totalPago.Location = new System.Drawing.Point(84, 27);
            this.totalPago.Name = "totalPago";
            this.totalPago.Size = new System.Drawing.Size(113, 20);
            this.totalPago.TabIndex = 7;
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 202);
            this.Controls.Add(this.totalPago);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tarjDebito);
            this.Controls.Add(this.tarjCredito);
            this.Controls.Add(this.efectivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmPago";
            this.Text = "Pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPago_FormClosing);
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton efectivo;
        private System.Windows.Forms.RadioButton tarjCredito;
        private System.Windows.Forms.RadioButton tarjDebito;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox totalPago;
    }
}