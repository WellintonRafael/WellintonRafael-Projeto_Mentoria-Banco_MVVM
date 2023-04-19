using MentoriaPedrinho.ViewModels;

namespace MentoriaPedrinho.Services.Interfaces
{
    internal interface IOperacaoService
    {
        string Sacar(double valor);

        void Depositar(double valor);

        double? GetSaldo();
    }
}
