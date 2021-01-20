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

                Console.Write("Enter Height: ");
                var heightInput = Console.ReadLine();
                var newHeight = double.Parse(heightInput);

                var area = newLength * newWidth;
                Console.WriteLine($"Area: {area}");

                var perimeter = 2 * (newLength + newWidth);
                Console.WriteLine($"Perimeter: {perimeter}");

                var volume = newLength * newWidth * newHeight;
                Console.Write($"Volume: {volume}" + "\n");

                var surfaceArea = 2 * (newLength * newWidth) + (newHeight * newWidth) + (newLength * newHeight);
                Console.WriteLine($"Surface Area: {surfaceArea}" + "\n");

                bool isInvalid;

                do
                {
                    Console.Write("Would you like to measure another room? (y/n): " + "\n");
                    userInput = Console.ReadLine();
                    isInvalid = userInput != "y" && userInput != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Error: You need to enter 'y' or 'n'!" + "\n");
                    }
                } while (isInvalid);
            } while (userInput == "y");

            Console.WriteLine("Goodbye!");


        }
    }
}
