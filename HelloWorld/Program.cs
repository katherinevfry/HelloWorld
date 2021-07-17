using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a greeting by typing an option below");
            foreach (var arg in args)
            {
                Console.WriteLine(arg + Environment.NewLine);
            }
            string greeting;
            greeting = Console.ReadLine();

            switch (greeting)
            {
                case "southern":
                    Console.WriteLine("hey y'alllll");
                    break;
                case "british":
                    Console.WriteLine("Good Day Sir/Madam");
                    break;
                case "ozark":
                    Console.WriteLine("how's your mom'an'em?");
                    break;
                default:
                    break;
            }

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
              if (animal.Length >= 6)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
