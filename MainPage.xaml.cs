using Microsoft.Maui.Controls;
using OnnApp.Pages;

namespace OnnApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnResgatarSaldoClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Resgatar Saldo", "Informe o valor que deseja resgatar:");
            if (!string.IsNullOrWhiteSpace(result))
            {
                // Exibir dados bancários do cliente e botão confirmar resgate
                await DisplayAlert("Dados Bancários", "Aqui estão os dados bancários do cliente.", "Confirmar Resgate");
            }
        }

        private async void OnDadosPessoaisTapped(object sender, EventArgs e)
        {
            // Navegar para a página de Dados Pessoais
            await Navigation.PushAsync(new DadosPessoaisPage());
        }

        private async void OnCadastroBancarioTapped(object sender, EventArgs e)
        {
            // Navegar para a página de Cadastro Bancário
            await Navigation.PushAsync(new CadastroDadosBancariosPage());
        }
    }
}
