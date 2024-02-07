namespace PTesteMetodos
{
    partial class FrmExercicio4
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
            this.rtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnCaracteresNumericos = new System.Windows.Forms.Button();
            this.btnPrimeiroBranco = new System.Windows.Forms.Button();
            this.btnCaracteresAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtFrase
            // 
            this.rtxtFrase.Location = new System.Drawing.Point(13, 13);
            this.rtxtFrase.Name = "rtxtFrase";
            this.rtxtFrase.Size = new System.Drawing.Size(422, 140);
            this.rtxtFrase.TabIndex = 0;
            this.rtxtFrase.Text = "";
            // 
            // btnCaracteresNumericos
            // 
            this.btnCaracteresNumericos.Location = new System.Drawing.Point(35, 172);
            this.btnCaracteresNumericos.Name = "btnCaracteresNumericos";
            this.btnCaracteresNumericos.Size = new System.Drawing.Size(103, 69);
            this.btnCaracteresNumericos.TabIndex = 1;
            this.btnCaracteresNumericos.Text = "Caracteres Numéricos";
            this.btnCaracteresNumericos.UseVisualStyleBackColor = true;
            this.btnCaracteresNumericos.Click += new System.EventHandler(this.btnCaracteresNumericos_Click);
            // 
            // btnPrimeiroBranco
            // 
            this.btnPrimeiroBranco.Location = new System.Drawing.Point(174, 172);
            this.btnPrimeiroBranco.Name = "btnPrimeiroBranco";
            this.btnPrimeiroBranco.Size = new System.Drawing.Size(103, 69);
            this.btnPrimeiroBranco.TabIndex = 2;
            this.btnPrimeiroBranco.Text = "Primeiro Caracter Branco";
            this.btnPrimeiroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeiroBranco.Click += new System.EventHandler(this.btnPrimeiroBranco_Click);
            // 
            // btnCaracteresAlfabeticos
            // 
            this.btnCaracteresAlfabeticos.Location = new System.Drawing.Point(313, 172);
            this.btnCaracteresAlfabeticos.Name = "btnCaracteresAlfabeticos";
            this.btnCaracteresAlfabeticos.Size = new System.Drawing.Size(103, 69);
            this.btnCaracteresAlfabeticos.TabIndex = 3;
            this.btnCaracteresAlfabeticos.Text = "Caracteres Alfabéticos";
            this.btnCaracteresAlfabeticos.UseVisualStyleBackColor = true;
            this.btnCaracteresAlfabeticos.Click += new System.EventHandler(this.btnCaracteresAlfabeticos_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 272);
            this.Controls.Add(this.btnCaracteresAlfabeticos);
            this.Controls.Add(this.btnPrimeiroBranco);
            this.Controls.Add(this.btnCaracteresNumericos);
            this.Controls.Add(this.rtxtFrase);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmExercicio4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtFrase;
        private System.Windows.Forms.Button btnCaracteresNumericos;
        private System.Windows.Forms.Button btnPrimeiroBranco;
        private System.Windows.Forms.Button btnCaracteresAlfabeticos;
    }
}