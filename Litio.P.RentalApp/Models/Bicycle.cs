using Litio.P.RentalApp.Contracts;

namespace Litio.P.RentalApp.Models
{
    public class Bicycle : Automobile
    {
        public Bicycle() : base(2, TimeType.Day, 0, 0) { }
        public override string Name { get => nameof(Bicycle); set { } }
    }
}
