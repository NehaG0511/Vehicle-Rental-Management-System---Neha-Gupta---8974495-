using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_3___Vehicle_M_S__Neha_gupta
{
    public class Truck : Vehicle
    {

        public string TruckType { get; set; }

        public bool FourWheelDrive { get; set; }

        public int Capacity { get; set; }

        public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive)
                : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"\n Properties of Truck are: ");
            Console.WriteLine($"Capacity: {Capacity}");
            Console.WriteLine($"Truck Type: {TruckType}");
            Console.WriteLine($"Four Wheel Drive: {FourWheelDrive}");
        }
    }

} 

