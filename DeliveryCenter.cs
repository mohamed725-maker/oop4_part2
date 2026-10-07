namespace oop4part2;

public class DeliveryCenter
{
    private readonly Shipment[] shipments = new Shipment[10];

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipments.Length)
                return shipments[index];

            return null!;
        }
        set
        {
            if (index >= 0 && index < shipments.Length && value != null)
                shipments[index] = value;
        }
    }

    public Shipment? this[string trackingCode]
    {
        get
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
                return null;

            foreach (Shipment? shipment in shipments)
            {
                if (shipment != null &&
                    shipment.TrackingCode.Equals(
                        trackingCode,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return shipment;
                }
            }

            return null;
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        if (shipment == null)
            return false;

        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] == null)
            {
                shipments[i] = shipment;
                return true;
            }
        }

        return false;
    }

    public void PrintAllShipments()
    {
        foreach (Shipment? shipment in shipments)
        {
            shipment?.PrintShipment();
        }
    }

    public void PrintTrackingStatuses()
    {
        foreach (Shipment? shipment in shipments)
        {
            if (shipment is ITrackable trackable)
                Console.WriteLine(trackable.GetTrackingStatus());
        }
    }
}
