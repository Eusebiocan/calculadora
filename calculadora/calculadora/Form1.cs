using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnpor_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();

        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            switch (operador)
            {

                case "+":
                    resultado = primero + segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = primero * segundo;
                    pantalla.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void btndividir_Click(object sender, EventArgs e)
        {

        }

        private void btnce_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btndividir_Click_1(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }
    }
}
