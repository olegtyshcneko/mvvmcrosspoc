
using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmCrossPoc.Core.ViewModels;
using Cirrious.MvvmCross.Binding.Touch.Views;

namespace MvvmCrossPoc.Views
{
    public partial class CountryInfoView : MvxViewController
    {
        public CountryInfoView()
            : base("CountryInfoView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            InitBindings();
            InitTableBindings();
        }

        private void InitBindings()
        {
            var set = this.CreateBindingSet<CountryInfoView, CountryInfoViewModel>();
            set.Bind(PullDataButton).To(vm => vm.PullDataCommand);
            set.Apply();
        }

        private void InitTableBindings()
        {

            var tableSource = 
                new MvxSimpleTableViewSource(CountryDataTableView, CountryInfoCell.Key, CountryInfoCell.Key);

            CountryDataTableView
                .RegisterNibForCellReuse(CountryInfoCell.Nib, CountryInfoCell.Key);

            CountryDataTableView.Source = tableSource;
            CountryDataTableView.RowHeight = 110f;

            var set = this.CreateBindingSet<CountryInfoView, CountryInfoViewModel>();
            set.Bind(tableSource).For(t => t.ItemsSource).To(vm => vm.CountryData);
            set.Bind(tableSource).For(t => t.SelectionChangedCommand)
                .To(vm => vm.CountrySelectionCommand);
            set.Apply();
        }
    }
}

