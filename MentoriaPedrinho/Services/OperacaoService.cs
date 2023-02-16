using MentoriaPedrinho.Repository;

namespace MentoriaPedrinho.Services
{
    internal class OperacaoService
    {
        public string SacarService(double valor)
        {
            string teste = BancoRepository.SacarRepository(valor).ToString();
            return teste;
        }

        public void DepositarService(double valorDodoposito)
        {
            BancoRepository.DepositarRepository(valorDodoposito);
        }

        public double GetSaldoService()
        {
            var saldo = BancoRepository.GetSaldoRepository();
            return saldo;
        }
    }
}
