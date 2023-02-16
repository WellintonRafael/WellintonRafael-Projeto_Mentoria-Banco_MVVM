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
            var saldo = _operacaoService.GetSaldoService();

            if (saldo < ParseHelper.ToDouble(ValorDaOperacao))
            {
                MessageBox.Show("Saldo insuficiente!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                _operacaoService.SacarService(ParseHelper.ToDouble(ValorDaOperacao));

                MessageBox.Show($"Saque de R$ {ValorDaOperacao},00 efetuado com sucesso!", "Operação realizada");

                _operacaoService.GetSaldoService();
            }
        }
    }
}
