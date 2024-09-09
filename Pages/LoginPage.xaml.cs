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

            // Carregar os usuários do arquivo JSON
            List<User> users = await UserDataService.LoadUsersAsync();

            // Verificar se o usuário existe e a senha está correta
            var authenticatedUser = users.FirstOrDefault(u => u.Email == username && u.Password == password);

            if (authenticatedUser != null)
            {
                // Se a autenticação for bem-sucedida
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Erro", "Credenciais inválidas, tente novamente.", "OK");
            }
        }

        private async void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            // Navegue para a página de redefinição de senha ou exiba um alerta
            await DisplayAlert("Esqueceu sua senha", "Página de recuperação de senha não implementada.", "OK");
        }
    }
}
