using System;
using System.Collections.Generic;
using System.Text;

namespace AutomapperConfiguration
{
    public class Car
    {
        public string Vin { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Capacity { get; set; }
        public int VMax { get; set; }
        public Person Owner { get; set; }

    }
}
