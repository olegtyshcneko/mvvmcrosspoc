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
	[Register ("CountryInfoView")]
	partial class CountryInfoView
	{
		[Outlet]
		UIKit.UITableView CountryDataTableView { get; set; }

		[Outlet]
		UIKit.UIButton PullDataButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (PullDataButton != null) {
				PullDataButton.Dispose ();
				PullDataButton = null;
			}

			if (CountryDataTableView != null) {
				CountryDataTableView.Dispose ();
				CountryDataTableView = null;
			}
		}
	}
}
