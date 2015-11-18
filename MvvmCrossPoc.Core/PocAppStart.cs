using System;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossPoc.Core.ViewModels;


namespace MvvmCrossPoc.Core
{
    public class PocAppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<FirstViewModel>();
        }
    }
}