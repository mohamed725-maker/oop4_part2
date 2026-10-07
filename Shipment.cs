namespace oop4part2;

public abstract class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;
    private DeliveryAddress destination;

    public string TrackingCode
    {
        get => trackingCode;
        protected set
        {
            if (!string.IsNullOrWhiteSpace(value))
                trackingCode = value;
        }
    }

    public string Description
    {
        get => description;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    public decimal Weight
    {
        get => weight;
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get => deliveryFee;
        protected set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    public DeliveryAddress Destination
    {
        get => destination;
        set => destination = value;
    }

    protected Shipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
    {
        this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "Unknown" : trackingCode;
        this.description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
        this.weight = weight > 0 ? weight : 1;
        this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
        this.destination = destination;
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
            DeliveryFee = newFee;
    }

    public abstract decimal EstimatedCost { get; }

    public abstract void PrintShipment();
}
