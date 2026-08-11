using Smart_Delivery_Management_System_OOP_03;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery_Management_System_OOP_03
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)

         : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

    }
}


