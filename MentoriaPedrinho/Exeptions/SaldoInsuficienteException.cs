using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaPedrinho.Exeptions
{
    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public string Saldo { get; }

        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string message)
            : base(message) { }

        public SaldoInsuficienteException(string message, Exception inner)
            : base(message, inner) { }

        public SaldoInsuficienteException(string message, string saldo)
            : this(message)
        {
            Saldo = saldo;
        }
    }
}




