namespace oop4part2;

public class InternationalShipment : Shipment, ITrackable, IInsurable
{
    public string DestinationCountry { get; }

    public InternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        DestinationCountry = string.IsNullOrWhiteSpace(destinationCountry)
            ? "Unknown"
            : destinationCountry;
    }

    public override decimal EstimatedCost
        => DeliveryFee + (Weight * 5) + 100;

    public override void PrintShipment()
    {
        Console.WriteLine("International Shipment");
        Console.WriteLine($"Tracking Code     : {TrackingCode}");
        Console.WriteLine($"Destination Country : {DestinationCountry}");
        Console.WriteLine($"Estimated Cost    : {EstimatedCost:0.##} EGP");
        Console.WriteLine("------------------------------------------");
    }

    public string GetTrackingStatus()
        => $"Shipment {TrackingCode} has been Delivered.";

    public decimal CalculateInsurance()
        => EstimatedCost * 0.12m;
}
