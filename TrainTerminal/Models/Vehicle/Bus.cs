using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;

namespace TrainTerminal.Models
{
    public class Bus : Vehicle
    {
        public Bus() : base(70, VehicleType.BUS, VehicleSize.LARGE)
        {
        }
    }
}
