using Microsoft.Maui.Controls;
using OnnApp.Pages;
using System.Windows.Input;

namespace OnnApp
{
    public partial class AppShell : Shell
    {
        public ICommand NavigateCommand { get; private set; }

        public AppShell()
        {
            InitializeComponent();
            NavigateCommand = new Command<string>(OnNavigateCommand);
            BindingContext = this;

            // Registrar rotas
            Routing.RegisterRoute(nameof(DadosPessoaisPage), typeof(DadosPessoaisPage));
            Routing.RegisterRoute(nameof(CadastroDadosBancariosPage), typeof(CadastroDadosBancariosPage));
        }

        private async void OnUserIconClicked(object sender, EventArgs e)
        {
            // Exibir um menu de ação ou navegar diretamente para uma das páginas
            string action = await Shell.Current.DisplayActionSheet("Opções de Perfil", "Cancelar", null, "Dados Pessoais", "Cadastro Bancário");
            if (action == "Dados Pessoais")
            {
                await Shell.Current.GoToAsync(nameof(DadosPessoaisPage));
            }
            else if (action == "Cadastro Bancário")
            {
                await Shell.Current.GoToAsync(nameof(CadastroDadosBancariosPage));
            }
        }

        private async void OnNavigateCommand(string pageName)
        {
            if (pageName == nameof(DadosPessoaisPage))
            {
                await Shell.Current.GoToAsync("//DadosPessoaisPage");
            }
            else if (pageName == nameof(CadastroDadosBancariosPage))
            {
                await Shell.Current.GoToAsync("//CadastroDadosBancariosPage");
            }
        }
    }
}
