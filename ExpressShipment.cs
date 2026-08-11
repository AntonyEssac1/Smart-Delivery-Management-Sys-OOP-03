

namespace Smart_Delivery_Management_System_OOP_03
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        /*
         * Requirements:
            ExtraFee must be greater than or equal to 0.
            Override the EstimatedCost property to include the extra fee.

        */

      

      


        public ExpressShipment(
         string trackingCode,
         string description,
         decimal weight,
         decimal deliveryFee,
         DeliveryAddress destination,
         decimal extraFee)
         : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }


        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)

                    extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }



        public override void PrintShipment()
        {
            base.PrintShipment();

            Console.WriteLine($"ExtraFee: {ExtraFee}");
            Console.WriteLine("==================================");
        }



    }

    }

