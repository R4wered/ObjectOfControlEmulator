using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKM724NetBasics.Entities.Sensors;
using IKM724NetBasics.Entities.Systems;

namespace IKM724NetBasics.Entities
{
    public class LineOfDairyProducts
    {
        public List<Sensor> Sensors { get; set; }
        public PasteurizationSystem Pasteurizer { get; set; }
        public pHStabilizerSystem pHStabilizer { get; set; }
        public ProductFillingSystem ProductFiller { get; set; }
        public VentilationSystem Ventilation { get; set; }

        public LineOfDairyProducts()
        {
            Sensors = new List<Sensor>();
            Pasteurizer = new PasteurizationSystem();
            pHStabilizer = new pHStabilizerSystem();
            ProductFiller = new ProductFillingSystem();
            Ventilation = new VentilationSystem();
        }

        public void Monitor()
        {
            foreach (var sensor in Sensors)
            {
                sensor.ReadValue();
            }
        }
    }
}
