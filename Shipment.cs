

namespace Smart_Delivery_Management_System_OOP_03
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;


        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public DeliveryAddress Destination { get; set; }


        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))

                    trackingCode = value;
            }

        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }
        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)

                DeliveryFee = newFee;

        }

        public  virtual void PrintShipment()
        {
            Console.WriteLine($"trackingCode: {TrackingCode}");
            Console.WriteLine($"description: {Description}");
            Console.WriteLine($"weight: {Weight}");
            Console.WriteLine($"deliveryFee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"EstimatedCost: {EstimatedCost}");
            Console.WriteLine("==================================");
        }

        public void UpdateWeight(decimal weight)
        {
            Weight = weight;
        }

        public void UpdateWeight(decimal weight , decimal extraPackingWeight)
        {
            Weight = weight + extraPackingWeight;
        }




    }

}