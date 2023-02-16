using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaPedrinho.Repository
{
    public static class BancoRepository
    {
        private static double _saldo { get; set; }

        public static double SacarRepository(double valor)
        {
            _saldo -= valor;
            return _saldo;
        }

        public static void DepositarRepository(double valorDoDeposito)
        {
            _saldo += valorDoDeposito;
        }

        public static double GetSaldoRepository()
        {
            return _saldo;
        }
        
        public static void SetSaldo(double valor)
        {
            _saldo = valor;
        }
    }
}