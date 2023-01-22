using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;
using TrainTerminal.Models;
using TrainTerminal.Models.Train;

namespace TrainTerminal.Tests
{
    
    public class Test
    {
        [Test]
        public void testCar()
        {
            Car car = new Car();
            Assert.AreEqual(car.getVehicleSize(), VehicleSize.SMALL);
            Console.WriteLine("Test 1 has passed!");

            Bus bus = new Bus();
            Assert.AreEqual(bus.getVehicleType(), VehicleType.BUS);
            Console.WriteLine("Test 2 has passed");

        }
    }
}
