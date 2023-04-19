using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaPedrinho.Exeptions
{
    public class SaldoInsuficienteExeption : Exception
    {
        public string Saldo { get; }

        public SaldoInsuficienteExeption() { }

        public SaldoInsuficienteExeption(string message)
            : base(message) { }

        public SaldoInsuficienteExeption(string message, Exception inner)
            : base(message, inner) { }

        public SaldoInsuficienteExeption(string message, string studentName)
            : this(message)
        {
            Saldo = studentName;
        }
    }
}




