namespace oop4part2;

public class ExpressShipment : Shipment, ITrackable, IInsurable
{
    public decimal ExtraFee { get; }

    public ExpressShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee > 0 ? extraFee : 0;
    }

    public override decimal EstimatedCost
        => DeliveryFee + (Weight * 5) + ExtraFee;

    public override void PrintShipment()
    {
        Console.WriteLine("Express Shipment");
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Extra Fee : {ExtraFee:0.##} EGP");
        Console.WriteLine($"Estimated Cost: {EstimatedCost:0.##} EGP");
        Console.WriteLine("------------------------------------------");
    }

    public string GetTrackingStatus()
        => $"Shipment {TrackingCode} is Out for Delivery.";

    public decimal CalculateInsurance()
        => EstimatedCost * 0.08m;
}
