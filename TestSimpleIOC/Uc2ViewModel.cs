using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSimpleIOC
{
    public class UC2ViewModel : ViewModelBase
    {
        private string _stringa; public string Stringa { get => _stringa; set { Set(() => Stringa, ref _stringa, value); }}


        private RelayCommand _sendStringaCmd;
        public RelayCommand SendStringaCmd => _sendStringaCmd ?? (_sendStringaCmd = new RelayCommand(
            () => sendStringa(),
            () => { return 1 == 1; },
			keepTargetAlive:true
            ));

        public UC2ViewModel()
        {

        }

        private void sendStringa()
        {
            throw new NotImplementedException();
        }
    }
}
