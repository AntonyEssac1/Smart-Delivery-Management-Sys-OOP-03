

namespace Smart_Delivery_Management_System_OOP_03
{
    internal class DeliveryCenter
    {
        private Shipment[] Shipments;

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            Shipments = new Shipment[20];
        }
        public string CenterName { get; private set; }

        public Driver Driver { get;  set; }


      
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= Shipments.Length)
                    return default!;

                return Shipments[index];
            }

            set
            {
                if (index >= 0 && index < Shipments.Length)
                    Shipments[index] = value;

            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < Shipments.Length; i++)
                {
                    if (Shipments[i] != null && Shipments[i].TrackingCode == trackingCode)
                        return Shipments[i];
                }

                return default;
            }
        }




        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] == null)
                {
                    Shipments[i] = shipment;
                    Console.WriteLine(" \n Shipment added successfully \n");
                    return true;
                }
            }

            return false;
        }



        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null && Shipments[i].TrackingCode == trackingCode)
                {
                    Shipments[i] = null;
                    return true;
                }
            }
            return false;
        }





        public void PrintAllShipments()
        {

            for (int i = 0; i < Shipments.Length; i++)
            {
                if (Shipments[i] != null)
                {
                    Console.WriteLine($"{i + 1} - Shipment : ");
                    Shipments[i].PrintShipment();
                }
            }

        }




    }

}