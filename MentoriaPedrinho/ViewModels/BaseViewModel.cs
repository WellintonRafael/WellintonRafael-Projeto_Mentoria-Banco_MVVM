﻿using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MentoriaPedrinho.ViewModels
{
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected string CarregaDadosNaTela(string titulo)
        {
            var tituloTeste = $"Seja bem vindo à tela de {titulo}";

            return tituloTeste;
        }

        private string _labelInicial { get; set; }
        public string LabelInicial
        {
            get => _labelInicial;
            set
            {
                _labelInicial = value;
                OnPropertyChanged();
            }
        }


        private string _valorDaOperacao { get; set; }
        public string ValorDaOperacao
        {
            get => _valorDaOperacao;
            set
            {
                _valorDaOperacao = value;
                OnPropertyChanged();
            }
        }


        private string _txtExibeSaldo { get; set; }
        public string TxtExibeSaldo
        {
            get => _txtExibeSaldo;
            set
            {
                _txtExibeSaldo = value;
                OnPropertyChanged();
            }
        }



        public virtual void AbreTela(Window tela)
        {
            var window = Application.Current.Windows.OfType<Window>().SingleOrDefault(w => w.IsActive);
            window.Close();

            tela.Show();

        }
    }
}
