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

        private void btnSomar_Click(object sender, EventArgs e)
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

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (somar)
            {
                List<string> aSomar = txtOperacao.Text.Split("+").ToList();

                double primeiroNumero = Convert.ToDouble(aSomar[0]);
                double segundoNumero = Convert.ToDouble(aSomar[1]);

                double resultado = primeiroNumero + segundoNumero;
                txtOperacao.Text = resultado.ToString();
            }
            else if (subtrair)
            {
                //Escrever o código
            }
            else if (dividir)
            {
                //Escrever o código
            }
            else if (multiplicar)
            {
                //Escrever o código    
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
        }
    }
}
