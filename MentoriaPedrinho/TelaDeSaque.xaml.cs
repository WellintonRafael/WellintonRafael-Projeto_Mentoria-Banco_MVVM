using MentoriaPedrinho.ViewModels;
using System.Windows;

namespace MentoriaPedrinho
{
    public partial class TelaDeSaque : Window
    {
        private SaqueViewModel _saqueViewModel { get; }
        public TelaDeSaque()
        {
            _saqueViewModel = new();
            DataContext = _saqueViewModel;
            InitializeComponent();
        }

        private void Sacar_OnClick(object sender, RoutedEventArgs e)
        {            
            _saqueViewModel.Sacar(_saqueViewModel.ValorDaOperacao);
        }

        private void Cancelar_OnClick(object sender, RoutedEventArgs e)
        {
            _saqueViewModel.AbreTela(new MainWindow());
        }
    }
}
