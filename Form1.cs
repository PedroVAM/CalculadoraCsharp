using System.Globalization;

namespace Calculadora_Simples
{
  
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Operação_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Resultado.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                Resultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                Resultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "VEZES")
            {
                Resultado.Text = Convert.ToString(valor1 * valor2);
            }
            else 
            {
                Resultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "SUB";
                lbloperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de fazer a subtração");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "VEZES";
                lbloperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de fazer a multiplicação");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "DIV";
                lbloperacao.Text = "÷";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de fazer a divisão");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbloperacao.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Resultado.Text != "")
            {
                valor1 = decimal.Parse(Resultado.Text, CultureInfo.InvariantCulture);
                Resultado.Text = "";
                operacao = "SOMA";
                lbloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor antes de fazer a soma");
            }
        }
    }
}