using Litio.P.RentalApp.Contracts;

namespace Litio.P.RentalApp.Models
{
    public class ElectricalScooter : Automobile
    {
        public ElectricalScooter() : base(5, TimeType.Hour, 0, 0) { }
        public override string Name { get => "Electrical Scooter"; set { } }

    }
}
