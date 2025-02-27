using System;

namespace Variables_McVey_Cason
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an intger to store a favorite number
            int favoriteNumber;
            // Booleans initialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            // Declared random float variable
            float myFloat;
            // Assigning the favoriteNumber to 17
            favoriteNumber = 17;
            // Assigning myFloat to 55.55
            myFloat = 55.55f;
            // Initializing constant finalGrade to 99.9
            const double finalGrade = 99.9;

            // Prints all variables to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}

