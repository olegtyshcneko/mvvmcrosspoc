using System;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossPoc.Core.Remote;
using System.Diagnostics;
using System.Collections.Generic;
using MvvmCrossPoc.Core.Remote.DTO;
using System.Windows.Input;
using System.Threading.Tasks;

namespace MvvmCrossPoc.Core.ViewModels
{
    public class CountryInfoViewModel : MvxViewModel
    {
        private readonly ICountryDataService countryDataService;

        private List<CountryDataDTO> countryData = new List<CountryDataDTO>();

        private ICommand pullDataCommand;

        public CountryInfoViewModel(ICountryDataService countryDataService)
        {
            this.countryDataService = countryDataService;            
            this.pullDataCommand = new MvxCommand(async () => await DoPullDataCommand());
        }

        public void Init(CountryInfoParameters parameters)
        {
            Debug.WriteLine(parameters.Hello);            
        }

        public List<CountryDataDTO> CountryData 
        {
            get { return countryData; }
            set
            {
                countryData = value;
                RaisePropertyChanged(nameof(CountryData));
            }
        }

        public ICommand PullDataCommand => pullDataCommand;

        public ICommand CountrySelectionCommand => new MvxCommand<CountryDataDTO>(DoCountrySelectionCommand);

        private async Task DoPullDataCommand()
        {
            var countries = await countryDataService.GetAllCountriesDataAsync();
            CountryData = countries;
        }

        private void DoCountrySelectionCommand(CountryDataDTO cData)
        {
            Debug.WriteLine(cData);
        }
    }
}