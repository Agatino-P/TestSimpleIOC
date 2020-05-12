using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSimpleIOC
{
    public class UC1ViewModel : ViewModelBase
    {
        private int _numero; public int Numero { get => _numero; set { Set(() => Numero, ref _numero, value); }}

        private RelayCommand _sendNumeroCmd;
        public RelayCommand SendNumeroCmd => _sendNumeroCmd ?? (_sendNumeroCmd = new RelayCommand(
            () => sendNumero(),
            () => { return 1 == 1; },
			keepTargetAlive:true
            ));

        public UC1ViewModel()
        {

        }

        private void sendNumero()
        {
            throw new NotImplementedException();
        }
    }
}
