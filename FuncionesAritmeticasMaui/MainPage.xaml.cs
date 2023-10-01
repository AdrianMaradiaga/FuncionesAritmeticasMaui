using System;
using Microsoft.Maui.Controls;

namespace FuncionesAritmeticasMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSumarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Number1Entry.Text, out double numero1) && double.TryParse(Number2Entry.Text, out double numero2))
            {
                double resultado = FuncionesAritmeticas.Sumar(numero1, numero2);

                Resultado resultadoPage = new Resultado(resultado);
                Navigation.PushAsync(resultadoPage);
            }
            else
            {
                ResultLabel.Text = "Ingrese números válidos";
            }
        }


        private void OnRestarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Number1Entry.Text, out double numero1) && double.TryParse(Number2Entry.Text, out double numero2))
            {
                double resultado = FuncionesAritmeticas.Restar(numero1, numero2);

                Resultado resultadoPage = new Resultado(resultado);
                Navigation.PushAsync(resultadoPage);
            }
            else
            {
                ResultLabel.Text = "Ingrese números válidos";
            }
        }

        private void OnMultiplicarClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Number1Entry.Text, out double numero1) && double.TryParse(Number2Entry.Text, out double numero2))
            {
                double resultado = FuncionesAritmeticas.Multiplicar(numero1, numero2);

                Resultado resultadoPage = new Resultado(resultado);
                Navigation.PushAsync(resultadoPage);
            }
            else
            {
                ResultLabel.Text = "Ingrese números válidos";
            }
        }

        private void OnDividirClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Number1Entry.Text, out double numero1) && double.TryParse(Number2Entry.Text, out double numero2))
            {
                try
                {
                    double resultado = FuncionesAritmeticas.Dividir(numero1, numero2);

                    Resultado resultadoPage = new Resultado(resultado);
                    Navigation.PushAsync(resultadoPage);
                }
                catch (DivideByZeroException ex)
                {
                    ResultLabel.Text = ex.Message;
                }
            }
            else
            {
                ResultLabel.Text = "Ingrese números válidos";
            }
        }


        private void OnClearClicked(object sender, EventArgs e)
        {
            Number1Entry.Text = string.Empty;
            Number2Entry.Text = string.Empty;
            ResultLabel.Text = string.Empty;
        }
    }
}
