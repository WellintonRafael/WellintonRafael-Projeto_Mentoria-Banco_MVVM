using MentoriaPedrinho.Services;
using MentoriaPedrinho.ViewModels;
using System.Windows;

namespace MentoriaPedrinho
{
    public partial class TelaDeDeposito : Window
    {
        public TelaDeDeposito()
        {
            _depositoViewModel = new();
            DataContext = _depositoViewModel;
            InitializeComponent();
        }

        private DepositoViewModel _depositoViewModel { get; set; }

        private BancoViewModel _bancoViewModel { get; set; } = new();


        private void Depositar_OnClick(object sender, RoutedEventArgs e)
        {
            _depositoViewModel.Depositar();

            _bancoViewModel.AbreTela(new MainWindow());

        }

        protected void Cancelar_OnClick(object sender, RoutedEventArgs e)
        {
            _bancoViewModel.AbreTela(new MainWindow());

        }
    }
}
