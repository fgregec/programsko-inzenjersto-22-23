using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;

namespace TrainTerminal.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public double Earnings { get; set; }
        public double Percentage { get; set; }


        public Employee(string Name, double Percentage)
        {
            this.Name = Name;
            this.Percentage = Percentage;
            this.Earnings = 0;
        }

        public void loadVehicle(Vehicle vehicle, Terminal terminal)
        {
            Earnings += vehicle.getPrice() * Percentage;

            if(vehicle.getVehicleSize() == VehicleSize.SMALL)
            {
                terminal.loadSmallTrain();
            }
            else
            {
                terminal.loadLargeTrain();
            }
            terminal.addMoney(vehicle.getPrice());
        }

        public void getEarnings() => Console.WriteLine($"{Name} has earned: " + Earnings + "$");
    }
}
