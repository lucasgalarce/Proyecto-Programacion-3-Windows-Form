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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.comboBoxMothers = new System.Windows.Forms.ComboBox();
            this.comboBoxMicros = new System.Windows.Forms.ComboBox();
            this.comboBoxMemorias = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar STOCK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mother",
            "Micro",
            "Memorias ",
            "Disco"});
            this.comboBox1.Location = new System.Drawing.Point(191, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(232, 180);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(154, 20);
            this.precio.TabIndex = 4;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(232, 220);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(154, 20);
            this.stock.TabIndex = 4;
            // 
            // comboBoxMothers
            // 
            this.comboBoxMothers.FormattingEnabled = true;
            this.comboBoxMothers.Items.AddRange(new object[] {
            "ASUS PRO",
            "Gigabyte 320",
            "MSI PRO 2",
            "Asrock 1150"});
            this.comboBoxMothers.Location = new System.Drawing.Point(79, 74);
            this.comboBoxMothers.Name = "comboBoxMothers";
            this.comboBoxMothers.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMothers.TabIndex = 2;
            // 
            // comboBoxMicros
            // 
            this.comboBoxMicros.FormattingEnabled = true;
            this.comboBoxMicros.Items.AddRange(new object[] {
            "i3 7800k",
            "i5 7600k",
            "i7 8800k",
            "i9 9900k"});
            this.comboBoxMicros.Location = new System.Drawing.Point(299, 74);
            this.comboBoxMicros.Name = "comboBoxMicros";
            this.comboBoxMicros.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMicros.TabIndex = 2;
            // 
            // comboBoxMemorias
            // 
            this.comboBoxMemorias.FormattingEnabled = true;
            this.comboBoxMemorias.Items.AddRange(new object[] {
            "DDR3 4GB 1333ghz",
            "DDR3 8GB 1333ghz",
            "DDR4 4GB 2400ghz",
            "DDR4 8GB 2400ghz"});
            this.comboBoxMemorias.Location = new System.Drawing.Point(79, 110);
            this.comboBoxMemorias.Name = "comboBoxMemorias";
            this.comboBoxMemorias.Size = new System.Drawing.Size(180, 21);
            this.comboBoxMemorias.TabIndex = 2;
            // 
            // comboBoxDiscos
            // 
            this.comboBoxDiscos.FormattingEnabled = true;
            this.comboBoxDiscos.Items.AddRange(new object[] {
            "HDD 250GB Western",
            "HDD 500GB Western",
            "HDD 1TB Western",
            "SSD 250GB Western"});
            this.comboBoxDiscos.Location = new System.Drawing.Point(299, 110);
            this.comboBoxDiscos.Name = "comboBoxDiscos";
            this.comboBoxDiscos.Size = new System.Drawing.Size(180, 21);
            this.comboBoxDiscos.TabIndex = 2;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 406);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDiscos);
            this.Controls.Add(this.comboBoxMemorias);
            this.Controls.Add(this.comboBoxMicros);
            this.Controls.Add(this.comboBoxMothers);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "frmAdmin";
            this.Text = "Modo Administrador";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.ComboBox comboBoxMothers;
        private System.Windows.Forms.ComboBox comboBoxMicros;
        private System.Windows.Forms.ComboBox comboBoxMemorias;
        private System.Windows.Forms.ComboBox comboBoxDiscos;
    }
}