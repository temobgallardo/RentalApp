using Litio.P.RentalApp.Contracts;
using Litio.P.RentalApp.Services;
using Litio.P.RentalApp.ViewModels;
using Litio.P.RentalApp.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Litio.P.RentalApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            var result = await NavigationService.NavigateAsync("NavigationPage/RentVehiclePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.RegisterSingleton<IDatabaseLayer<IAutomobile>, DatabaseService<IAutomobile>>();
            containerRegistry.RegisterSingleton<IAutomobileFactory, AutomobileFactory>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<RentVehiclePage, RentVehicleViewModel>();
            containerRegistry.RegisterForNavigation<RentHistoryPage, RentHistoryViewModel>();
        }
    }
}
