namespace Proyecto_programacion_3
{
    partial class frmAdmin
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
            this.modificarStock = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.comboBoxMothers = new System.Windows.Forms.ComboBox();
            this.comboBoxMicros = new System.Windows.Forms.ComboBox();
            this.comboBoxMemorias = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscos = new System.Windows.Forms.ComboBox();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // modificarStock
            // 
            this.modificarStock.Location = new System.Drawing.Point(79, 196);
            this.modificarStock.Name = "modificarStock";
            this.modificarStock.Size = new System.Drawing.Size(188, 52);
            this.modificarStock.TabIndex = 0;
            this.modificarStock.Text = "Modificar STOCK";
            this.modificarStock.UseVisualStyleBackColor = true;
            this.modificarStock.Click += new System.EventHandler(this.modificarStock_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mother",
            "Micro",
            "Memorias",
            "Disco"});
            this.comboBox1.Location = new System.Drawing.Point(87, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(113, 116);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(154, 20);
            this.precio.TabIndex = 4;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(113, 156);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(154, 20);
            this.stock.TabIndex = 4;
            // 
            // comboBoxMothers
            // 
            this.comboBoxMothers.FormattingEnabled = true;
            this.comboBoxMothers.Location = new System.Drawing.Point(87, 61);
            this.comboBoxMothers.Name = "comboBoxMothers";
            this.comboBoxMothers.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMothers.TabIndex = 2;
            this.comboBoxMothers.Visible = false;
            this.comboBoxMothers.SelectedIndexChanged += new System.EventHandler(this.comboBoxMothers_SelectedIndexChanged);
            // 
            // comboBoxMicros
            // 
            this.comboBoxMicros.FormattingEnabled = true;
            this.comboBoxMicros.Location = new System.Drawing.Point(301, 109);
            this.comboBoxMicros.Name = "comboBoxMicros";
            this.comboBoxMicros.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMicros.TabIndex = 2;
            this.comboBoxMicros.Visible = false;
            this.comboBoxMicros.SelectedIndexChanged += new System.EventHandler(this.comboBoxMicros_SelectedIndexChanged);
            // 
            // comboBoxMemorias
            // 
            this.comboBoxMemorias.FormattingEnabled = true;
            this.comboBoxMemorias.Location = new System.Drawing.Point(301, 82);
            this.comboBoxMemorias.Name = "comboBoxMemorias";
            this.comboBoxMemorias.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMemorias.TabIndex = 2;
            this.comboBoxMemorias.Visible = false;
            this.comboBoxMemorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxMemorias_SelectedIndexChanged);
            // 
            // comboBoxDiscos
            // 
            this.comboBoxDiscos.FormattingEnabled = true;
            this.comboBoxDiscos.Location = new System.Drawing.Point(301, 136);
            this.comboBoxDiscos.Name = "comboBoxDiscos";
            this.comboBoxDiscos.Size = new System.Drawing.Size(180, 21);
            this.comboBoxDiscos.TabIndex = 2;
            this.comboBoxDiscos.Visible = false;
            this.comboBoxDiscos.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscos_SelectedIndexChanged);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.Location = new System.Drawing.Point(84, 268);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(70, 13);
            this.logout.TabIndex = 5;
            this.logout.TabStop = true;
            this.logout.Text = "Cerrar Sesion";
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 305);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDiscos);
            this.Controls.Add(this.comboBoxMemorias);
            this.Controls.Add(this.comboBoxMicros);
            this.Controls.Add(this.comboBoxMothers);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.modificarStock);
            this.Name = "frmAdmin";
            this.Text = "Modo Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modificarStock;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.ComboBox comboBoxMothers;
        private System.Windows.Forms.ComboBox comboBoxMicros;
        private System.Windows.Forms.ComboBox comboBoxMemorias;
        private System.Windows.Forms.ComboBox comboBoxDiscos;
        private System.Windows.Forms.LinkLabel logout;
    }
}