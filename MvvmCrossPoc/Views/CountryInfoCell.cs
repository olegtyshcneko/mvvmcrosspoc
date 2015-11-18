
using System;

using Foundation;
using UIKit;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using MvvmCrossPoc.Core.Remote.DTO;

namespace MvvmCrossPoc.Views
{
    public partial class CountryInfoCell : MvxTableViewCell
    {
        public static readonly UINib Nib = UINib.FromName("CountryInfoCell", NSBundle.MainBundle);
        public static readonly NSString Key = new NSString("CountryInfoCell");

        public CountryInfoCell(IntPtr handle)
            : base(handle)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.DelayBind(() =>
                {
                    var set = this.CreateBindingSet<CountryInfoCell, CountryDataDTO>();
                    set.Bind(CountryLabel).To(cd => cd.Name).OneTime();
                    set.Bind(RegionLabel).To(cd => cd.Region.Value).OneTime();
                    set.Bind(IncomeLabel).To(cd => cd.IncomeLevel.Value).OneTime();
                    set.Apply();
                });
        }

        public static CountryInfoCell Create()
        {
            return (CountryInfoCell)Nib.Instantiate(null, null)[0];
        }
    }
}

