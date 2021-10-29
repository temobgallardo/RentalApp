using System.Collections.Generic;
using System.Threading.Tasks;

namespace Litio.P.RentalApp.Contracts
{
    public interface IDatabaseLayer<T> where T : IAutomobile
    {
        Task Save(T data);
        Task<List<T>> Retrieve();
    }
}
