namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();

                string name = tokens[0];
                string lastName = tokens[1];
                double grade = double.Parse(tokens[2].Replace(".", ","));

                Student student = new Student(name, lastName, grade);
                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(g => g.Grade)) {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
