using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        decimal valor1;
        decimal valor2;
        decimal resultado;
        string operador;

        public Form1()
        {
            InitializeComponent();
            valor1 = 0m;
            valor2 = 0m;
            resultado = 0m;
            operador= string.Empty;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDisplay.Text)) 
            {
                MessageBox.Show("ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 
            
            }

            valor1 = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operador = "+";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                MessageBox.Show("ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; //para evitar q reviente el codigo

            }

            valor1 = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operador = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                MessageBox.Show("ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 

            }

            valor1 = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operador = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                MessageBox.Show("ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 

            }

            valor1 = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operador = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                MessageBox.Show("ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; //para evitar q reviente el codigo

            }

            valor2 = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            //aqui tengo q operar
            switch(operador) 
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 == 0) 
                    {
                        MessageBox.Show("no se puede dividir por 0");
                        return; //hace que la linea que sigue no se ejecute. como un break: hace saltar el codigo.
                    }
                    resultado = valor1 / valor2;
                    break;       
            
            }

            txtDisplay.Text = resultado.ToString("N2"); //mostrar resultado






        }

        private void btnBorrarC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnBorrarNum_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = " ";
        }
    }
}
