namespace Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];

                if(IsStudentExisting(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = city;

                    students.Add(student);
                }
                else
                {
                    Student student = new Student()
                    {
                        firstName = firstName,
                        lastName = lastName,
                        age = age,
                        homeTown = city

                    };
                    students.Add(student);
                }

                line = Console.ReadLine();
            }

            string filteredCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.homeTown == filteredCity)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }

            Console.ReadKey();
        }

        public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        public static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }


}
