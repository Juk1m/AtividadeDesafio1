namespace AtividadeDesafio1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.LbnPeso = new System.Windows.Forms.Label();
            this.LbnAltura = new System.Windows.Forms.Label();
            this.LbnImc = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtImc = new System.Windows.Forms.TextBox();
            this.lbnResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(301, 148);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // LbnPeso
            // 
            this.LbnPeso.AutoSize = true;
            this.LbnPeso.Location = new System.Drawing.Point(240, 77);
            this.LbnPeso.Name = "LbnPeso";
            this.LbnPeso.Size = new System.Drawing.Size(34, 13);
            this.LbnPeso.TabIndex = 1;
            this.LbnPeso.Text = "Peso:";
            // 
            // LbnAltura
            // 
            this.LbnAltura.AutoSize = true;
            this.LbnAltura.Location = new System.Drawing.Point(240, 110);
            this.LbnAltura.Name = "LbnAltura";
            this.LbnAltura.Size = new System.Drawing.Size(34, 13);
            this.LbnAltura.TabIndex = 2;
            this.LbnAltura.Text = "Altura";
            // 
            // LbnImc
            // 
            this.LbnImc.AutoSize = true;
            this.LbnImc.Location = new System.Drawing.Point(248, 186);
            this.LbnImc.Name = "LbnImc";
            this.LbnImc.Size = new System.Drawing.Size(26, 13);
            this.LbnImc.TabIndex = 3;
            this.LbnImc.Text = "IMC";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(290, 70);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPeso.TabIndex = 4;
            this.TxtPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(290, 107);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 20);
            this.TxtAltura.TabIndex = 5;
            this.TxtAltura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtImc
            // 
            this.TxtImc.AcceptsReturn = true;
            this.TxtImc.Location = new System.Drawing.Point(290, 186);
            this.TxtImc.Name = "TxtImc";
            this.TxtImc.Size = new System.Drawing.Size(100, 20);
            this.TxtImc.TabIndex = 6;
            this.TxtImc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbnResultado
            // 
            this.lbnResultado.AutoSize = true;
            this.lbnResultado.Location = new System.Drawing.Point(295, 224);
            this.lbnResultado.Name = "lbnResultado";
            this.lbnResultado.Size = new System.Drawing.Size(0, 13);
            this.lbnResultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbnResultado);
            this.Controls.Add(this.TxtImc);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.LbnImc);
            this.Controls.Add(this.LbnAltura);
            this.Controls.Add(this.LbnPeso);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label LbnPeso;
        private System.Windows.Forms.Label LbnAltura;
        private System.Windows.Forms.Label LbnImc;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtImc;
        private System.Windows.Forms.Label lbnResultado;
    }
}

