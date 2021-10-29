
using Litio.P.RentalApp.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Litio.P.RentalApp.Services
{
    public class DatabaseService<T> : IDatabaseLayer<T> where T : IAutomobile
    {
        private static List<T> _data = new List<T>();

        public async Task<List<T>> Retrieve()
        {
            return _data;
        }

        public async Task Save(T data)
        {
            await Task.Run(() => _data.Add(data));
        }
    }
}
