﻿
namespace LojaABC
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbNaoDesejoInformar = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCIdade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.cbbUF = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.mskCelular);
            this.gpbDadosPessoais.Controls.Add(this.lblCelular);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataDeNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblDataDeNascimento);
            this.gpbDadosPessoais.Controls.Add(this.mskCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtCodigo);
            this.gpbDadosPessoais.Controls.Add(this.lblCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(761, 227);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mskCelular
            // 
            this.mskCelular.Location = new System.Drawing.Point(522, 64);
            this.mskCelular.Mask = "99999-9999";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(94, 26);
            this.mskCelular.TabIndex = 6;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(463, 70);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 20);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Celular";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbMasculino);
            this.gpbSexo.Controls.Add(this.rdbNaoDesejoInformar);
            this.gpbSexo.Controls.Add(this.rdbFeminino);
            this.gpbSexo.Location = new System.Drawing.Point(1, 106);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 100);
            this.gpbSexo.TabIndex = 7;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(23, 22);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbNaoDesejoInformar
            // 
            this.rdbNaoDesejoInformar.AutoSize = true;
            this.rdbNaoDesejoInformar.Location = new System.Drawing.Point(23, 70);
            this.rdbNaoDesejoInformar.Name = "rdbNaoDesejoInformar";
            this.rdbNaoDesejoInformar.Size = new System.Drawing.Size(169, 24);
            this.rdbNaoDesejoInformar.TabIndex = 10;
            this.rdbNaoDesejoInformar.TabStop = true;
            this.rdbNaoDesejoInformar.Text = "Não desejo informar";
            this.rdbNaoDesejoInformar.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(23, 46);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(92, 24);
            this.rdbFeminino.TabIndex = 9;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(338, 67);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(112, 26);
            this.dtpDataDeNascimento.TabIndex = 5;
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Location = new System.Drawing.Point(178, 70);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(154, 20);
            this.lblDataDeNascimento.TabIndex = 9;
            this.lblDataDeNascimento.Text = "Data de Nacismento";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(51, 67);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(121, 26);
            this.mskCPF.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(6, 70);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(513, 29);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(460, 32);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(220, 29);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(167, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(62, 29);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(90, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(12, 470);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(761, 79);
            this.pnlCRUD.TabIndex = 19;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.Location = new System.Drawing.Point(649, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 50);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(543, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 50);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pes&quisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(437, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 50);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "L&impar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(328, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 50);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(222, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 50);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "A&lterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(116, 14);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 50);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(10, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 50);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lblCIdade);
            this.gpbEndereco.Controls.Add(this.lblUF);
            this.gpbEndereco.Controls.Add(this.cbbUF);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.txtComplemento);
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.mskCEP);
            this.gpbEndereco.Controls.Add(this.lblCEP);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(12, 245);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(761, 139);
            this.gpbEndereco.TabIndex = 11;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(349, 62);
            this.txtCidade.MaxLength = 100;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(131, 26);
            this.txtCidade.TabIndex = 16;
            // 
            // lblCIdade
            // 
            this.lblCIdade.AutoSize = true;
            this.lblCIdade.Location = new System.Drawing.Point(284, 65);
            this.lblCIdade.Name = "lblCIdade";
            this.lblCIdade.Size = new System.Drawing.Size(60, 20);
            this.lblCIdade.TabIndex = 27;
            this.lblCIdade.Text = "Estado";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(6, 99);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(31, 20);
            this.lblUF.TabIndex = 26;
            this.lblUF.Text = "UF";
            // 
            // cbbUF
            // 
            this.cbbUF.FormattingEnabled = true;
            this.cbbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbbUF.Location = new System.Drawing.Point(43, 94);
            this.cbbUF.Name = "cbbUF";
            this.cbbUF.Size = new System.Drawing.Size(121, 28);
            this.cbbUF.TabIndex = 18;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(553, 62);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(202, 26);
            this.txtBairro.TabIndex = 17;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(496, 65);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 23;
            this.lblBairro.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(117, 62);
            this.txtComplemento.MaxLength = 100;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(147, 26);
            this.txtComplemento.TabIndex = 15;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(3, 65);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblComplemento.TabIndex = 21;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(677, 30);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 26);
            this.txtNumero.TabIndex = 14;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(606, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 19;
            this.lblNumero.Text = "Número";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(510, 30);
            this.mskCEP.Mask = "99999-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(88, 26);
            this.mskCEP.TabIndex = 13;
            this.mskCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCEP_KeyDown);
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(463, 33);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 5;
            this.lblCEP.Text = "CEP";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(91, 30);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(359, 26);
            this.txtLogradouro.TabIndex = 12;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(3, 33);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(82, 20);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradoro";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lolja - Funcionários";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.Label lblDataDeNascimento;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbNaoDesejoInformar;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCIdade;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.ComboBox cbbUF;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}