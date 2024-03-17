using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_3___Vehicle_M_S__Neha_gupta
{
    public class RentalAgency
    {
        private Vehicle[] fleet = new Vehicle[10];
        private int totalRevenue;
        private int currentIndex;

        public int TotalRevenue
        {
            get { return totalRevenue; }
        }

        public RentalAgency()
        {
            currentIndex = 0;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (currentIndex < fleet.Length)
            {
                fleet[currentIndex] = vehicle;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Fleet has maximum Capacity. Wait to fleet get empty.");
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (fleet[i].GetType() == vehicle.GetType() &&
                    fleet[i].Model == vehicle.Model &&
                    fleet[i].Manufacturer == vehicle.Manufacturer &&
                    fleet[i].Year == vehicle.Year)
                {
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        fleet[j] = fleet[j + 1];
                    }
                    currentIndex--;
                    break;
                }
            }
        }

        public void RentVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (fleet[i].GetType() == vehicle.GetType() &&
                    fleet[i].Model == vehicle.Model &&
                    fleet[i].Manufacturer == vehicle.Manufacturer &&
                    fleet[i].Year == vehicle.Year)
                {
                    totalRevenue += (int) vehicle.RentalPrice;           
                    RemoveVehicle(fleet[i]);  
                    break;
                }
            }
        }
    }

}
