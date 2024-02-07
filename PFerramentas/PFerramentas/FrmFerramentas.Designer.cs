namespace PFerramentas
{
    partial class FrmFerramentas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFerramentas));
            this.bnvFerramenta = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbFerramenta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvFerramenta = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxDistribuicao = new System.Windows.Forms.ComboBox();
            this.dtpDtCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtSiteOficial = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdFerramenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblCad = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblForn = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvFerramenta)).BeginInit();
            this.bnvFerramenta.SuspendLayout();
            this.tbFerramenta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnvFerramenta
            // 
            this.bnvFerramenta.AddNewItem = null;
            this.bnvFerramenta.CountItem = this.bindingNavigatorCountItem;
            this.bnvFerramenta.DeleteItem = null;
            this.bnvFerramenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovo,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnvFerramenta.Location = new System.Drawing.Point(0, 0);
            this.bnvFerramenta.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvFerramenta.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvFerramenta.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvFerramenta.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvFerramenta.Name = "bnvFerramenta";
            this.bnvFerramenta.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvFerramenta.Size = new System.Drawing.Size(800, 25);
            this.bnvFerramenta.TabIndex = 0;
            this.bnvFerramenta.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo registro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tbFerramenta
            // 
            this.tbFerramenta.Controls.Add(this.tabPage1);
            this.tbFerramenta.Controls.Add(this.tabPage2);
            this.tbFerramenta.Location = new System.Drawing.Point(12, 28);
            this.tbFerramenta.Name = "tbFerramenta";
            this.tbFerramenta.SelectedIndex = 0;
            this.tbFerramenta.Size = new System.Drawing.Size(776, 369);
            this.tbFerramenta.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvFerramenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvFerramenta
            // 
            this.dgvFerramenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramenta.Location = new System.Drawing.Point(6, 23);
            this.dgvFerramenta.Name = "dgvFerramenta";
            this.dgvFerramenta.Size = new System.Drawing.Size(756, 320);
            this.dgvFerramenta.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbxCategoria);
            this.tabPage2.Controls.Add(this.cbxDistribuicao);
            this.tabPage2.Controls.Add(this.dtpDtCadastro);
            this.tabPage2.Controls.Add(this.txtSiteOficial);
            this.tabPage2.Controls.Add(this.txtFornecedor);
            this.tabPage2.Controls.Add(this.txtNome);
            this.tabPage2.Controls.Add(this.txtIdFerramenta);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblCat);
            this.tabPage2.Controls.Add(this.lblSite);
            this.tabPage2.Controls.Add(this.lblCad);
            this.tabPage2.Controls.Add(this.lblDist);
            this.tabPage2.Controls.Add(this.lblForn);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Controls.Add(this.lblID);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(102, 227);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 17;
            // 
            // cbxDistribuicao
            // 
            this.cbxDistribuicao.FormattingEnabled = true;
            this.cbxDistribuicao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbxDistribuicao.Location = new System.Drawing.Point(102, 133);
            this.cbxDistribuicao.Name = "cbxDistribuicao";
            this.cbxDistribuicao.Size = new System.Drawing.Size(121, 21);
            this.cbxDistribuicao.TabIndex = 16;
            // 
            // dtpDtCadastro
            // 
            this.dtpDtCadastro.Location = new System.Drawing.Point(102, 164);
            this.dtpDtCadastro.Name = "dtpDtCadastro";
            this.dtpDtCadastro.Size = new System.Drawing.Size(200, 20);
            this.dtpDtCadastro.TabIndex = 15;
            // 
            // txtSiteOficial
            // 
            this.txtSiteOficial.Location = new System.Drawing.Point(102, 194);
            this.txtSiteOficial.Name = "txtSiteOficial";
            this.txtSiteOficial.Size = new System.Drawing.Size(100, 20);
            this.txtSiteOficial.TabIndex = 13;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(102, 103);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(100, 20);
            this.txtFornecedor.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtIdFerramenta
            // 
            this.txtIdFerramenta.Location = new System.Drawing.Point(102, 18);
            this.txtIdFerramenta.Name = "txtIdFerramenta";
            this.txtIdFerramenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdFerramenta.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = " 1 - Grátis 2- Paga  3-Parceria  4-Outras";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(34, 235);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 6;
            this.lblCat.Text = "Categoria";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(29, 201);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(57, 13);
            this.lblSite.TabIndex = 5;
            this.lblSite.Text = "Site Oficial";
            // 
            // lblCad
            // 
            this.lblCad.AutoSize = true;
            this.lblCad.Location = new System.Drawing.Point(11, 170);
            this.lblCad.Name = "lblCad";
            this.lblCad.Size = new System.Drawing.Size(75, 13);
            this.lblCad.TabIndex = 4;
            this.lblCad.Text = "Data Cadastro";
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(29, 141);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(62, 13);
            this.lblDist.TabIndex = 3;
            this.lblDist.Text = "Distribuição";
            // 
            // lblForn
            // 
            this.lblForn.AutoSize = true;
            this.lblForn.Location = new System.Drawing.Point(25, 110);
            this.lblForn.Name = "lblForn";
            this.lblForn.Size = new System.Drawing.Size(61, 13);
            this.lblForn.TabIndex = 2;
            this.lblForn.Text = "Fornecedor";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // FrmFerramentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbFerramenta);
            this.Controls.Add(this.bnvFerramenta);
            this.Name = "FrmFerramentas";
            this.Text = "FrmFerramentas";
            this.Load += new System.EventHandler(this.FrmFerramentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvFerramenta)).EndInit();
            this.bnvFerramenta.ResumeLayout(false);
            this.bnvFerramenta.PerformLayout();
            this.tbFerramenta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvFerramenta;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbFerramenta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFerramenta;
        private System.Windows.Forms.Label lblForn;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtSiteOficial;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdFerramenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxDistribuicao;
        private System.Windows.Forms.DateTimePicker dtpDtCadastro;
    }
}