
using System;

using Foundation;
using UIKit;
using MvvmCrossPoc.Core.Remote;
using System.Diagnostics;

namespace MvvmCrossPoc
{
    public partial class TestViewController : UIViewController
    {
        public TestViewController()
            : base("TestViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
            
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            

        }
    }
}

