namespace Smart_Delivery_Management_System_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {


namespace Smart_Delivery_Management_System_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region // Part 01 — Theoretical Questions

            //            Q1 — Overloading, Overriding, and Binding
            //a) What is the difference between Method Overloading and Method Overriding?

            //Method Overloading:

            //Means having multiple methods with the same name but different parameters in the same class.
            //It is an example of compile-time polymorphism.
            //The compiler decides which method to call based on the arguments.

            //Method Overriding:

            //Happens when a child class provides a new implementation for a method that already exists in the parent class.
            //The method must be virtual in the parent and override in the child.
            //It is an example of run-time polymorphism.
            //The actual object determines which method is executed.


            //            b) What is the difference between Static Binding and Dynamic Binding?

            //Static Binding:

            //The method call is determined at compile time.
            //Usually happens with method overloading.
            //The compiler knows which method will be called before the program runs.

            //Dynamic Binding:

            //The method call is determined at runtime.
            //Happens with method overriding and polymorphism.
            //The actual object decides which overridden method will execute.


            //Q2 — Sealed Classes and Methods
            //a) What is the purpose of the sealed keyword when applied to a class?

            //A sealed class is a class that cannot be inherited by another class.

            //It is used when you want to prevent other classes from extending or inheriting from that class.


            //            b) What is the difference between a sealed class and a sealed method?

            //Sealed Class:

            //Prevents the entire class from being inherited.
            //No other class can derive from it



            //            Sealed Method:

            //Prevents a specific overridden method from being overridden again by a further child class.
            //The class itself can still be inherited


            //            c) Can a sealed method be overridden? Why?

            //No.

            //A sealed method cannot be overridden by any further derived class because the sealed keyword explicitly prevents further overriding.
            #endregion   //  // 

            #region // Part 02 — Practical

           
            Driver driver = new Driver();

            driver.DriverId = 1001;
            driver.FullName = "Ahmed Mohamed";
            driver.PhoneNumber = "01000112401";

            DeliveryCenter center = new DeliveryCenter("Cairo Center");

            center.Driver = driver;

            DeliveryAddress address = new DeliveryAddress(
                "El_Nozha",
                "Str_27",
                5
            );

            StandardShipment standard = new StandardShipment(
                "SH001",
                "Laptop",
                3,
                80,
                address
            );

            ExpressShipment express = new ExpressShipment(
                "SH002",
                "Mobile Phone",
                2,
                60,
                address,
                30
            );

            InternationalShipment international = new InternationalShipment(
                "SH003",
                "Television",
                8,
                120,
                address,
                "Germany",
                100
            );

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            center.PrintAllShipments();

            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("Standard Shipment Printed Successfully.");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine("Express Shipment Printed Successfully.");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("International Shipment Printed Successfully.");

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("Updating Weight...");
            Console.WriteLine();

            Console.WriteLine($"Original Weight : {standard.Weight} KG");
            Console.WriteLine();

            standard.UpdateWeight(5);

            Console.WriteLine($"Updated Weight : {standard.Weight} KG");
            Console.WriteLine();

            standard.UpdateWeight(5, 0.5m);

            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine();

            Shipment[] shipments =
            {
                    standard,
                    express,
                    international
                };

            foreach (Shipment shipment in shipments)
            {
                shipment.PrintShipment();
            }

            Console.WriteLine("==========================================");

            #endregion


            // =========================================================
            // l. Sealed Class and Sealed Method
            // =========================================================

            // CompletedShipment is sealed,
            // so another class cannot inherit from it.

            // GenerateCustomsReport() is sealed in
            // PriorityInternationalShipment,
            // so another derived class cannot override it.



        }
    }
}

   
        }
    }
}
