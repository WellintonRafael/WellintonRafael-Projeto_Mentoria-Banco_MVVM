using MentoriaPedrinho.Services;
using MentoriaPedrinho.ViewModels;
using System.Windows;

namespace MentoriaPedrinho
{
    public partial class MainWindow : Window
    {
        private BancoViewModel _bancoViewModel { get; }
        private DepositoViewModel _depositoViewModel { get; } = new();
        private SaqueViewModel _saqueViewModel { get; } = new();

        public MainWindow()
        {
            _bancoViewModel = new();
            DataContext = _bancoViewModel;
            InitializeComponent();

            _bancoViewModel.MostraSaldo();
        }

        private void Sacar_OnClick(object sender, RoutedEventArgs e)
        {
            _saqueViewModel.AbreTela(new TelaDeSaque());
        }

        private void Depositar_OnClick(object sender, RoutedEventArgs e)
        {
            _depositoViewModel.AbreTela(new TelaDeDeposito());
        }

        private void Sair_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo encerrar o sistema?", "Encerrar sessão", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) return;
                this.Close();
        }
    }
}
