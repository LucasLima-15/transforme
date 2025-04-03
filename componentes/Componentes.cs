using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes
{
    public partial class frmComponentes : Form
    {
        public frmComponentes()
        {
            InitializeComponent();
        }

        public void limparComponentes()
        {
            txtNome.Clear();
            ckbBanana.Checked = false;
            ckbComputador.Checked = false;
            ckbLivros.Checked = false;
            ckbMesa.Checked = false;
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNome.Text.Equals(""))
                MessageBox.Show("favor, insira um nome");

            else
            {


                if (e.KeyCode == Keys.Enter)
                {
                    cbbListarNomes.Items.Add(txtNome.Text);
                    txtNome.Clear();
                    txtNome.Focus();

                }
            }
        }

        private void ckbLivros_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLivros.Checked)
            {
                ltbListarProdutos.Items.Add("Livros");
                pcbImagem.Load(@".\imagens\livro.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbLivros.Text);
                pcbImagem.Image = null;
            }
        }

        private void ckbComputador_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbComputador.Checked)
            {
                ltbListarProdutos.Items.Add("Computador");
                pcbImagem.Load(@".\imagens\computador.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbComputador.Text);
                pcbImagem.Image = null;
            }
        }

        private void ckbMesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMesa.Checked)
            {
                ltbListarProdutos.Items.Add("Mesa");
                pcbImagem.Load(@".\imagens\mesa.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbMesa.Text);
                pcbImagem.Image = null;
            }
        }

        private void ckbBanana_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBanana.Checked)
            {
                ltbListarProdutos.Items.Add("Banana");
                pcbImagem.Load(@".\imagens\banana.png");
            }
            else
            {
                ltbListarProdutos.Items.Remove(ckbBanana.Text);
                pcbImagem.Image = null;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            //meio de carregar imagem
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione uma imagem";
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp|Todos os arquivos|*.*";
            ofd.ShowDialog();

            if (ofd.ShowDialog()== DialogResult.OK)
            {
                pcbImagem.ImageLocation = ofd.FileName;
                pcbImagem.Load();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparComponentes();

            if(pcbImagem.Image != null)
            {
                pcbImagem.Image = null;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
