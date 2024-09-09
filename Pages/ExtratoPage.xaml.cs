using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace OnnApp.Pages
{
    public partial class ExtratoPage : ContentPage
    {
        public ObservableCollection<ExtratoItem> ExtratoItems { get; set; }

        public ExtratoPage()
        {
            InitializeComponent();

            ExtratoItems = new ObservableCollection<ExtratoItem>
            {
                new ExtratoItem { Descricao = "Depósito", Valor = "R$ 500,00" },
                new ExtratoItem { Descricao = "Resgate", Valor = "R$ 200,00" }
            };

            ExtratoListView.ItemsSource = ExtratoItems;
        }
    }

    public class ExtratoItem
    {
        public string Descricao { get; set; }
        public string Valor { get; set; }
    }
}
