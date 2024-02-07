namespace PSalario
{
    partial class frmSalario
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
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.btnVerificadorDesconto = new System.Windows.Forms.Button();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.txtAliquotaINSS = new System.Windows.Forms.TextBox();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnSexoF = new System.Windows.Forms.RadioButton();
            this.rbtnSexoM = new System.Windows.Forms.RadioButton();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.cbxNumeroFilhos = new System.Windows.Forms.ComboBox();
            this.pnlCasado.SuspendLayout();
            this.grpbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(12, 9);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(130, 18);
            this.lblNomeFuncionario.TabIndex = 0;
            this.lblNomeFuncionario.Text = "Nome funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(45, 49);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(97, 18);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salário bruto";
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(159, 46);
            this.mskbxSalarioBruto.Mask = "99990.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(144, 26);
            this.mskbxSalarioBruto.TabIndex = 1;
            this.mskbxSalarioBruto.Validated += new System.EventHandler(this.mskbxSalarioBruto_Validated);
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Location = new System.Drawing.Point(17, 89);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(125, 18);
            this.lblNumeroFilhos.TabIndex = 4;
            this.lblNumeroFilhos.Text = "Número de filhos";
            // 
            // btnVerificadorDesconto
            // 
            this.btnVerificadorDesconto.Location = new System.Drawing.Point(68, 186);
            this.btnVerificadorDesconto.Name = "btnVerificadorDesconto";
            this.btnVerificadorDesconto.Size = new System.Drawing.Size(166, 23);
            this.btnVerificadorDesconto.TabIndex = 3;
            this.btnVerificadorDesconto.Text = "Verifica Descontos";
            this.btnVerificadorDesconto.UseVisualStyleBackColor = true;
            this.btnVerificadorDesconto.Click += new System.EventHandler(this.btnVerificadorDesconto_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(159, 6);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(144, 26);
            this.txtNomeFuncionario.TabIndex = 0;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(17, 252);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(13, 18);
            this.lblDados.TabIndex = 8;
            this.lblDados.Text = "-";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Location = new System.Drawing.Point(38, 317);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(104, 18);
            this.lblAliquotaINSS.TabIndex = 9;
            this.lblAliquotaINSS.Text = "Alíquota INSS";
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Location = new System.Drawing.Point(159, 314);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(144, 26);
            this.txtAliquotaINSS.TabIndex = 10;
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(39, 354);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(103, 18);
            this.lblAliquotaIRPF.TabIndex = 11;
            this.lblAliquotaIRPF.Text = "Alíquota IRPF";
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(159, 351);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(144, 26);
            this.txtAliquotaIRPF.TabIndex = 12;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(28, 391);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(114, 18);
            this.lblSalarioFamilia.TabIndex = 13;
            this.lblSalarioFamilia.Text = "Salário Familia";
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(159, 388);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(144, 26);
            this.txtSalarioFamilia.TabIndex = 14;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(29, 428);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(113, 18);
            this.lblSalarioLiquido.TabIndex = 15;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(159, 425);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(144, 26);
            this.txtSalarioLiquido.TabIndex = 16;
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Location = new System.Drawing.Point(363, 317);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(115, 18);
            this.lblDescontoINSS.TabIndex = 17;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Location = new System.Drawing.Point(493, 309);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(100, 26);
            this.txtDescontoINSS.TabIndex = 18;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Location = new System.Drawing.Point(366, 132);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(227, 77);
            this.pnlCasado.TabIndex = 19;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(29, 20);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(83, 22);
            this.ckbxCasado.TabIndex = 6;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.rbtnSexoF);
            this.grpbxSexo.Controls.Add(this.rbtnSexoM);
            this.grpbxSexo.Location = new System.Drawing.Point(366, 26);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Size = new System.Drawing.Size(227, 100);
            this.grpbxSexo.TabIndex = 20;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "Sexo";
            // 
            // rbtnSexoF
            // 
            this.rbtnSexoF.AutoSize = true;
            this.rbtnSexoF.Location = new System.Drawing.Point(29, 64);
            this.rbtnSexoF.Name = "rbtnSexoF";
            this.rbtnSexoF.Size = new System.Drawing.Size(91, 22);
            this.rbtnSexoF.TabIndex = 5;
            this.rbtnSexoF.Text = "Feminino";
            this.rbtnSexoF.UseVisualStyleBackColor = true;
            // 
            // rbtnSexoM
            // 
            this.rbtnSexoM.AutoSize = true;
            this.rbtnSexoM.Checked = true;
            this.rbtnSexoM.Location = new System.Drawing.Point(29, 35);
            this.rbtnSexoM.Name = "rbtnSexoM";
            this.rbtnSexoM.Size = new System.Drawing.Size(96, 22);
            this.rbtnSexoM.TabIndex = 4;
            this.rbtnSexoM.TabStop = true;
            this.rbtnSexoM.Text = "Masculino";
            this.rbtnSexoM.UseVisualStyleBackColor = true;
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Location = new System.Drawing.Point(364, 349);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(114, 18);
            this.lblDescontoIRPF.TabIndex = 21;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Location = new System.Drawing.Point(493, 341);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(100, 26);
            this.txtDescontoIRPF.TabIndex = 22;
            // 
            // cbxNumeroFilhos
            // 
            this.cbxNumeroFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumeroFilhos.FormattingEnabled = true;
            this.cbxNumeroFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbxNumeroFilhos.Location = new System.Drawing.Point(159, 86);
            this.cbxNumeroFilhos.Name = "cbxNumeroFilhos";
            this.cbxNumeroFilhos.Size = new System.Drawing.Size(144, 26);
            this.cbxNumeroFilhos.TabIndex = 2;
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 468);
            this.Controls.Add(this.cbxNumeroFilhos);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.grpbxSexo);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.btnVerificadorDesconto);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalario";
            this.Text = "Calculo Salário";
            this.Load += new System.EventHandler(this.frmSalario_Load);
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.Button btnVerificadorDesconto;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.TextBox txtAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.RadioButton rbtnSexoF;
        private System.Windows.Forms.RadioButton rbtnSexoM;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.ComboBox cbxNumeroFilhos;
    }
}

