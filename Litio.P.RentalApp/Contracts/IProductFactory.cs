using Litio.P.RentalApp.Contracts;

namespace Litio.Pattern.Factory.Contracts
{
    public interface IProductFactory
    {
        IProduct Create();
    }
}
