using MentoriaPedrinho.ViewModels;
using System.Windows;

namespace MentoriaPedrinho
{
    public partial class TelaDeSaque : Window
    {
        private SaqueViewModel _viewModel { get; set; }


        private BancoViewModel _bancoViewModel { get; set; } = new();

        public TelaDeSaque()
        {
            _viewModel = new();
            DataContext = _viewModel;
            InitializeComponent();
        }


        private void Sacar_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show($"Tem certeza que deseja sacar R$ {_viewModel.ValorDaOperacao}?",
                    "Atenção",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _viewModel.Sacar();
                _bancoViewModel.AbreTela(new MainWindow());                 

            }
        }


        private void Cancelar_OnClick(object sender, RoutedEventArgs e)
        {
            _bancoViewModel.AbreTela(new MainWindow());

        }

    }
}
