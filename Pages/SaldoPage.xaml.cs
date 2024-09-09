using Microsoft.Maui.Controls;

namespace OnnApp.Pages
{
    public partial class SaldoPage : ContentPage
    {
        public SaldoPage()
        {
            InitializeComponent();
        }

        private async void OnResgatarSaldoClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Resgatar Saldo", "Informe o valor a resgatar:");
            if (!string.IsNullOrEmpty(result))
            {
                await DisplayAlert("Dados Bancários", "Dados Bancários do Cliente:\nBanco: XYZ\nAgência: 1234\nConta: 56789-0", "Confirmar Resgate");
            }
        }
    }
}
