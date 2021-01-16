using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!" + "\n");

            string userInput;
 
            do
            {
            Console.Write("Enter Length: ");
            var lengthInput = Console.ReadLine();
            var newLength = double.Parse(lengthInput);

            Console.Write("Enter Width: ");
            var widthInput = Console.ReadLine();
            var newWidth = double.Parse(widthInput);

            var area = newLength * newWidth; 
            Console.Write($"Area: {area}" + "\n");

            var perimeter = 2 * (newLength + newWidth);
                Console.WriteLine($"Perimeter: {perimeter}" + "\n");

                Console.Write("Would you like to measure another room? (y/n) ");
                userInput = Console.ReadLine();
             } while (userInput == "y");

            Console.WriteLine("Goodbye!");

           
        }
    }
}
