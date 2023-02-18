using MentoriaPedrinho.Helpers;
using MentoriaPedrinho.Services;
using System.Windows;

namespace MentoriaPedrinho.ViewModels
{
    internal class SaqueViewModel : BaseViewModel
    {
        private readonly OperacaoService _operacaoService;

        public SaqueViewModel()
        {
            _operacaoService = new OperacaoService();

            LabelInicial = CarregaDadosNaTela("Saque");
        }

        public void Sacar()
        {
            var saldo = _operacaoService.GetSaldo();

            if (saldo < ParseHelper.ToDouble(ValorDaOperacao))
            {
                MessageBox.Show("Saldo insuficiente!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }

            _operacaoService.Sacar(ParseHelper.ToDouble(ValorDaOperacao));

            MessageBox.Show($"Saque de R$ {ValorDaOperacao},00 efetuado com sucesso!", "Operação realizada");

            _operacaoService.GetSaldo();
        }
    }
}
