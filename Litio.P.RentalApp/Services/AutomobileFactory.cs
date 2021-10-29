using Litio.P.RentalApp.Contracts;
using Litio.P.RentalApp.Services;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(AutomobileFactory))]
namespace Litio.P.RentalApp.Services
{
    public class AutomobileFactory : IAutomobileFactory
    {
        public IAutomobile Create<T>() where T : IAutomobile, new()
        {
            Type t = typeof(T);
            object automobile = Activator.CreateInstance(t);
            return (IAutomobile)automobile;
        }
    }
}
