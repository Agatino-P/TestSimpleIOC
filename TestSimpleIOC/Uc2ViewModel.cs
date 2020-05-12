using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
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
            Messenger.Default.Register<int>(this, receivedInt);
            Messenger.Default.Register<DoubleMeMessage>(this, receivedDOubleMeMessage);
        }

        private void receivedDOubleMeMessage(DoubleMeMessage dmm)
        {
            dmm.Feedabck(dmm.DoubleMe * 2);
        }

        private void receivedInt(int _int)
        {
            Stringa = _int.ToString();
        }

        private void sendStringa()
        {
            Messenger.Default.Send<string>(Stringa);
        }
    }
}
