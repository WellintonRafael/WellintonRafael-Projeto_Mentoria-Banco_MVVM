using MentoriaPedrinho.Services;
using System.Windows;

namespace MentoriaPedrinho.ViewModels
{
    internal class BancoViewModel : BaseViewModel
    {
        private readonly OperacaoService _operacaoService;

        private MainWindow _mainWindow { get; set; }


        public BancoViewModel()
        {
            _operacaoService = new OperacaoService();

            TxtExibeSaldo = _operacaoService.GetSaldo().ToString();
        }




        public string MostraSaldo()
        {
            TxtExibeSaldo = _operacaoService.GetSaldo().ToString();
            return TxtExibeSaldo;
        }
    }
}
