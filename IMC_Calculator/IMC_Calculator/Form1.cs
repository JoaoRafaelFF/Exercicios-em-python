using System.Globalization;

namespace IMC_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double alt = double.Parse(TbAlt.Text) / 100;
            double peso = double.Parse(TbPeso.Text);

            double Imc = 0.0;
            string classificacao;

            Imc = peso / Math.Pow(alt, 2);

            if (Imc < 17)
            {
                classificacao = "Muito abaixo do peso";
            }
            else if (Imc >= 17 && Imc <= 18.49)
            {
                classificacao = "Abaixo do peso";
            }
            else if (Imc >= 18.50 && Imc <= 24.99)
            {
                classificacao = "Peso normal";
            }
            else if (Imc >= 25 && Imc <= 29.99)
            {
                classificacao = "Acima do peso";
            }
            else if (Imc >= 30 && Imc <= 34.99)
            {
                classificacao = "Obesidade I";
            }
            else if (Imc >= 35 && Imc <= 39.99)
            {
                classificacao = "Obesidade II";
            }
            else
            {
                classificacao = "Obesidade III";
            }



            LblResults.Text = Imc.ToString("F2");
            LblClassfic.Text = classificacao;
            LblNome.Text = TbNome.Text;
            LblEndereco.Text = TbEndereco.Text;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtReiniciar_Click(object sender, EventArgs e)
        {
            TbAlt.Text = string.Empty;
            TbPeso.Text = string.Empty;
            TbNome.Text = string.Empty;
            TbEndereco.Text = string.Empty;
            LblResults.Text = string.Empty;
            LblClassfic.Text = string.Empty;
            LblNome.Text = string.Empty;
            LblEndereco.Text = string.Empty;
        }
    }
}