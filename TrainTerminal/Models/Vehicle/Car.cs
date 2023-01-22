using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;

namespace TrainTerminal.Models
{
    public class Car : Vehicle
    {
        public Car() : base(50, VehicleType.CAR, VehicleSize.SMALL)
        {
            
        }
    }
}
