using Litio.P.RentalApp.Contracts;

namespace Litio.P.RentalApp.Models
{
    public class ElectricalBicycle : Automobile
    {
        public ElectricalBicycle() : base(100, TimeType.Year, 0, 0) { }
        public override string Name { get => "Electrical Bicycle"; set { } }
    }
}
