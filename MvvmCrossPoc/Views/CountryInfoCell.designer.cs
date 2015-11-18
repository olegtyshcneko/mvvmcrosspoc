// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCrossPoc.Views
{
	[Register ("CountryInfoCell")]
	partial class CountryInfoCell
	{
		[Outlet]
		UIKit.UILabel CountryLabel { get; set; }

		[Outlet]
		UIKit.UILabel IncomeLabel { get; set; }

		[Outlet]
		UIKit.UILabel RegionLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CountryLabel != null) {
				CountryLabel.Dispose ();
				CountryLabel = null;
			}

			if (RegionLabel != null) {
				RegionLabel.Dispose ();
				RegionLabel = null;
			}

			if (IncomeLabel != null) {
				IncomeLabel.Dispose ();
				IncomeLabel = null;
			}
		}
	}
}
