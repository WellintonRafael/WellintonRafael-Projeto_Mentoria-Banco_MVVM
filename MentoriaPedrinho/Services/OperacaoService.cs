using MentoriaPedrinho.Repository;

namespace MentoriaPedrinho.Services
{
    internal class OperacaoService
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

        public double GetSaldo()
        {
            var saldo = BancoRepository.GetSaldo();
            return saldo;
        }
    }
}
