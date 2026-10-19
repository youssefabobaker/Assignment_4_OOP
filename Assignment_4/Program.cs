namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions 
            #region Q1  Abstraction
            // What is Abstraction --> The process of hiding complex implementation details and showing only the essential features of an object.
            // Why is abstraction considered one of the four pillars of OOP --> because it allows developers to focus on the essential features of an object, rather than being distracted by the complex implementation details. This leads to more maintainable and flexible code.
            #endregion

            #region Q2  Abstract Classes vs. Interfaces 
            // What is the difference between an Abstract Class and an Interface? --> An abstract class can have both abstract and non-abstract methods, while an interface can only have abstract methods. An abstract class can have fields, constructors, and access modifiers, while an interface cannot. A class can inherit from only one abstract class, but it can implement multiple interfaces.
            // When would you choose an Interface instead of an Abstract Class? --> to define a contract that multiple classes can implement, regardless of their position in the class hierarchy. Interfaces are ideal for defining capabilities that can be shared across unrelated classes, promoting flexibility and decoupling in your design.
            // Can a class inherit from multiple abstract classes? Can it implement multiple interfaces? --> A class cannot inherit from multiple abstract classes due to C#'s single inheritance model, but it can implement multiple interfaces.
            #endregion
            #endregion

            #region Part 02 — Practical
            //DeliveryCenter deliveryCenter = new DeliveryCenter();
            //deliveryCenter.CenterName = "Cairo";
            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine($"DeliveryCenter: {deliveryCenter.CenterName}");
            //Console.WriteLine("-------------------------------------------------------------------");

            //string trackingCode;
            //string description;
            //decimal weight;
            //decimal deliveryFee;
            //string city;
            //string street;
            //int number;
            //DeliveryAddress destination;
            //bool isAdded;

            //Console.WriteLine("Enter Standard Shipment Details:");
            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine()!;
            //Console.Write("Description: ");
            //description = Console.ReadLine()!;
            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine()!);
            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("City: ");
            //city = Console.ReadLine()!;
            //Console.Write("Street: ");
            //street = Console.ReadLine()!;
            //Console.Write("Bulding Number: ");
            //number = int.Parse(Console.ReadLine()!);
            //destination = new DeliveryAddress(city, street, number);
            //StandardShipment standardShipment = new StandardShipment(trackingCode, description, weight, deliveryFee, destination);
            //isAdded = deliveryCenter.AddShipment(standardShipment);
            //if (isAdded)
            //{
            //    Console.WriteLine("StandardShipment added successfully.");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Failed to add Standard shipment.");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter Express Shipment Details:");
            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine()!;
            //Console.Write("Description: ");
            //description = Console.ReadLine()!;
            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine()!);
            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("City: ");
            //city = Console.ReadLine()!;
            //Console.Write("Street: ");
            //street = Console.ReadLine()!;
            //Console.Write("Bulding Number: ");
            //number = int.Parse(Console.ReadLine()!);
            //destination = new DeliveryAddress(city, street, number);
            //Console.Write("ExtraFee: ");
            //decimal extraFee = decimal.Parse(Console.ReadLine()!);
            //ExpressShipment expressShipment = new ExpressShipment(trackingCode, description, weight, deliveryFee, destination, extraFee);
            //isAdded = deliveryCenter.AddShipment(expressShipment);
            //if (isAdded)
            //{
            //    Console.WriteLine("Express Shipment added successfully.");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Failed to add Expressshipment.");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter International Shipment Details:");
            //Console.Write("Tracking Code: ");
            //trackingCode = Console.ReadLine()!;
            //Console.Write("Description: ");
            //description = Console.ReadLine()!;
            //Console.Write("Weight: ");
            //weight = decimal.Parse(Console.ReadLine()!);
            //Console.Write("Delivery Fee: ");
            //deliveryFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("City: ");
            //city = Console.ReadLine()!;
            //Console.Write("Street: ");
            //street = Console.ReadLine()!;
            //Console.Write("Bulding Number: ");
            //number = int.Parse(Console.ReadLine()!);
            //destination = new DeliveryAddress(city, street, number);
            //Console.Write("CustomsFee: ");
            //decimal customsFee = decimal.Parse(Console.ReadLine()!);
            //Console.Write("DestinationCountry: ");
            //String destinationCountry = Console.ReadLine()!;
            //InternationalShipment internationalShipment = new InternationalShipment(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee);
            //isAdded = deliveryCenter.AddShipment(internationalShipment);
            //if (isAdded)
            //{
            //    Console.WriteLine("International Shipment added successfully.");
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Failed to add International shipment.");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("All Shipments in the Delivery Center:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //deliveryCenter.PrintAllShipments();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("Tracking Statuses:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //deliveryCenter.PrintTrackingStatuses();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("Insurances:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //deliveryCenter.PrintInsuranceCosts();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("ITrackable Objects:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //ITrackable[] trackable = { standardShipment, expressShipment, internationalShipment };
            //foreach (ITrackable t in trackable)
            //{
            //    Console.WriteLine(t.GetTrackingStatus());
            //}
            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------------------------------");
            //Console.WriteLine("IInsurable Objects:");
            //Console.WriteLine("-------------------------------------------------------------------");
            //IInsurable[] insurable = { standardShipment, expressShipment, internationalShipment };
            //foreach (IInsurable i in insurable)
            //{
            //    Console.WriteLine($"Insurance: {i.CalculateInsurance()}$");
            //}
            #endregion

        }
    }
}
