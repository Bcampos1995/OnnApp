using Microsoft.Maui.Controls;
using OnnApp.Services;

namespace OnnApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Carregar os usu�rios do arquivo JSON
            List<User> users = await UserDataService.LoadUsersAsync();

            // Verificar se o usu�rio existe e a senha est� correta
            var authenticatedUser = users.FirstOrDefault(u => u.Email == username && u.Password == password);

            if (authenticatedUser != null)
            {
                // Se a autentica��o for bem-sucedida
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Erro", "Credenciais inv�lidas, tente novamente.", "OK");
            }
        }

        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            // Navegue para a p�gina de redefini��o de senha ou exiba um alerta
            await DisplayAlert("Esqueceu sua senha", "P�gina de recupera��o de senha n�o implementada.", "OK");
        }
    }
}
