using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Litio.P.RentalApp.Extensions
{
    public static class ListExtensions
    {
        public static void AddRange<T>(this List<T> self, List<T> data)
        {
            data.ForEach((d) => self.Add(d));
        }
    }

    public static class ObservableCollectionExtensions
    {
        public static void AddRange<T>(this ObservableCollection<T> self, List<T> data)
        {
            foreach (T d in data)
            {
                self.Add(d);
            }
        }
    }
}
