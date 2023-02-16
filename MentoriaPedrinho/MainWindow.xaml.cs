using MentoriaPedrinho.Services;
using MentoriaPedrinho.ViewModels;
using System.Windows;

namespace MentoriaPedrinho
{
    public partial class MainWindow : Window
    {
        private OperacaoService _operacaoService { get; set; }
        private BancoViewModel _bancoViewModel { get; set; }
        private DepositoViewModel _depositoViewModel { get; set; } = new();
        private SaqueViewModel _saqueViewModel { get; set; } = new();



        public MainWindow()
        {
            _bancoViewModel = new();
            DataContext = _bancoViewModel;
            InitializeComponent();

            _operacaoService = new();

            _bancoViewModel.MostraSaldo();
        }

        private void Sacar_OnClick(object sender, RoutedEventArgs e)
        {
            _saqueViewModel.AbreTela(new TelaDeSaque());
            this.Close();
        }


        private void Depositar_OnClick(object sender, RoutedEventArgs e)
        {
            _depositoViewModel.AbreTela(new TelaDeDeposito());

        }

        private void Sair_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo encerrar o sistema?",
                    "Encerrar sessão",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
