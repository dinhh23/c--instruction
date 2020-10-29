using System;

namespace ch02_demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Declare some strings 
            string str1 = "Elvis";
            String str2 = "Presley";

            // Using the var identifier (not in Java)
            var fullName = str1 + " " + str2;
            // var number; // cannot do this, must assign values 
            var number = "0";
            double d1;
            double d2;

            // While loop, prompt for input, sum then 
            // prompt continue?
            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.Write("Enter a decimal value: ");
                d1 = Double.Parse(Console.ReadLine());
                Console.Write("Enter a another decimal value: ");
                d2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Sum is: " + (d1 + d2));
                Console.Write("Continue? ");
                choice = Console.ReadLine();
                Console.WriteLine("");
            }

            // do a simple 'if' statement 
            // stoplight example 
            Console.Write("Stoplight Color: (r,y,g): ");
            String lightColor = Console.ReadLine();

            if (lightColor.Equals("r")) {
                Console.WriteLine("Stop!!!");
            }
            else if (lightColor.Equals("y")) { 
                Console.WriteLine("Slow Down!!!");
            }
            else if (lightColor.Equals("g")) {
                Console.WriteLine("Go!!!");
            }
            else { 
                Console.WriteLine("Invalid Color");
            }



        }
    }
}
