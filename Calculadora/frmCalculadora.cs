using System.Globalization;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtVisor.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtVisor.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtVisor.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtVisor.Text = Convert.ToString(valor1 / valor2);
            }
            lblOperacao.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVisor.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ",";
        }
    }
}