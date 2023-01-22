using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Interface;

namespace TrainTerminal.Models.Train
{
    public class Train : ILoadable
    {
        public int MaxCapacity { get; set; }
        public int CurrentCapacity { get; set; }

        public Train(int capacity)
        {
            MaxCapacity = capacity;
            CurrentCapacity = 0;
        }

        public bool addVehicle()
        {
            if (CurrentCapacity <= MaxCapacity)
            {
                CurrentCapacity++;
                return true;
            }
            else
            {
                Console.WriteLine("Unable to load, train is full!");
                return false;
            }
        }

        public void getCurrentCapacity() => Console.WriteLine("Current capacity is: " + CurrentCapacity);

    }
}
