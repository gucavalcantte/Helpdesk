namespace Ajudai.Apresentacao
{
    partial class frmInicioAdm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogoffAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFecharAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcChamados = new System.Windows.Forms.TabControl();
            this.tbpAbertos = new System.Windows.Forms.TabPage();
            this.btnAtualizarAbertos = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.dgvChamadosAbertos = new System.Windows.Forms.DataGridView();
            this.tbpemAtendimento = new System.Windows.Forms.TabPage();
            this.btnAtualizarAndamento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvChamadosAndamento = new System.Windows.Forms.DataGridView();
            this.tbpConcluidos = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtualizarConcluidos = new System.Windows.Forms.Button();
            this.dgvChamadosConcluidos = new System.Windows.Forms.DataGridView();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tbcChamados.SuspendLayout();
            this.tbpAbertos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAbertos)).BeginInit();
            this.tbpemAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAndamento)).BeginInit();
            this.tbpConcluidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosConcluidos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLogoffAdm,
            this.tsmFecharAdm});
            this.sistemaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // tsmLogoffAdm
            // 
            this.tsmLogoffAdm.Name = "tsmLogoffAdm";
            this.tsmLogoffAdm.Size = new System.Drawing.Size(109, 22);
            this.tsmLogoffAdm.Text = "Logoff";
            this.tsmLogoffAdm.Click += new System.EventHandler(this.tsmLogoffAdm_Click);
            // 
            // tsmFecharAdm
            // 
            this.tsmFecharAdm.Name = "tsmFecharAdm";
            this.tsmFecharAdm.Size = new System.Drawing.Size(109, 22);
            this.tsmFecharAdm.Text = "Fechar";
            this.tsmFecharAdm.Click += new System.EventHandler(this.tsmFecharAdm_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastrar,
            this.tsmPesquisar});
            this.usuáriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.usuáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // tsmCadastrar
            // 
            this.tsmCadastrar.Name = "tsmCadastrar";
            this.tsmCadastrar.Size = new System.Drawing.Size(190, 22);
            this.tsmCadastrar.Text = "Cadastrar Funcionário";
            this.tsmCadastrar.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // tsmPesquisar
            // 
            this.tsmPesquisar.Name = "tsmPesquisar";
            this.tsmPesquisar.Size = new System.Drawing.Size(190, 22);
            this.tsmPesquisar.Text = "Pesquisar Funcionário";
            this.tsmPesquisar.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar Produto";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click_1);
            // 
            // tbcChamados
            // 
            this.tbcChamados.Controls.Add(this.tbpAbertos);
            this.tbcChamados.Controls.Add(this.tbpemAtendimento);
            this.tbcChamados.Controls.Add(this.tbpConcluidos);
            this.tbcChamados.Location = new System.Drawing.Point(12, 36);
            this.tbcChamados.Name = "tbcChamados";
            this.tbcChamados.SelectedIndex = 0;
            this.tbcChamados.Size = new System.Drawing.Size(542, 386);
            this.tbcChamados.TabIndex = 1;
            // 
            // tbpAbertos
            // 
            this.tbpAbertos.BackColor = System.Drawing.Color.Transparent;
            this.tbpAbertos.Controls.Add(this.btnAtualizarAbertos);
            this.tbpAbertos.Controls.Add(this.lblDica);
            this.tbpAbertos.Controls.Add(this.dgvChamadosAbertos);
            this.tbpAbertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpAbertos.Location = new System.Drawing.Point(4, 22);
            this.tbpAbertos.Name = "tbpAbertos";
            this.tbpAbertos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAbertos.Size = new System.Drawing.Size(534, 360);
            this.tbpAbertos.TabIndex = 0;
            this.tbpAbertos.Text = "Chamados em Aberto";
            // 
            // btnAtualizarAbertos
            // 
            this.btnAtualizarAbertos.Location = new System.Drawing.Point(205, 316);
            this.btnAtualizarAbertos.Name = "btnAtualizarAbertos";
            this.btnAtualizarAbertos.Size = new System.Drawing.Size(112, 23);
            this.btnAtualizarAbertos.TabIndex = 4;
            this.btnAtualizarAbertos.Text = "Atualizar Lista";
            this.btnAtualizarAbertos.UseVisualStyleBackColor = true;
            this.btnAtualizarAbertos.Click += new System.EventHandler(this.btnAtualizarAbertos_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(191, 14);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(337, 15);
            this.lblDica.TabIndex = 2;
            this.lblDica.Text = "Dê um clique duplo para visualizar e responder ao chamado";
            // 
            // dgvChamadosAbertos
            // 
            this.dgvChamadosAbertos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvChamadosAbertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamadosAbertos.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosAbertos.Name = "dgvChamadosAbertos";
            this.dgvChamadosAbertos.Size = new System.Drawing.Size(522, 241);
            this.dgvChamadosAbertos.TabIndex = 0;
            this.dgvChamadosAbertos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamadosAbertos_CellDoubleClick);
            // 
            // tbpemAtendimento
            // 
            this.tbpemAtendimento.Controls.Add(this.btnAtualizarAndamento);
            this.tbpemAtendimento.Controls.Add(this.label3);
            this.tbpemAtendimento.Controls.Add(this.dgvChamadosAndamento);
            this.tbpemAtendimento.Location = new System.Drawing.Point(4, 22);
            this.tbpemAtendimento.Name = "tbpemAtendimento";
            this.tbpemAtendimento.Padding = new System.Windows.Forms.Padding(3);
            this.tbpemAtendimento.Size = new System.Drawing.Size(534, 360);
            this.tbpemAtendimento.TabIndex = 2;
            this.tbpemAtendimento.Text = "Chamados em Atendimento";
            this.tbpemAtendimento.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarAndamento
            // 
            this.btnAtualizarAndamento.Location = new System.Drawing.Point(205, 316);
            this.btnAtualizarAndamento.Name = "btnAtualizarAndamento";
            this.btnAtualizarAndamento.Size = new System.Drawing.Size(112, 23);
            this.btnAtualizarAndamento.TabIndex = 8;
            this.btnAtualizarAndamento.Text = "Atualizar Lista";
            this.btnAtualizarAndamento.UseVisualStyleBackColor = true;
            this.btnAtualizarAndamento.Click += new System.EventHandler(this.btnAtualizarAndamento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(191, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dê um clique duplo para visualizar e responder ao chamado";
            // 
            // dgvChamadosAndamento
            // 
            this.dgvChamadosAndamento.AllowUserToAddRows = false;
            this.dgvChamadosAndamento.AllowUserToDeleteRows = false;
            this.dgvChamadosAndamento.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosAndamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChamadosAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamadosAndamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChamadosAndamento.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosAndamento.Name = "dgvChamadosAndamento";
            this.dgvChamadosAndamento.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosAndamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChamadosAndamento.Size = new System.Drawing.Size(522, 241);
            this.dgvChamadosAndamento.TabIndex = 1;
            this.dgvChamadosAndamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamadosAndamento_CellDoubleClick);
            // 
            // tbpConcluidos
            // 
            this.tbpConcluidos.BackColor = System.Drawing.Color.Transparent;
            this.tbpConcluidos.Controls.Add(this.label2);
            this.tbpConcluidos.Controls.Add(this.btnAtualizarConcluidos);
            this.tbpConcluidos.Controls.Add(this.dgvChamadosConcluidos);
            this.tbpConcluidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpConcluidos.Location = new System.Drawing.Point(4, 22);
            this.tbpConcluidos.Name = "tbpConcluidos";
            this.tbpConcluidos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConcluidos.Size = new System.Drawing.Size(534, 360);
            this.tbpConcluidos.TabIndex = 1;
            this.tbpConcluidos.Text = "Chamados Concluídos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(191, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dê um clique duplo para visualizar e responder ao chamado";
            // 
            // btnAtualizarConcluidos
            // 
            this.btnAtualizarConcluidos.Location = new System.Drawing.Point(205, 316);
            this.btnAtualizarConcluidos.Name = "btnAtualizarConcluidos";
            this.btnAtualizarConcluidos.Size = new System.Drawing.Size(112, 23);
            this.btnAtualizarConcluidos.TabIndex = 5;
            this.btnAtualizarConcluidos.Text = "Atualizar Lista";
            this.btnAtualizarConcluidos.UseVisualStyleBackColor = true;
            this.btnAtualizarConcluidos.Click += new System.EventHandler(this.btnAtualizarConcluidos_Click);
            // 
            // dgvChamadosConcluidos
            // 
            this.dgvChamadosConcluidos.AllowUserToAddRows = false;
            this.dgvChamadosConcluidos.AllowUserToDeleteRows = false;
            this.dgvChamadosConcluidos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosConcluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChamadosConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamadosConcluidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvChamadosConcluidos.Location = new System.Drawing.Point(6, 32);
            this.dgvChamadosConcluidos.Name = "dgvChamadosConcluidos";
            this.dgvChamadosConcluidos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamadosConcluidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvChamadosConcluidos.Size = new System.Drawing.Size(522, 241);
            this.dgvChamadosConcluidos.TabIndex = 0;
            this.dgvChamadosConcluidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamadosConcluidos_CellDoubleClick);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(483, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(45, 17);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Nome";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Olá";
            // 
            // frmInicioAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(566, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbcChamados);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmInicioAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio: Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbcChamados.ResumeLayout(false);
            this.tbpAbertos.ResumeLayout(false);
            this.tbpAbertos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAbertos)).EndInit();
            this.tbpemAtendimento.ResumeLayout(false);
            this.tbpemAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosAndamento)).EndInit();
            this.tbpConcluidos.ResumeLayout(false);
            this.tbpConcluidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamadosConcluidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastrar;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmLogoffAdm;
        private System.Windows.Forms.ToolStripMenuItem tsmFecharAdm;
        private System.Windows.Forms.ToolStripMenuItem tsmPesquisar;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.TabControl tbcChamados;
        private System.Windows.Forms.TabPage tbpAbertos;
        private System.Windows.Forms.Button btnAtualizarAbertos;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.DataGridView dgvChamadosAbertos;
        private System.Windows.Forms.TabPage tbpemAtendimento;
        private System.Windows.Forms.TabPage tbpConcluidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtualizarConcluidos;
        private System.Windows.Forms.DataGridView dgvChamadosConcluidos;
        private System.Windows.Forms.Button btnAtualizarAndamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvChamadosAndamento;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label4;
    }
}