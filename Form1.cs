using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float peso = float.Parse(txtPeso.Text);
            float altura = float.Parse(txtAltura.Text);
            float imc = peso / (altura * altura);
            double imcA = Math.Round(imc, 2);
           
            if (imc < 18.5)
            {
                MessageBox.Show("IMC: " + imcA + " || Abaixo do Peso");
            } else if (imc < 25)
            {
                MessageBox.Show("IMC: " + imcA + " || Peso Normal");
            } else if (imc < 30)
            {
                MessageBox.Show("IMC: " + imcA + " || Acima do Peso");
            } else
            {
                MessageBox.Show("IMC: " + imcA + " || Obesidade Morbida");
            }
        }
    }
}
