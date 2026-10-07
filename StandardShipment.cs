namespace oop4part2;

public class StandardShipment : Shipment, ITrackable, IInsurable
{
    public StandardShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override decimal EstimatedCost
        => DeliveryFee + (Weight * 5);

    public override void PrintShipment()
    {
        Console.WriteLine("Standard Shipment");
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost:0.##} EGP");
        Console.WriteLine("------------------------------------------");
    }

    public string GetTrackingStatus()
        => $"Shipment {TrackingCode} is Ready.";

    public decimal CalculateInsurance()
        => EstimatedCost * 0.05m;
}
