using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora1
{
    public partial class frmCalculadora : Form
    {

        double primerNumero;
        double segundoNumero;
        string operador;

        public frmCalculadora()
        {
            InitializeComponent();
            primerNumero = 0;
            segundoNumero = 0;
        }


        //LLAMO A LAS CLASES
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();


        private void leerNumero (string numero) 
        {

            if (txtDisplay.Text == "0" && txtDisplay.Text != null)
            {
                txtDisplay.Text = numero;

            }
            else
            {
                txtDisplay.Text += numero;
            }


        }

        private void btnCero_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text == "0")
            {
                return;
            }
            else
            {
                txtDisplay.Text += "0";
            }

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            leerNumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            leerNumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            leerNumero("7");

        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primerNumero = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primerNumero = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primerNumero = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primerNumero = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundoNumero = double.Parse(txtDisplay.Text);

            double sum;
            double rest;
            double mult;
            double div;

            switch(operador) 
            {
                case "+":
                    sum = obj.Sumar((primerNumero), (segundoNumero));
                    txtDisplay.Text = sum.ToString();
                    break;
                case "-":
                    rest = obj2.Restar((primerNumero), (segundoNumero));
                    txtDisplay.Text = rest.ToString();
                    break;
                case "*":
                    mult = obj3.Multiplicar((primerNumero), (segundoNumero));
                    txtDisplay.Text = mult.ToString();
                    break;
                case "/":
                    div = obj4.Dividir((primerNumero), (segundoNumero));
                    txtDisplay.Text = div.ToString();
                    break;

            }



        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";

            //if (txtDisplay.Text.Length == 1)
            //    txtDisplay.Text = "";
            //else
            //    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            

            if (txtDisplay.Text==".") 
            {
                txtDisplay.Text = null;
                MessageBox.Show("Por favor.Primero ingrese un valor");
                

            }else
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }

        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "-";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
