using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKM724NetBasics.Interfaces;

namespace IKM724NetBasics.Entities.Systems
{
    public class PasteurizationSystem : IControllable
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Pasteurization system turned on.");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Pasteurization system turned off.");

        }
    }
}
