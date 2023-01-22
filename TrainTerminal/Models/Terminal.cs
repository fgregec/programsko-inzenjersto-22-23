using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTerminal.Design_Pattern;
using TrainTerminal.Models.Train;

namespace TrainTerminal.Models
{
    public class Terminal : ITerminal
    {
        private SmallTrain smallTrain;
        private LargeTrain largeTrain;
        private int totalMoneyEarned;

        public Terminal()
        {
            smallTrain= new SmallTrain();
            largeTrain = new LargeTrain();
            totalMoneyEarned = 0;
        }

       
        public void getSmallTrainCurrentCapacity() => smallTrain.getCurrentCapacity();
        public void getLargeTrainCurrentCapacity() => largeTrain.getCurrentCapacity();

        public void addMoney(int cost) => totalMoneyEarned += cost;

        public void getTotalTerminalEarnings() => Console.WriteLine("Total terminal earnings are: " + totalMoneyEarned + "$");

        public void loadSmallTrain()
        {
            smallTrain.addVehicle();
        }

        public void loadLargeTrain()
        {
            largeTrain.addVehicle();
        }
    }
}
