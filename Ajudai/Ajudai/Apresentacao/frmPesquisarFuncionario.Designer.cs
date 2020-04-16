namespace Ajudai.Apresentacao
{
    partial class frmPesquisarFuncionario
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
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnID = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTecnico = new System.Windows.Forms.RadioButton();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            this.txbNomeExibicao = new System.Windows.Forms.TextBox();
            this.lblNomeExibicao = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNomeDeUsuário = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(176, 227);
            this.mskCelular.Mask = "(99)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(86, 20);
            this.mskCelular.TabIndex = 52;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(31, 227);
            this.mskTelefone.Mask = "(99)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(86, 20);
            this.mskTelefone.TabIndex = 51;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(31, 181);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(233, 20);
            this.txbEmail.TabIndex = 50;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "*E-mail";
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(5, 24);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(97, 23);
            this.btnID.TabIndex = 55;
            this.btnID.Text = "ID";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTecnico);
            this.groupBox1.Controls.Add(this.rdbAdministrador);
            this.groupBox1.Location = new System.Drawing.Point(31, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 56);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "*Nível de Acesso";
            // 
            // rdbTecnico
            // 
            this.rdbTecnico.AutoSize = true;
            this.rdbTecnico.Location = new System.Drawing.Point(161, 20);
            this.rdbTecnico.Name = "rdbTecnico";
            this.rdbTecnico.Size = new System.Drawing.Size(64, 17);
            this.rdbTecnico.TabIndex = 0;
            this.rdbTecnico.TabStop = true;
            this.rdbTecnico.Text = "Técnico";
            this.rdbTecnico.UseVisualStyleBackColor = true;
            // 
            // rdbAdministrador
            // 
            this.rdbAdministrador.AutoSize = true;
            this.rdbAdministrador.Location = new System.Drawing.Point(7, 20);
            this.rdbAdministrador.Name = "rdbAdministrador";
            this.rdbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rdbAdministrador.TabIndex = 0;
            this.rdbAdministrador.TabStop = true;
            this.rdbAdministrador.Text = "Administrador";
            this.rdbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txbNomeExibicao
            // 
            this.txbNomeExibicao.Location = new System.Drawing.Point(31, 273);
            this.txbNomeExibicao.Name = "txbNomeExibicao";
            this.txbNomeExibicao.Size = new System.Drawing.Size(233, 20);
            this.txbNomeExibicao.TabIndex = 53;
            // 
            // lblNomeExibicao
            // 
            this.lblNomeExibicao.AutoSize = true;
            this.lblNomeExibicao.Location = new System.Drawing.Point(28, 257);
            this.lblNomeExibicao.Name = "lblNomeExibicao";
            this.lblNomeExibicao.Size = new System.Drawing.Size(93, 13);
            this.lblNomeExibicao.TabIndex = 37;
            this.lblNomeExibicao.Text = "Nome de Exibição";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(173, 212);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 42;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(28, 211);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 41;
            this.lblTelefone.Text = "Telefone";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(29, 135);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(233, 20);
            this.txbNome.TabIndex = 49;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 119);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 40;
            this.lblNome.Text = "*Nome";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(31, 43);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(63, 20);
            this.txbId.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ID";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(31, 89);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(233, 20);
            this.txbUsuario.TabIndex = 46;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 13);
            this.lblUsuario.TabIndex = 43;
            this.lblUsuario.Text = "*Nome de Usuário";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(302, 150);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 23);
            this.btnEditar.TabIndex = 58;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNomeDeUsuário
            // 
            this.btnNomeDeUsuário.Location = new System.Drawing.Point(5, 53);
            this.btnNomeDeUsuário.Name = "btnNomeDeUsuário";
            this.btnNomeDeUsuário.Size = new System.Drawing.Size(97, 23);
            this.btnNomeDeUsuário.TabIndex = 60;
            this.btnNomeDeUsuário.Text = "Nome de Usuário";
            this.btnNomeDeUsuário.UseVisualStyleBackColor = true;
            this.btnNomeDeUsuário.Click += new System.EventHandler(this.btnNomeDeUsuário_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(302, 186);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 23);
            this.btnExcluir.TabIndex = 59;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(6, 82);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(97, 23);
            this.btnTodos.TabIndex = 61;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnID);
            this.groupBox2.Controls.Add(this.btnTodos);
            this.groupBox2.Controls.Add(this.btnNomeDeUsuário);
            this.groupBox2.Location = new System.Drawing.Point(296, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 118);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar por:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(302, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 23);
            this.btnLimpar.TabIndex = 63;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 361);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "(*) Campos obrigatórios na edição";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(285, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 212);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(302, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 23);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(431, 389);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.mskCelular);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbNomeExibicao);
            this.Controls.Add(this.lblNomeExibicao);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPesquisarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.RadioButton rdbTecnico;
        private System.Windows.Forms.RadioButton rdbAdministrador;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNomeDeUsuário;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.MaskedTextBox mskCelular;
        public System.Windows.Forms.MaskedTextBox mskTelefone;
        public System.Windows.Forms.TextBox txbEmail;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txbNomeExibicao;
        public System.Windows.Forms.Label lblNomeExibicao;
        public System.Windows.Forms.Label lblCelular;
        public System.Windows.Forms.Label lblTelefone;
        public System.Windows.Forms.TextBox txbNome;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.TextBox txbId;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
    }
}