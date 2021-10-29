using Litio.P.RentalApp.Contracts;

namespace Litio.P.RentalApp.Models
{
    /// <summary>
    /// Trying to reduce the boilerplate code in the IAutomobile implementations using an abstract class, but it does not work as I expected. In the ElecticalBicycle child the use of field to change the values of the default implementation does not change their values.
    /// </summary>
    public abstract class Automobile : ObservableModel, IAutomobile
    {
        //TODO: Set fields from DAO
        private decimal _price;
        private TimeType _timeType;
        private int _rentTime;
        private decimal _total;

        protected Automobile(decimal price, TimeType timeType, int rentTime, decimal total)
        {
            _price = price;
            _timeType = timeType;
            _rentTime = rentTime;
            _total = total;
        }

        public virtual float Speed { get; set; }
        public virtual decimal Price { get => _price; set => SetProperty(ref _price, value); }
        public virtual int Id { get; set; }
        public virtual int RentTime
        {
            get => _rentTime;
            set
            {
                SetProperty(ref _rentTime, value);
                Total = RentTime * Price;
            }
        }
        public virtual TimeType TimeType { get => _timeType; set => SetProperty(ref _timeType, value); }
        public virtual int MaxRentTime { get; set; }
        public virtual string Name { get => nameof(Automobile); set { } }
        public virtual decimal Total { get => _total; set => SetProperty(ref _total, value); }
    }
}
