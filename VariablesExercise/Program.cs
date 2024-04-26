using System.ComponentModel.Design;

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string apartmentName = "TrueCoders Apartments";
            int numberOfUnits = 1;
            char[] apartmentNumber = { '2', 'B'};
            bool vacancy = true;
            decimal rentCost = 1200.99m;
            double timeLimit = 10;



            Console.WriteLine($"Welcome to {apartmentName}!\n");
            
                if (vacancy == true)
                { 
                    Console.WriteLine($"We have {numberOfUnits} unit(s) currently available. The vacancy is apartment number {apartmentNumber[0]}{apartmentNumber[1]}.");
                    Console.WriteLine($"The rent for Apartment {apartmentNumber[0]}{apartmentNumber[1]} is currently set at ${rentCost} per month.");
                    Console.WriteLine($"If you would like to schedule a tour, please fill out the following application and return it within the next {timeLimit} buisness days.\n");
                }
                else if (vacancy == false)
                {

                    Console.WriteLine("Currently there are 0 units available. We apologize for the inconvience. Please check back later for potential listenings to open up.\n");
                }
            
            Console.WriteLine($"Thank you for your interest in {apartmentName}.");

        }
    }
} 