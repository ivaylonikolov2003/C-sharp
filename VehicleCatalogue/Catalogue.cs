using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    internal class Catalogue
    {
        public List<Car> Cars {  get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();

        public void PrintCatalogue()
        {
            if (Cars.Any())
            {
                Console.WriteLine("Cars:");
                foreach (var Car in Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{Car.Brand}: {Car.Model} - {Car.HorsePower}hp");
                }
            }

            if (Trucks.Any())
            {
                Console.WriteLine("Trucks:");
                foreach (var Truck in Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{Truck.Brand}: {Truck.Model} - {Truck.Weight}kg");
                }
            }
        }
    }
}
