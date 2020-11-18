using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalc
{
    public partial class Form1 : Form
    {
        //Var Globales
        double valor1, valor2;
        string operacion = "";
        
        

        public Form1()
        {
            InitializeComponent();
        }

        //private void btn0_Click(object sender, EventArgs e)
        //{
        //    lblNumeros.Text += "0";
        //}

        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    lblNumeros.Text += "1";
        //}
        private void MiMetodo_Click(object sender, EventArgs e)
        {
            double resultado;
            string textoBoton = ((Button)sender).Text;
          
            switch (textoBoton)
            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Log":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Log(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Cos(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Sin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sin(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Tan(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Cosh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Cosh(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Exp":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Exp(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "L10":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Log10(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Sinh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sinh(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Tanh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Tanh(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Abs":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Abs(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Clg":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Ceiling(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Flr":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Floor(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Atan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Atan(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Asin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Asin(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Trun":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Truncate(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "X":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "=":
                    if (lblNumeros.Text=="")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                     case "+":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 + valor2) + "";
                     break;
                     case "-":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 - valor2) + "";
                     break;
                     case "X":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 * valor2) + "";
                     break;
                     case "/":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 / valor2) + "";
                     break;

                    }
                    break;
                case "AC":
                    lblNumeros.Text = "";
                    break;
                case ".":
                    if (lblNumeros.Text.IndexOf(".") == -1)
                    {
                     lblNumeros.Text += textoBoton;
                    }
    
                    break;
                default:
                    lblNumeros.Text += textoBoton;
                    break;

            }

            

            
        }

    }
}
