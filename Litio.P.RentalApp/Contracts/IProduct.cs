namespace Litio.P.RentalApp.Contracts
{
    public interface IProduct
    {
        decimal Price { get; set; }
        int Id { get; set; }
        int RentTime { get; set; }
        TimeType TimeType { get; set; }
        int MaxRentTime { get; set; }
        string Name { get; set; }
        decimal Total { get; set; }
    }

    public enum TimeType
    {
        Hour = 0,
        Day,
        Month,
        Year
    }
}
