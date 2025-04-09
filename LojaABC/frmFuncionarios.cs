using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MosaicoSolutions.ViaCep;
using Google.Protobuf.WellKnownTypes;

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
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
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
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
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
            txtBairro.Clear();
            txtCidade.Clear();
            cbbUF.Items.Clear();
            txtComplemento.Clear();

            txtNome.Focus();
        }
        public void buscaCEP(string cep)
        {
            var ViaCEPService = ViaCepService.Default();

            var endereco = ViaCEPService.ObterEndereco(mskCEP.Text);

            txtLogradouro.Text = endereco.Logradouro;
            txtComplemento.Text = endereco.Complemento;
            txtCidade.Text = endereco.Localidade;
            txtBairro.Text = endereco.Bairro;
            cbbUF.Text = endereco.UF;
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
                txtLogradouro.Text.Equals("") || txtNumero.Text.Equals("") || txtBairro.Text.Equals("") ||
                mskCEP.Text.Equals("     -") || cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Favor, preencha todos os campos!!!");
            }
            else
            {
                if (cadastrarFuncionarios() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    desabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Erro no Cadastro!!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public int cadastrarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,email,cpf,dataNasc,telCel,sexo,lougradoro,cep,numero,complemento,bairro,cidade,uf)values(@nome,@email,@cpf,@dataNasc,@telCel,@sexo,@lougradoro,@cep,@numero,@complemento,@bairro,@cidade,@uf);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = dtpDataDeNascimento.Text;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 14).Value = mskCelular.Text;
            if (rdbFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rdbMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rdbNaoDesejoInformar.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }
            comm.Parameters.Add("@lougradoro", MySqlDbType.VarChar, 100).Value = txtLogradouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCEP.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = cbbUF.Text;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {


                if (e.KeyCode == Keys.Enter)
                {
                    buscaCEP(mskCEP.Text);
                    txtNumero.Focus();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("CEP inválido",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}


