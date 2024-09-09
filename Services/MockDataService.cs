using OnnApp.Pages;

namespace OnnApp.Services
{
    public static class MockDataService
    {
        public static decimal GetSaldo()
        {
            return 1000.00m; // Saldo mockado
        }

        public static List<ExtratoItem> GetExtrato()
        {
            return new List<ExtratoItem>
            {
                new ExtratoItem { Descricao = "Depósito", Valor = "R$ 500,00" },
                new ExtratoItem { Descricao = "Resgate", Valor = "R$ 200,00" }
            };
        }
    }
}
