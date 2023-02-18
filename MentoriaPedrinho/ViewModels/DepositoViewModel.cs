using MentoriaPedrinho.Helpers;
using MentoriaPedrinho.Services;
using System.Windows;


namespace MentoriaPedrinho.ViewModels
{
    class DepositoViewModel : BaseViewModel
    {
        private readonly OperacaoService _operacaoService;

        public DepositoViewModel()
        {
            _operacaoService = new OperacaoService();

            LabelInicial = CarregaDadosNaTela("Depósito");
        }

        public void Depositar()
        {
            _operacaoService.Depositar(ValorDaOperacao.ToDouble());
            MessageBox.Show($"Depósito de R$ {ValorDaOperacao} efetuado com sucesso!");
        }
    }
}
