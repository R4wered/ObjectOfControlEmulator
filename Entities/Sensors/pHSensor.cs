﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Sensors
{
    public class pHSensor : Sensor
    {
        public pHSensor(string name, string description)
            : base(name, description) { }

        public override void ReadValue()
        {
            Value = new Random().NextDouble() * 14;
            Console.WriteLine($"{Name} pH level: {Value} pH");
        }
    }
}
