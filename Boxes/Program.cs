using System.Globalization;
namespace Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            String line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                int serialNumber = int.Parse(tokens[0]);
                String name = tokens[1];
                int quantity = int.Parse(tokens[2]);
                decimal price = decimal.Parse(tokens[3].Replace(".", ","));

                Box box = new Box() {
                    SerialNumber = serialNumber,
                    item = new Item { Name =  name, Price = price },
                    Quantity = quantity
                };

                boxes.Add(box);

                line = Console.ReadLine();
            }

            boxes.Sort((a, b) => b.PriceForBox.CompareTo(a.PriceForBox));

            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.item.Name} - ${box.item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
            Console.ReadKey();
        }
    }
}
