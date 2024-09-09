using Microsoft.Maui.Controls;

namespace OnnApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Pages.LoginPage());
        }

        private void OnLabelTapped(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                if (label.Text == "Dados Pessoais")
                {
                    (MainPage as NavigationPage)?.Navigation.PushAsync(new Pages.DadosPessoaisPage());
                }
                else if (label.Text == "Cadastro Bancário")
                {
                    (MainPage as NavigationPage)?.Navigation.PushAsync(new Pages.CadastroDadosBancariosPage());
                }
            }
        }
    }
}
