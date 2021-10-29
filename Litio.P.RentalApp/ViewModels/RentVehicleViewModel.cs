using Litio.P.RentalApp.Contracts;
using Litio.P.RentalApp.Extensions;
using Litio.P.RentalApp.Models;
using Prism.Navigation;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Litio.P.RentalApp.ViewModels
{
    public class RentVehicleViewModel : ViewModelBase
    {
        private IAutomobileFactory _automobileFactory;
        private IDatabaseLayer<IAutomobile> _databaseLayer;
        private IAutomobile _current;

        public IAutomobile Current
        {
            get => _current;
            set
            {
                if (_current is null) return;
                
                if (!_current.Equals(value))
                {
                    InitializaAutomobile();
                }

                SetProperty(ref _current, value);
            }
        }
        public ObservableCollection<IAutomobile> Automobiles { get; private set; }

        public RentVehicleViewModel(INavigationService navigationService, IAutomobileFactory automobileFactory, IDatabaseLayer<IAutomobile> databaseLayer) : base(navigationService)
        {
            _automobileFactory = automobileFactory;
            _databaseLayer = databaseLayer;
            Automobiles = new ObservableCollection<IAutomobile>();
        }

        public override void Initialize(INavigationParameters parameters)
        {
            /// Todo: wrap into a fake service
            var products = new List<IAutomobile>
            {
                _automobileFactory.Create<Car>(),
                _automobileFactory.Create<ElectricalScooter>(),
                _automobileFactory.Create<Bicycle>(),
                _automobileFactory.Create<ElectricalBicycle>()
            };
            Automobiles.AddRange(products);
        }

        protected override async void OnNavigateCommandExecuted(string path)
        {
            await _databaseLayer.Save(_current);

            base.OnNavigateCommandExecuted(path);
        }

        protected override void OnGoHomeCommandExecuted()
        {
            InitializaAutomobile();
         
            base.OnGoHomeCommandExecuted();
        }

        private void InitializaAutomobile()
        {
            _current.RentTime = 0;
            _current.Price = 0;
        }
    }
}
