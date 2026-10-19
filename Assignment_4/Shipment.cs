
namespace Assignment_4
{
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;



        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (value != null && value != string.Empty && value != "")
                    trackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != null && value != string.Empty && value != "")
                    description = value;
            }
        }

        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();


        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            description = "Unknown";
            weight = 1;
            deliveryFee = 50;
            destination = default;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            this.destination = destination;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }


        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            decimal totalWeight = newWeight + extraPackingWeight ;
            if (totalWeight > 0)
                Weight = totalWeight;
        }

        
    }
}
