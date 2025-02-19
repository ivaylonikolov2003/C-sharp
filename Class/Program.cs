namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Rick", 30);
            Car car1 = new Car("Audi", "A3", 2008, "black");
            Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "pepperoni");
            car1.Drive();


            human1.Eat();
            human1.Sleep();

            Console.ReadKey();
        }
    }
}
