using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    internal class Truck
    {
        public String Brand {  get; set; }
        public String Model { get; set; }
        public int Weight { get; set; }

        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
}
