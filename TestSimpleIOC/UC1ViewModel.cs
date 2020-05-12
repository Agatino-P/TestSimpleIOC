using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Animation;

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
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<string>(this, receivedString);
        }

        private void receivedString(string _string)
        {
            try
            {
                Numero = int.Parse(_string);
            }
            catch (Exception ex)
            {
                Numero = -999;
                
            }
            
        }

        private void sendNumero()
        {
            Messenger.Default.Send<int>(Numero);
        }
    }
}
