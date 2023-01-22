using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;

namespace TrainTerminal.Models
{
    public class Vehicle : IRechargeable
    {
        private int batteryPower;
        private int gasPercentage;
        private int price;
        VehicleType vehicleType;
        VehicleSize vehicleSize;

        public Vehicle(int price, VehicleType vehicleType, VehicleSize vehicleSize)
        {
            Random random = new Random();
            this.batteryPower = random.Next(0,100);
            this.gasPercentage = random.Next(0,100);
            this.price = price;
            this.vehicleType = vehicleType;
            this.vehicleSize = vehicleSize;
            Console.WriteLine(vehicleType + " battery: " + batteryPower + ", gas percentage: " + gasPercentage);
            CheckStats();
        }

        public void CheckStats()
        {
            if (gasPercentage < 10)
            {
                Console.WriteLine(vehicleType + " gas percentage is below 10%. Recharge in progress!");
                gasPercentage = 100;
            }
            if (batteryPower < 10)
            {
                Console.WriteLine(vehicleType + " battery power is below 10%. Recharge in progress!");
                batteryPower = 100;
            }
        }

        public void getBatteryPower() => Console.WriteLine("Battery percentage: " + gasPercentage);
        public void getGasPercentage() => Console.WriteLine("Gas percentage: " + gasPercentage);
        public int getPrice() => price;

        public int getGas() => gasPercentage;

        public VehicleSize getVehicleSize() => vehicleSize;
        public VehicleType getVehicleType() => vehicleType;

    }
}
