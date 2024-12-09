using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class TemperatureSensor : Sensor
    {
        public TemperatureSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = -50 + new Random().NextDouble() * 200;
            Console.WriteLine($"{Name} Temperature: {Value} C");
        }
    }
}
