namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalog = new Catalogue();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split('/');
                string type = parts[0];
                string brand = parts[1];
                string model = parts[2];
                int value = int.Parse(parts[3]);

                if (type == "Truck")
                {
                    catalog.Trucks.Add(new Truck(brand, model, value));
                }
                else if (type == "Car")
                {
                    catalog.Cars.Add(new Car(brand, model, value));
                }
            }

            catalog.PrintCatalogue();

            Console.ReadKey(); 
        }
    }
}
