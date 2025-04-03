using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaABC
{
    public partial class frmPesquisarFuncionario : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisarFuncionario()

        {
            InitializeComponent();
            desabilitarCampos();

        }
        public void limparCampos()
        {
            rdbNome.Checked = false;
            rdbCodigo.Checked = false;
            ltbPesquisar.Items.Clear();
            txtDescrição.Clear();
            txtDescrição.Focus();
        }

        public void desabilitarCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescrição.Focus();
            txtDescrição.Enabled = false;
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void desabilitarCamposPesquisa()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescrição.Clear();
            txtDescrição.Focus();
            txtDescrição.Enabled = false;

        }


            public void habilitarCampos()
        {
            txtDescrição.Enabled = true;
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescrição.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmFuncionarios voltar = new frmFuncionarios();
            voltar.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbPesquisar.SelectedItem.ToString();
            frmFuncionarios abrir = new frmFuncionarios(descricao);
            abrir.Show();
            this.Hide();




        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(txtDescrição.Text);;
            desabilitarCamposPesquisa();
        }
    }
}
