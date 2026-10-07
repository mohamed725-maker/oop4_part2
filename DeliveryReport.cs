namespace oop4part2;

public static class DeliveryReport
{
    public static void PrintShipment(ITrackable shipment)
    {
        Console.WriteLine(shipment.GetTrackingStatus());
    }

    public static void PrintInsurance(IInsurable shipment)
    {
        Console.WriteLine($"Insurance : {shipment.CalculateInsurance():0.00} EGP");
    }
}
