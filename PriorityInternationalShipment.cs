using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System_OOP_03
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee
            )
            : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee){}
        public override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority International Customs Report");

        }
    }
}
