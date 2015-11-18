using Cirrious.MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;

namespace MvvmCrossPoc.Core.ViewModels
{
    public class CountryInfoParameters
    {
        public string Hello { get; set; }
    }

    public class FirstViewModel 
		: MvxViewModel
    {
        private readonly IMvxViewModelLoader _viewModelLoader;
        private string _hello = "Hello MvvmCross";
        private string _hello2 = "Default val.";
        private int _helloCount;

        private ICommand _okCommand;

        public FirstViewModel(IMvxViewModelLoader viewModelLoader)
        {
            _viewModelLoader = viewModelLoader;

            _okCommand = new MvxCommand
                (() => ShowViewModel<CountryInfoViewModel>(new CountryInfoParameters { Hello = Hello }));
        }

        public string Hello
        { 
            get { return _hello; }
            set
            { 
                _hello = value;
                RaisePropertyChanged(nameof(Hello)); 
            }
        }

        public int HelloCount 
        {
            get { return _helloCount; }
            set
            {
                _helloCount = value;
                RaisePropertyChanged(nameof(HelloCount));
            }
        }

        public ICommand OkCommand => _okCommand;

        public bool IsServiceActive
        {
            get { return false; }
        }

        public string Hello2 
        {
            get { return _hello2; }
            set
            {
                _hello2 = value;
                RaisePropertyChanged(nameof(Hello2));
            }
        }
    }
}
