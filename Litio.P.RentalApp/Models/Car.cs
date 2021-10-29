using Litio.P.RentalApp.Contracts;

namespace Litio.P.RentalApp.Models
{
    public class Car : Automobile
    {
        public Car() : base(20, TimeType.Month, 0, 0) { }
        public override string Name { get => nameof(Car); set { } }
    }
}
