using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using MvvmCrossPoc.Core.ViewModels;
using MvvmCrossPoc.Core.Converters;
using System;
using Accelerate;

namespace MvvmCrossPoc.Views
{
    public class CustomTextField : UITextField
    {
        private int letterCount;
        
        //{PropertyName}Changed
        public event EventHandler LetterCountChanged;

        public CustomTextField(CGRect rect) : base(rect)
        {            
            EditingChanged += (sender, e) => {
                letterCount = Text.Length;
            };
        }

        public int LetterCount 
        { 
            get 
            { 
                return letterCount; 
            } 
            set
            {
                letterCount = value;
                RaiseLetterCoundChanged();
            }
        }

        private void RaiseLetterCoundChanged()
        {
            var e = LetterCountChanged;
            if(e != null)
            {
                e(this, EventArgs.Empty);
            }
        }
    }

    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView { BackgroundColor = UIColor.White };
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
            {
               EdgesForExtendedLayout = UIRectEdge.None;
            }
			   
            var label = new UILabel(new CGRect(10, 10, 300, 40));
            Add(label);

            var countLabel = new UILabel(new CGRect(10, 50, 300, 40));
            Add(countLabel);

            var textField = new CustomTextField(new CGRect(10, 90, 300, 40));
            Add(textField);

            var button = new UIButton(new CGRect(10, 130, 50, 40));
            button.SetTitle("OK", UIControlState.Normal);
            button.SetTitleColor(UIColor.Black, UIControlState.Normal);
            Add(button);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(label).To("Hello");
            set.Bind(label).To(vm => vm.HelloCount);
            set.Bind(textField).To("Hello");
            set.Bind(textField).For(tf => tf.LetterCount).To(vm => vm.HelloCount);
            set.Bind(button).To(vm => vm.OkCommand);
            set.Apply();
        }
    }
}