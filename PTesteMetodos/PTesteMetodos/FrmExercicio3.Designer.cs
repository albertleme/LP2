namespace PTesteMetodos
{
    partial class FrmExercicio3
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemoveOcorrencia = new System.Windows.Forms.Button();
            this.btnRemoveOcorrenciasReplace = new System.Windows.Forms.Button();
            this.btnInverte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(35, 46);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(74, 18);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(35, 86);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(74, 18);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(112, 43);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(264, 26);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(112, 83);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(264, 26);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnRemoveOcorrencia
            // 
            this.btnRemoveOcorrencia.Location = new System.Drawing.Point(38, 152);
            this.btnRemoveOcorrencia.Name = "btnRemoveOcorrencia";
            this.btnRemoveOcorrencia.Size = new System.Drawing.Size(106, 75);
            this.btnRemoveOcorrencia.TabIndex = 4;
            this.btnRemoveOcorrencia.Text = "Remove Ocorrências";
            this.btnRemoveOcorrencia.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrencia.Click += new System.EventHandler(this.btnRemoveOcorrencia_Click);
            // 
            // btnRemoveOcorrenciasReplace
            // 
            this.btnRemoveOcorrenciasReplace.Location = new System.Drawing.Point(161, 152);
            this.btnRemoveOcorrenciasReplace.Name = "btnRemoveOcorrenciasReplace";
            this.btnRemoveOcorrenciasReplace.Size = new System.Drawing.Size(106, 75);
            this.btnRemoveOcorrenciasReplace.TabIndex = 5;
            this.btnRemoveOcorrenciasReplace.Text = "Remove Ocorrências (Replace)";
            this.btnRemoveOcorrenciasReplace.UseVisualStyleBackColor = true;
            this.btnRemoveOcorrenciasReplace.Click += new System.EventHandler(this.btnRemoveOcorrenciasReplace_Click);
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(279, 152);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(106, 75);
            this.btnInverte.TabIndex = 6;
            this.btnInverte.Text = "Inverte (Reverse)";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemoveOcorrenciasReplace);
            this.Controls.Add(this.btnRemoveOcorrencia);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnRemoveOcorrencia;
        private System.Windows.Forms.Button btnRemoveOcorrenciasReplace;
        private System.Windows.Forms.Button btnInverte;
    }
}