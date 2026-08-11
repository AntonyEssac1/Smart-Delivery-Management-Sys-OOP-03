

namespace Smart_Delivery_Management_System_OOP_03
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;

        //Requirements:
        //DestinationCountry cannot be null, empty, or whitespace.
        //CustomsFee must be greater than or equal to 0.
        //Override the EstimatedCost property to include the customs fee.





        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + customsFee;
            }
        }


        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee
            )
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }

        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)

                    customsFee = value;
            }
        }







        public override void PrintShipment()
        {
            base.PrintShipment();

            Console.WriteLine($"DestinationCountry: {DestinationCountry}");
            Console.WriteLine($"CustomsFee: {CustomsFee}");
            Console.WriteLine("==================================");
        }



        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine(" International  Report");

        }

    }
}