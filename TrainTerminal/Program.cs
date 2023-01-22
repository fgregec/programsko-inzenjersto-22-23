using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrainTerminal.Design_Pattern;
using TrainTerminal.Models;
using TrainTerminal.Tests;

namespace TrainTerminal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Terminal terminal = TerminalFactory.createTerminal();

            Employee pero = new Employee("Pero", 0.1);
            Employee marko = new Employee("Marko", 0.11);

            //Thread sleep is for random generator
            Car car = new Car();
            Thread.Sleep(10);
            Van van = new Van();
            Thread.Sleep(10);
            Bus bus = new Bus();
            Thread.Sleep(10);
            Truck truck = new Truck();


            pero.loadVehicle(car, terminal);
            marko.loadVehicle(van, terminal);
            pero.loadVehicle(bus, terminal);
            marko.loadVehicle(truck, terminal);

            pero.getEarnings();
            marko.getEarnings();

            terminal.getTotalTerminalEarnings();

        }
    }
}
