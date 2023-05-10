namespace Exemplos
{
    public partial class FormInicial : Form
    {
        private string numero1;
        private string numero2;
        private int resultado;

        public FormInicial()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = true;
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBoxNumero1_TextChanged(object sender, EventArgs e)
        {
            numero1 = textBoxNumero1.Text;
        }
        public void textBoxNumero2_TextChanged(object sender, EventArgs e)
        {
            numero2 = textBoxNumero2.Text;
        }

        private void labelNumero2_Click(object sender, EventArgs e)
        {
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBoxNumero1.Text);
            int numero2 = Convert.ToInt32(textBoxNumero2.Text);

            if (textBoxOperacao.Text == "+")
            {
                resultado = numero1 + numero2;
                textBoxResultado.Text = Convert.ToString(resultado);
            }
            else if (textBoxOperacao.Text == "-")
            {
                resultado = numero1 - numero2;
                textBoxResultado.Text = Convert.ToString(resultado);
            }
            else if (textBoxOperacao.Text == "*")
            {
                resultado = numero1 * numero2;
                textBoxResultado.Text = Convert.ToString(resultado);
            }
            else if (textBoxOperacao.Text == "/")
            {
                resultado = numero1 / numero2;
                textBoxResultado.Text = Convert.ToString(resultado);
            }
        }

        private void buttonMais_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOperacao.Text = "+";
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            textBoxOperacao.Text = "-";
        }

        private void buttonMultiplicar_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOperacao.Text = "*";
        }

        private void buttondivisao_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOperacao.Text = "/";
        }

        private void buttonLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOperacao.Text = "";
            textBoxNumero1.Text = " ";
            textBoxNumero2.Text = " ";
            textBoxResultado.Text = "";
        }
    }
}