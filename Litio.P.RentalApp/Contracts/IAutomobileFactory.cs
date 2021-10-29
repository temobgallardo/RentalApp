namespace Litio.P.RentalApp.Contracts
{
    public interface IAutomobileFactory
    {
        IAutomobile Create<T>() where T : IAutomobile, new();
    }
}
