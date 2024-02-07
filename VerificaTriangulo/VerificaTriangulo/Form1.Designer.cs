namespace VerificaTriangulo
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
            this.lblValorA = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblValorC = new System.Windows.Forms.Label();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.btnVerificador = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(12, 9);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(58, 18);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(98, 6);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(158, 26);
            this.txtValorA.TabIndex = 0;
            this.txtValorA.Validated += new System.EventHandler(this.txtValorA_Validated);
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(11, 44);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(59, 18);
            this.lblValorB.TabIndex = 2;
            this.lblValorB.Text = "Valor B";
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(98, 41);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(158, 26);
            this.txtValorB.TabIndex = 1;
            this.txtValorB.Validated += new System.EventHandler(this.txtValorB_Validated);
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Location = new System.Drawing.Point(10, 79);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(60, 18);
            this.lblValorC.TabIndex = 4;
            this.lblValorC.Text = "Valor C";
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(98, 76);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(158, 26);
            this.txtValorC.TabIndex = 2;
            this.txtValorC.Validated += new System.EventHandler(this.txtValorC_Validated);
            // 
            // btnVerificador
            // 
            this.btnVerificador.Location = new System.Drawing.Point(39, 126);
            this.btnVerificador.Name = "btnVerificador";
            this.btnVerificador.Size = new System.Drawing.Size(75, 23);
            this.btnVerificador.TabIndex = 3;
            this.btnVerificador.Text = "Verificar";
            this.btnVerificador.UseVisualStyleBackColor = true;
            this.btnVerificador.Click += new System.EventHandler(this.btnVerificador_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(145, 126);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 175);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificador);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValorA);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Identificador de triângulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.TextBox txtValorC;
        private System.Windows.Forms.Button btnVerificador;
        private System.Windows.Forms.Button btnLimpar;
    }
}

