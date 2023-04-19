using MentoriaPedrinho.Exeptions;
using MentoriaPedrinho.Helpers;
using MentoriaPedrinho.Services;
using System;
using System.Windows;
using System.Windows.Documents;

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

        public void Sacar(string valorDoSaque)
        {
            try
            {
                var saldo = _operacaoService.GetSaldo();

                if (!double.TryParse(valorDoSaque, out double valorDoSaqueParseado))
                    throw new ArgumentOutOfRangeException("Você precisa digitar um valor válido! Sua mula!", valorDoSaque);

                if (valorDoSaque == null)                
                    throw new ArgumentNullException("Digite o valor a ser sacado! Não sabe ler!", valorDoSaque);

                if (saldo < valorDoSaqueParseado)                
                    throw new SaldoInsuficienteExeption("Saldo insuficiente! Seu pobre!", saldo.ToString());
                
                if (MessageBox.Show($"Tem certeza que deseja sacar R$ {ValorDaOperacao}?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) return;

                _operacaoService.Sacar(valorDoSaqueParseado);

                MessageBox.Show($"Saque de R$ {ValorDaOperacao},00 efetuado com sucesso!", "Operação realizada");

                _operacaoService.GetSaldo();

                AbreTela(new MainWindow());
            }

            catch (SaldoInsuficienteExeption ex)
            {
                MessageBox.Show($"{ex.Message} \nSeu saldo é R$ {ex.Saldo}", "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);

                AbreTela(new TelaDeSaque());
            }

            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.ParamName, "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);

                AbreTela(new TelaDeSaque());
            }

            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName, "Atenção", MessageBoxButton.OK, MessageBoxImage.Error);

                AbreTela(new TelaDeSaque());
            }
        }
    }
}
