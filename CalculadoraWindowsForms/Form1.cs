namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        private bool somar = false;
        private bool dividir = false;
        private bool multiplicar = false;
        private bool subtrair = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = false;
            multiplicar = false;
            somar = true;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '-'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+')
                return;
            txtOperacao.Text += "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            dividir = false;
            multiplicar = false;
            somar = false;
            subtrair = true;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+'
             || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*'
             || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '-')
                return;
            txtOperacao.Text += "-";
        }

        private void btnMultiplicao_Click(object sender, EventArgs e)
        {
            dividir = false;
            subtrair = false;
            somar = false;
            multiplicar = true;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '-'
             || txtOperacao.Text[txtOperacao.Text.Length - 1] == '+'
             || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '*')
                return;
            txtOperacao.Text += "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            multiplicar = false;
            subtrair = false;
            somar = false;
            dividir = true;

            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '-'
             || txtOperacao.Text[txtOperacao.Text.Length - 1] == '+'
             || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*')
            {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '/')
                return;
            txtOperacao.Text += "/";
        }

        private bool resultadoCalculado = false;

        private void btnIgual_Click(object sender, EventArgs e)


        {
            string expressao = txtOperacao.Text;
            double resultado = 0;

            if (string.IsNullOrWhiteSpace(expressao))
            {
                MessageBox.Show("Por favor, insira uma expressão válida.");
                return;
            }

            char operador = expressao.FirstOrDefault(c => "+-*/".Contains(c));
            if (operador == '\0')
            {
                MessageBox.Show("Erro: Nenhum operador encontrado.");
                return;
            }

            string[] partes = expressao.Split(new char[] { operador });
            if (partes.Length != 2)
            {
                MessageBox.Show("Erro: A expressão deve conter exatamente dois números.");
                return;
            }

            if (double.TryParse(partes[0], out double numero1) && double.TryParse(partes[1], out double numero2))
            {
                if (operador == '+')
                {
                    resultado = numero1 + numero2;
                }
                else if (operador == '-')
                {
                    resultado = numero1 - numero2;
                }
                else if (operador == '*')
                {
                    resultado = numero1 * numero2;
                }
                else if (operador == '/')
                {
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("Erro: Divisão por zero.");
                        return;
                    }
                }

                MessageBox.Show($"Resultado: {resultado}");
            }
            else
            {
                MessageBox.Show("Erro: Entrada inválida.");
            }

            resultadoCalculado = false; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "";
            resultadoCalculado = false;
        }
    }
}
