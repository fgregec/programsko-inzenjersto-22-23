using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Enums;

namespace TrainTerminal.Models
{
    public class Van : Vehicle
    {
        public Van() : base(80, VehicleType.VAN, VehicleSize.SMALL)
        {
        }
    }
}
