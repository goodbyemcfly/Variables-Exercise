using System.ComponentModel.Design;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string apartmentName = "TrueCoders Apartments";
            int numberOfUnits = 1;
            char[] apartmentNumber = { '2', 'B' };
            bool vacancy;
            if (numberOfUnits >= 1)
            {
                vacancy = true;
            }
            else
            {
                vacancy = false;
            }
            decimal rentCost = 1200.00m;
            double timeLimit = 10;



            Console.WriteLine($"Welcome to {apartmentName}!\n");
            Console.WriteLine("We have a wide variety of units in our community, how many bedrooms would you like your aparmtent to have?");
            var bedroomNumber = Console.ReadLine();

            if (vacancy)
            {
                Console.WriteLine($"We have {numberOfUnits} unit(s) currently available with {bedroomNumber} bedroom(s) available. The vacancy is apartment number {apartmentNumber[0]}{apartmentNumber[1]}.");
                Console.WriteLine($"The rent for Apartment {apartmentNumber[0]}{apartmentNumber[1]} is currently set at ${rentCost} per month.");
                Console.WriteLine($"If you would like to schedule a tour, please fill out the following application and return it within the next {timeLimit} buisness days.\n");
            }
            else
            {

                Console.WriteLine($"Currently there are 0 units available with {bedroomNumber} bedrooms available. We apologize for the inconvience. Please either adjust the number of bedrooms or check back later for potential listenings to open up.\n");
            }

            Console.WriteLine($"Thank you for your interest in {apartmentName}.");

        }
    }
}