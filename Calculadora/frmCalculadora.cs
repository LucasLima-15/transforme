using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDivisao.Checked = false;
        }
        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        

            // Declarando as variaveis
            double num1, num2, resp;
            resp = 0;

            // Inicializar as variaveis
            try
            {
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                txtNumero1.Clear();
                txtNumero2.Clear();
                txtNumero1.Focus();

                if (rdbSomar.Checked == false && rdbSubtrair.Checked == false && rdbMultiplicar.Checked == false && rdbDivisao.Checked == false)
                {
                    MessageBox.Show("Selecione um operador",
                    "Messagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {

                    //Criando a estrutura de decição
                    if (rdbSomar.Checked)
                    {
                        // resposta
                        resp = num1 + num2;
                    }

                    else if (rdbSubtrair.Checked)
                    {
                        resp = num1 - num2;
                    }

                    else if (rdbMultiplicar.Checked)
                    {
                        resp = num1 * num2;
                    }
                    else if (rdbDivisao.Checked)
                    {
                        if (num2 != 0)
                        {
                            resp = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Calculo inválido",
                                "Messagem do Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                            txtResultado.Clear();
                        }

                    }

                    txtResultado.Text = resp.ToString();
                }
            }catch (Exception)
            {
                MessageBox.Show("Favor, utilizar apenas valores válidos!!",
                    "Messagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }   

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
