using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKM724NetBasics.Interfaces;

namespace IKM724NetBasics.Entities.Systems
{
    public class pHStabilizerSystem : IControllable
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("pH Stabilizer system turned on.");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("pH Stabilizer system turned off.");

        }
    }
}
