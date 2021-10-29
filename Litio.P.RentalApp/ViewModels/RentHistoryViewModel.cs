using Litio.P.RentalApp.Contracts;
using Prism.Navigation;
using Litio.P.RentalApp.Extensions;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Litio.P.RentalApp.ViewModels
{
    public class RentHistoryViewModel : ViewModelBase
    {
        private readonly IDatabaseLayer<IAutomobile> _databaseService;

        public ObservableCollection<IAutomobile> Automobiles { get; set; }

        public RentHistoryViewModel(INavigationService navigationService, IDatabaseLayer<IAutomobile> databaseService) : base(navigationService)
        {
            Automobiles = new ObservableCollection<IAutomobile>();
            _databaseService = databaseService;
        }

        public override async void OnNavigatedFrom(INavigationParameters parameters)
        {
            List<IAutomobile> data = await _databaseService.Retrieve();
            Automobiles.AddRange(data);
        }

        protected override void OnNavigateCommandExecuted(string path)
        {
            Automobiles.Clear();

            base.OnNavigateCommandExecuted(path);
        }
    }
}
