using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaABC
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmFuncionarios(string descricao)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = descricao;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }

        public void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            dtpDataDeNascimento.Enabled = false;
            mskCEP.Enabled = false;
            gpbSexo.Enabled = false;
            mskCelular.Enabled = false;

            txtLogradouro.Enabled = false;
            mskCEP.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            cbbUF.Enabled = false;
            txtComplemento.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataDeNascimento.Enabled = true;
            mskCEP.Enabled = true;
            gpbSexo.Enabled = true;
            mskCelular.Enabled = true;

            txtLogradouro.Enabled = true;
            mskCEP.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            cbbUF.Enabled = true;
            txtComplemento.Enabled = true;

            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;

            txtNome.Focus();

        }
        public void limparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            dtpDataDeNascimento.Text = "";
            mskCEP.Clear();
            mskCelular.Clear();
            rdbMasculino.Checked = false;
            rdbNaoDesejoInformar.Checked = false;
            rdbFeminino.Checked = false;

            txtLogradouro.Clear();
            mskCEP.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            cbbUF.Items.Clear();
            txtComplemento.Clear();

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionario abrir = new frmPesquisarFuncionario();
            abrir.Show();
            this.Hide();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskCPF.Text.Equals("   .   .   -") || mskCelular.Text.Equals("     -") ||
                txtLogradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtComplemento.Text.Equals("") || txtCidade.Text.Equals("") ||
                mskCEP.Text.Equals("     -") || cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Favor, preencha todos os campos!!!");
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!!!");
                limparCampos();
                desabilitarCampos();
            }
        }
    }
}


