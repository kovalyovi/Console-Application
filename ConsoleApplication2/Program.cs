using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //prompt for fullname
            Console.Write("Please enter your full name: ");
            var fullName = Console.ReadLine();

            //prompt for location
            Console.Write("Please enter your location: ");
            var location = Console.ReadLine();

            //display name and location
            Console.WriteLine($"\nMy name is {fullName}");
            Console.WriteLine($"I am from {location}");

            //display today's date
            Console.Write("\nToday is: ");
            var today = DateTime.Now;
            Console.WriteLine(today.ToString("dddd, dd MMMM yyyy"));

            //display days to Christmas
            Console.WriteLine("\nDays untill Christmas: ");
            var christmasYear = DateTime.Now.Month == 12 && DateTime.Now.Day > 25 ?
                                DateTime.Now.Year + 1 : DateTime.Now.Year;
            var christmas = new DateTime(christmasYear, 12, 25);
            Console.WriteLine(Math.Ceiling((christmas - today).TotalDays));

            //2.1 program from textbook
            //declaring variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //prompt for dimensions
            Console.WriteLine("\nLet's get the dimensions of the mirror");

            //prompt for width
            var spin = 0;
            do
            {
                if (spin > 0)
                {
                    Console.WriteLine("\nThe width is incorrect, try again. ");
                }
                Console.Write("Enter the width: ");
                widthString = Console.ReadLine();
                spin++;
            } while (!double.TryParse(widthString, out width) || width <= 0);

            //prompt for height
            spin = 0;
            do
            {
                if (spin > 0)
                {
                    Console.WriteLine("\nThe height is incorrect, try again. ");
                }
                Console.Write("Enter the height: ");
                heightString = Console.ReadLine();
                spin++;
            } while (!double.TryParse(heightString, out height) || height <= 0);

            //calculations
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            //display wood length
            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");

            //display glass area
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //finish program
            Console.WriteLine("\nEnter <Enter> key to close the program");
            Console.ReadLine();

        }
    }
}
