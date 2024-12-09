using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class FillingLevelSensor : Sensor
    {
        public FillingLevelSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 110;
            Console.WriteLine($"{Name} Tank filling level: {Value} %");
        }
    }

}
