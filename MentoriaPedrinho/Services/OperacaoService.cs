using MentoriaPedrinho.Repository;
using MentoriaPedrinho.Services.Interfaces;

namespace MentoriaPedrinho.Services
{
    internal class OperacaoService : IOperacaoService
    {
        public string Sacar(double valor)
        {
            string teste = BancoRepository.Sacar(valor).ToString();
            return teste;
        }

        public void Depositar(double valorDodoposito)
        {
            BancoRepository.Depositar(valorDodoposito);
        }

        public double? GetSaldo()
        {
            var saldo = BancoRepository.Saldo;
            return saldo;

        }

        //string IOperacaoService.Sacar(double valor)
        //{
        //    string teste = BancoRepository.Sacar(valor).ToString();
        //    return teste;
        //}

        //void IOperacaoService.Depositar(double valor)
        //{
        //    BancoRepository.Depositar(valor);
        //}

        //double? IOperacaoService.GetSaldo()
        //{
        //    var saldo = BancoRepository.Saldo;
        //    return saldo;
        //}
    }
}
