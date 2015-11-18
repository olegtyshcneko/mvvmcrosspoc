using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore;
using MvvmCrossPoc.Core.Remote;

namespace MvvmCrossPoc.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
//            CreatableTypes()
//                .EndingWith("Service")
//                .AsInterfaces()
//                .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<ICountryDataService>(() => new CountryDataService());

            RegisterAppStart(new PocAppStart());
        }


    }
}