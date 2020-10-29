using System;

namespace project2_1_student_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form!");

            Console.Write("Enter first name: ");
            String firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            String lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            String birthDate = Console.ReadLine();

            Console.WriteLine("Welcome" + firstName +lastName);
          
        }
    }
}
