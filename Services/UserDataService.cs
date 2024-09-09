using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OnnApp.Services
{
    public static class UserDataService
    {
        // O caminho do arquivo JSON
        private static readonly string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "users.json");

        public static async Task<List<User>> LoadUsersAsync()
        {
            // Verifica se o arquivo existe
            if (!File.Exists(FilePath))
            {
                var defaultUsers = new List<User>
                {
                    new User { Email = "teste@teste.com", Password = "123456", Name = "Teste 1", CPF = "12345678901", Balance = 1000 },
                    new User { Email = "teste2@teste.com", Password = "123456", Name = "Teste 2", CPF = "10987654321", Balance = 2000 }
                };

                var json = JsonConvert.SerializeObject(defaultUsers);
                await File.WriteAllTextAsync(FilePath, json);
            }

            // Lê o conteúdo do arquivo
            using (var reader = new StreamReader(FilePath))
            {
                string json = await reader.ReadToEndAsync();

                // Deserializa o JSON em uma lista de usuários
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}
