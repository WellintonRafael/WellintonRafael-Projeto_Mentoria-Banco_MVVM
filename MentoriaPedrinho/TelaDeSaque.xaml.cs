using MentoriaPedrinho.ViewModels;
using System.Windows;

namespace MentoriaPedrinho
{
    public partial class TelaDeSaque : Window
    {
        private SaqueViewModel _saqueViewModel { get; set; }
        public TelaDeSaque()
        {
            _saqueViewModel = new();
            DataContext = _saqueViewModel;
            InitializeComponent();
        }

        private void Sacar_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que deseja sacar R$ {_saqueViewModel.ValorDaOperacao}?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) return;

            _saqueViewModel.Sacar();

            _saqueViewModel.AbreTela(new MainWindow());
        }

        private void Cancelar_OnClick(object sender, RoutedEventArgs e)
        {
            _saqueViewModel.AbreTela(new MainWindow());
        }
    }
}
