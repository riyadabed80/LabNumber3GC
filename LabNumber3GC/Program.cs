using System;

namespace LabNumber3GC
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserInput;
            bool UserContinue = true;

            while (UserContinue == true)
            {
                Console.WriteLine("Please enter your first name:");
                string FirstName = (Console.ReadLine());
                    Console.WriteLine("Please enter a whole number between 1 and 100");
                UserInput = int.Parse(Console.ReadLine());

                if (UserInput < 1 || UserInput > 100)
                {
                    Console.WriteLine("Remember " + FirstName + ", the number needs to be between 1 and 100");
                }

                else if (UserInput % 2 == 0 && UserInput <= 25)
                {
                    Console.WriteLine(FirstName + ", " + UserInput + " is even and less than 25");
                }
                else if (UserInput % 2 == 0 && UserInput >= 26 && UserInput <= 60)
                {

                    Console.WriteLine(FirstName + ", even");
                }
                else if(UserInput % 2 == 0 && UserInput >=60)
                    {
                    Console.WriteLine(FirstName + ", " + UserInput + " is even");
                }
                else
                {
                    Console.WriteLine(FirstName + ", " + UserInput + " is odd");
                }

                Console.WriteLine("Do you want to try again, " + FirstName + "? y/n");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "no" || choice.ToLower() == "n")
                {
                    UserContinue = false;
                }
            }



        }

    }
}
