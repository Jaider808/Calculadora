using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculo : ContentPage
    {
        char operador;
        double operacion;
        double primer_numero;
        double segundo_numero;
        public Calculo()
        {
            InitializeComponent();
        }
        private void btn_1_Clicked(object sender, EventArgs e)
        {
            string uno = "1";
            barra.Text = barra.Text + uno;
        }
        private void btn_2_Clicked(object sender, EventArgs e)
        {
            string dos = "2";
            barra.Text = barra.Text + dos;
        }
        private void btn_3_Clicked(object sender, EventArgs e)
        {
            string tres = "3";
            barra.Text = barra.Text + tres;
        }
        private void btn_4_Clicked(object sender, EventArgs e)
        {
            string cuatro = "4";
            barra.Text = barra.Text + cuatro;
        }
        private void btn_5_Clicked(object sender, EventArgs e)
        {
            string cinco = "5";
            barra.Text = barra.Text + cinco;
        }
        private void btn_6_Clicked(object sender, EventArgs e)
        {
            string seis = "6";
            barra.Text = barra.Text + seis;
        }
        private void btn_7_Clicked(object sender, EventArgs e)
        {
            string siete = "7";
            barra.Text = barra.Text + siete;
        }
        private void btn_8_Clicked(object sender, EventArgs e)
        {
            string ocho = "8";
            barra.Text = barra.Text + ocho;
        }
        private void btn_9_Clicked(object sender, EventArgs e)
        {
            string nueve = "9";
            barra.Text = barra.Text + nueve;
        }
        private void btn_0_Clicked(object sender, EventArgs e)
        {
            string cero = "0";
            barra.Text = barra.Text + cero;
        }
        private void btn_suma_Clicked(object sender, EventArgs e)
        {
            operador = '+';
            primer_numero = Convert.ToDouble(barra.Text);
            barra.Text = "";
        }
        private void btn_resta_Clicked(object sender, EventArgs e)
        {
            operador = '-';
            primer_numero = Convert.ToDouble(barra.Text);
            barra.Text = "";
        }
        private void btn_multiplicar_Clicked(object sender, EventArgs e)
        {
            operador = '*';
            primer_numero = Convert.ToDouble(barra.Text);
            barra.Text = "";
        }
        private void btn_dividir_Clicked(object sender, EventArgs e)
        {
            operador = '/';
            primer_numero = Convert.ToDouble(barra.Text);
            barra.Text = "";
        }
        private void Btn_punto_Clicked(object sender, EventArgs e)
        {
            
            barra.Text = barra.Text + ".";
        }
        private void btn_igual_Clicked(object sender, EventArgs e)
        {
            segundo_numero = Convert.ToDouble(barra.Text);
            switch (operador)
            {
                case '+':
                    operacion = primer_numero + segundo_numero;
                    resulatado.Text = Convert.ToString(operacion);
                    barra.Text = "";
                    break;
                case '-':
                    operacion = primer_numero - segundo_numero;
                    resulatado.Text = Convert.ToString(operacion);
                    barra.Text = "";
                    break;
                case '*':
                    operacion = primer_numero * segundo_numero;
                    resulatado.Text = Convert.ToString(operacion);
                    barra.Text = "";
                    break;
                case '/':
                    operacion = primer_numero / segundo_numero;
                    resulatado.Text = Convert.ToString(operacion);
                    barra.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}