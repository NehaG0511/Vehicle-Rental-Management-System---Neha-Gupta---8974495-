using System;

namespace Assign_3___Vehicle_M_S__Neha_gupta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displaing Fleet details of Vehicles
            Vehicle car = new Car("Mustang", "Ford", 2024, 150.00m, 2, "V8", "Automatic", true);
            Vehicle truck = new Truck("M-579", "Peterbilt", 2023, 200.00m, 3000, "V6", false);
            Vehicle motorcycle = new Motorcycle("Softail", "Harely Davidson", 2022, 100.00m, 600, "Gasoline", true);

            // Create rental agency
            RentalAgency agency = new RentalAgency();

            while (true) //Applying While loop for satisfying various requirements
            {
                Console.WriteLine("\n Welcome to Vehicle Rental Management System - Choose from below");
                Console.WriteLine("1. Add Vehicle"); //Choice 1 for adding vehicle
                Console.WriteLine("2. Remove Vehicle"); //choice 2 for reemoving vehicle
                Console.WriteLine("3. Rent Vehicle"); //choice 3 for renting vehicle
                Console.WriteLine("4. Display Total Revenue"); //choice 4 for displaying total revenue
                Console.WriteLine("5. Display Fleet Details"); //choice for fleet details showcase
                Console.WriteLine("6. Exit"); //exit the app

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter vehicle type (Car, Truck, Motorcycle):");
                        string vehicleType = Console.ReadLine();

                        switch (vehicleType.ToLower())
                        {
                            case "car":
                                Console.Write("Enter model: ");
                                string model = Console.ReadLine();
                                Console.Write("Enter manufacturer: ");
                                string manufacturer = Console.ReadLine();
                                Console.Write("Enter year: ");
                                int year = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter rental price: ");
                                decimal rentalPrice = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Enter number of seats: ");
                                int seats = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter engine type: ");
                                string engineType = Console.ReadLine();
                                Console.Write("Enter transmission: ");
                                string transmission = Console.ReadLine();
                                Console.Write("Enter convertible (true/false): ");
                                bool convertible = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("Great! Your car is added to the fleet");

                                agency.AddVehicle(new Car(model, manufacturer, year, rentalPrice, seats, engineType, transmission, convertible));
                                break;

                            case "truck":
                                Console.Write("Enter model: ");
                                model = Console.ReadLine();
                                Console.Write("Enter manufacturer: ");
                                manufacturer = Console.ReadLine();
                                Console.Write("Enter year: ");
                                year = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter rental price: ");
                                rentalPrice = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Enter capacity: ");
                                int capacity = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter truck type: ");
                                string truckType = Console.ReadLine();
                                Console.Write("Enter four-wheel drive (true/false): ");
                                bool fourWheelDrive = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("Great! Your Truck is added to the fleet");
                                agency.AddVehicle(new Truck(model, manufacturer, year, rentalPrice, capacity, truckType, fourWheelDrive));
                                break;

                            case "motorcycle":
                                Console.Write("Enter model: ");
                                model = Console.ReadLine();
                                Console.Write("Enter manufacturer: ");
                                manufacturer = Console.ReadLine();
                                Console.Write("Enter year: ");
                                year = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter rental price: ");
                                rentalPrice = Convert.ToDecimal(Console.ReadLine());
                                Console.Write("Enter engine capacity: ");
                                int engineCapacity = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter fuel type: ");
                                string fuelType = Console.ReadLine();
                                Console.Write("Enter fairing (true/false): ");
                                bool hasFairing = Convert.ToBoolean(Console.ReadLine());
                                Console.WriteLine("Great! Your motorcycle is added to the fleet");
                                agency.AddVehicle(new Motorcycle(model, manufacturer, year, rentalPrice, engineCapacity, fuelType, hasFairing));
                                break;

                            default:
                                Console.WriteLine("Invalid vehicle type.");
                                break;
                        }
                        break;

                    case 2:
                        Console.Write("Enter vehicle type (Car, Truck, Motorcycle):");
                        string removeVehicleType = Console.ReadLine();

                        switch (removeVehicleType.ToLower())
                        {
                            case "car":
                                Console.Write("Enter model: ");
                                string Model = Console.ReadLine();
                                Console.Write("Enter manufacturer: ");
                                string Manufacturer = Console.ReadLine();
                                Console.Write("Enter year: ");
                                int Year = Convert.ToInt32(Console.ReadLine());

                                agency.RemoveVehicle(new Car(Model, Manufacturer, Year, 0, 0, null, null, false));
                                break;
                            case "truck":
                                Console.Write("Enter model: ");
                                Model = Console.ReadLine();
                                Console.Write("Enter manufacturer: ");
                                Manufacturer = Console.ReadLine();
                                Console.Write("Enter year: ");
                                Year = Convert.ToInt32(Console.ReadLine());

                                agency.RemoveVehicle(new Truck(Model, Manufacturer, Year, 0, 0, null, false));
                                break;
                            case "motorcycle":
                                Console.Write("Enter model: ");
                                Model = Console.ReadLine();
                                Console.Write("Enter manufacturer: ");
                                Manufacturer = Console.ReadLine();
                                Console.Write("Enter year: ");
                                Year = Convert.ToInt32(Console.ReadLine());

                                agency.RemoveVehicle(new Motorcycle(Model, Manufacturer, Year, 0, 0, null, false));
                                break;
                            default:
                                Console.WriteLine("Invalid vehicle type.");
                                break;
                        }
                        break;

                    case 3:
    Console.Write("Enter vehicle type (Car, Truck, Motorcycle):");
    string rentVehicleType = Console.ReadLine();

    switch (rentVehicleType.ToLower())
    {
        case "car":
            Console.Write("Enter model: ");
            string carModel = Console.ReadLine();
            Console.Write("Enter manufacturer: ");
            string carManufacturer = Console.ReadLine();
            Console.Write("Enter year: ");
            int carYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Congratulations! Car is available for rent");
            agency.RentVehicle(car);
            break;
        case "truck":
            Console.Write("Enter model: ");
            string truckModel = Console.ReadLine();
            Console.Write("Enter manufacturer: ");
            string truckManufacturer = Console.ReadLine();
            Console.Write("Enter year: ");
            int truckYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Congratulations! Truck is available for rent");
            agency.RentVehicle(truck);
            break;
        case "motorcycle":
            Console.Write("Enter model: ");
            string motorcycleModel = Console.ReadLine();
            Console.Write("Enter manufacturer: ");
            string motorcycleManufacturer = Console.ReadLine();
            Console.Write("Enter year: ");
            int motorcycleYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Congratulations! Motorcycle is available for rent");
            agency.RentVehicle(motorcycle);
            break;
                            default:
                                Console.WriteLine("Invalid vehicle type.");
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine($"Total Revenue: {agency.TotalRevenue}");
                        break;

                    case 5:
                        DisplayFleetDetails(car, truck, motorcycle);
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void DisplayFleetDetails(Vehicle car, Vehicle truck, Vehicle motorcycle)
        {
            Console.WriteLine("\n Here are the Fleet Details:");
            Console.WriteLine("-------------");
            Console.WriteLine("\n Car Details:");
            car.DisplayDetails();
            Console.WriteLine("\n Truck Details:");
            truck.DisplayDetails();
            Console.WriteLine("\n Motorcycle  Details:");
            motorcycle.DisplayDetails();
            Console.WriteLine("-------------");
        }
    }
}
