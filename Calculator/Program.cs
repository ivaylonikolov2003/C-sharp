namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;


                Console.WriteLine("Calculator Program");

                Console.Write("Enter a number1: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Enter a number2: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Substract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("That is invalid option!!!");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
