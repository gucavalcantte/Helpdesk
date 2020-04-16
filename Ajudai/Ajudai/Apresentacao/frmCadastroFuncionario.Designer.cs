namespace Ajudai.Apresentacao
{
    partial class frmCadastroFuncionario
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTecnico = new System.Windows.Forms.RadioButton();
            this.rdbAdministrador = new System.Windows.Forms.RadioButton();
            this.txbNomeExibicao = new System.Windows.Forms.TextBox();
            this.lblNomeExibicao = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-mail*";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 19);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(93, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTecnico);
            this.groupBox1.Controls.Add(this.rdbAdministrador);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(38, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nível de Acesso*";
            // 
            // rdbTecnico
            // 
            this.rdbTecnico.AutoSize = true;
            this.rdbTecnico.Location = new System.Drawing.Point(160, 19);
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
            this.txbNomeExibicao.Location = new System.Drawing.Point(62, 180);
            this.txbNomeExibicao.Name = "txbNomeExibicao";
            this.txbNomeExibicao.Size = new System.Drawing.Size(178, 20);
            this.txbNomeExibicao.TabIndex = 8;
            // 
            // lblNomeExibicao
            // 
            this.lblNomeExibicao.AutoSize = true;
            this.lblNomeExibicao.Location = new System.Drawing.Point(59, 164);
            this.lblNomeExibicao.Name = "lblNomeExibicao";
            this.lblNomeExibicao.Size = new System.Drawing.Size(42, 13);
            this.lblNomeExibicao.TabIndex = 0;
            this.lblNomeExibicao.Text = "Apelido";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(151, 117);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 0;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(59, 118);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(11, 42);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(282, 20);
            this.txbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(86, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo*";
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(155, 83);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.PasswordChar = '*';
            this.txbConfirmar.Size = new System.Drawing.Size(138, 20);
            this.txbConfirmar.TabIndex = 3;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(152, 66);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(89, 13);
            this.lblConfirmar.TabIndex = 0;
            this.lblConfirmar.Text = "Confirmar Senha*";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(11, 83);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(138, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(11, 67);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha*";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(11, 37);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(138, 20);
            this.txbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(11, 21);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nome de Usuário*";
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(327, 9);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(0, 13);
            this.lblCamposObrigatorios.TabIndex = 36;
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCampos.Location = new System.Drawing.Point(176, 16);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(121, 13);
            this.lblCampos.TabIndex = 0;
            this.lblCampos.Text = "( * ) Campos obrigatórios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(204, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(62, 134);
            this.mskTelefone.Mask = "(99)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(86, 20);
            this.mskTelefone.TabIndex = 6;
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(154, 134);
            this.mskCelular.Mask = "(99)00000-0000";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(86, 20);
            this.mskCelular.TabIndex = 7;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(11, 88);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(282, 20);
            this.txbEmail.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(105, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 23);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblCampos);
            this.groupBox2.Controls.Add(this.txbSenha);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Controls.Add(this.txbUsuario);
            this.groupBox2.Controls.Add(this.lblSenha);
            this.groupBox2.Controls.Add(this.txbConfirmar);
            this.groupBox2.Controls.Add(this.lblConfirmar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(39, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 179);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados de Acesso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNomeExibicao);
            this.groupBox3.Controls.Add(this.mskCelular);
            this.groupBox3.Controls.Add(this.mskTelefone);
            this.groupBox3.Controls.Add(this.txbNomeExibicao);
            this.groupBox3.Controls.Add(this.lblNome);
            this.groupBox3.Controls.Add(this.txbNome);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Controls.Add(this.txbEmail);
            this.groupBox3.Controls.Add(this.lblCelular);
            this.groupBox3.Controls.Add(this.lblTelefone);
            this.groupBox3.Location = new System.Drawing.Point(39, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 218);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Pessoais";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCadastrar);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Location = new System.Drawing.Point(39, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 50);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // frmCadastroFuncionario
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(384, 496);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblCamposObrigatorios);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTecnico;
        private System.Windows.Forms.RadioButton rdbAdministrador;
        private System.Windows.Forms.TextBox txbNomeExibicao;
        private System.Windows.Forms.Label lblNomeExibicao;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}