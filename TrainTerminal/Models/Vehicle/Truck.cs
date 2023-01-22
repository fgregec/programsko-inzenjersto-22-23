using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;

namespace TrainTerminal.Models
{
    public class Truck : Vehicle
    {
        public Truck() : base(90, VehicleType.TRUCK, VehicleSize.LARGE)
        {
        }
    }
}
