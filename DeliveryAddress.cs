

namespace Smart_Delivery_Management_System_OOP_03
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"City: {City} , Street: {Street} , BuildingNumber: {BuildingNumber}";
        }

        public override string ToString()
        {
            return $"City: {City} -  Street: {Street} -  BuildingNumber: {BuildingNumber}";
        }

    }
}