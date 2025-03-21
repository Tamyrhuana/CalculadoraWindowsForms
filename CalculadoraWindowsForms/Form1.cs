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

            if (txtOperacao.Text[txtOperacao.Text.Length-1] == '-'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '*'
                || txtOperacao.Text[txtOperacao.Text.Length - 1] == '/') {
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }
            if (txtOperacao.Text[txtOperacao.Text.Length - 1] == '+')
                return;
            txtOperacao.Text += "+";
        }
    }
}
