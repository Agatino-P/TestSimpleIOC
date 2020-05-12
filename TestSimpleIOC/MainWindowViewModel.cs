using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using TestSimpleIOC.Services;

namespace TestSimpleIOC
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<string> _strings= new ObservableCollection<string> ();
            public ObservableCollection<string> Strings { get => _strings; set { Set(() => Strings, ref _strings, value); }}


        public MainWindowViewModel()
        {
            SimpleIoc.Default.Register < IDataService, DataService >();
            
        }

        private RelayCommand _fromDataServiceCmd;
        public RelayCommand FromDataServiceCmd => _fromDataServiceCmd ?? (_fromDataServiceCmd = new RelayCommand(
            () => fromDataService(),
            () => true,
            keepTargetAlive: true
            ));

        private void fromDataService()
        {
            IDataService ds = SimpleIoc.Default.GetInstance<IDataService>();
            Strings = new ObservableCollection<string>(ds.GetStrings());
            
        }
    }
}
