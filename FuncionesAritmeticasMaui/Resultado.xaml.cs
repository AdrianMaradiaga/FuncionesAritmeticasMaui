namespace FuncionesAritmeticasMaui;

public partial class Resultado : ContentPage
{
	public Resultado(double resultado)
	{
		InitializeComponent();
        ResultadoLabel.Text = $"Resultado: {resultado}";

    }
}