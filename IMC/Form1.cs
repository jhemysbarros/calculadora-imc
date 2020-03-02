using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        double peso = 0, altura = 0, total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcular(object sender, EventArgs e)
        {
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);
            total = peso / (altura * altura);

            if(total < 18.5)
            {
                labelResultado.Text = Convert.ToString("IMC: " + Convert.ToDouble(total.ToString("F"))+
                    " - Abaixo do peso.");
            }else if (total >= 18.5 && total <= 24.9)
            {
                labelResultado.Text = Convert.ToString("IMC: " + Convert.ToDouble(total.ToString("F")) +
                    " - Peso normal.");
            }else if (total >= 25 && total <= 29.9)
            {
                labelResultado.Text = Convert.ToString("IMC: " + Convert.ToDouble(total.ToString("F")) +
                    " - Sobrepeso.");
            }else if (total >= 30 && total <= 34.9)
            {
                labelResultado.Text = Convert.ToString("IMC: " + Convert.ToDouble(total.ToString("F")) +
                    " - Obesidade Grau I.");
            }else if (total >= 35 && total <= 39.9)
            {
                labelResultado.Text = Convert.ToString("IMC: " + Convert.ToDouble(total.ToString("F")) +
                    " - Obesidade Grau II.");
            }else
            {
                labelResultado.Text = Convert.ToString("IMC: " + Convert.ToDouble(total.ToString("F")) +
                    " - Obesidade Grau III.");
            }
        }

        private void limpar(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            labelResultado.Text = "";
        }
    }
}