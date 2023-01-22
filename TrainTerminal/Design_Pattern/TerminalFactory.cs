using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Models;

namespace TrainTerminal.Design_Pattern
{
    public class TerminalFactory
    {
        public static Terminal createTerminal() => new Terminal();
    }
}
