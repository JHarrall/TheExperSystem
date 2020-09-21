using System;

namespace The_Expert_System
{

    //*****************************************************
    //Application:  The Expert System
    //Author:       Harrall, Jason A
    //Description:  An application that has a conversation
    //              and calulates the cost of flooring
    //Date Created: 9/20/2020
    //Date Revised: 9/20/2020
    //*****************************************************

    class Program
    {
        static void Main(string[] args)
        {

            //
            // Set Console Colors
            //

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            //
            // Variables
            //

            string userName;
            string userResponse;
            string userRooms;

            double lengthOne;
            double widthOne;
            double costOne;
            double lengthTwo;
            double widthTwo;
            double costTwo;
            double Cost;

            bool validResponse;

            //
            //Program intro
            //

            Console.WriteLine();
            Console.WriteLine("Room Cost Calulator.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.WriteLine();
            Console.ReadKey();

            //
            //Greet and ask for name
            //

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            Console.WriteLine();
            userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + userName + ".");
            Console.WriteLine();
            Console.WriteLine("Would you like to calulate the cost of flooring two rooms?");
            Console.WriteLine();
            userResponse = Console.ReadLine();

            //
            //Start asking for measurments
            //

            if (userResponse == "yes")
            {

                Console.WriteLine();
                Console.WriteLine("Luckily I can help with that!");
                Console.WriteLine();
                Console.WriteLine("What rooms will you be reflooring?");
                Console.WriteLine();
                userRooms = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("So you will be reflooring " + userRooms + ", Good choice!");
                Console.ReadKey();

                do
                {

                    validResponse = true;

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Lets get some numbers for the rooms.");
                    Console.WriteLine();
                    Console.WriteLine("What is the length of room one in feet?");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out lengthOne))
                    {

                        validResponse = false;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();

                    }

                } while (!validResponse);

                do
                {

                    validResponse = true;

                    Console.WriteLine();
                    Console.WriteLine("What is the width of room one in feet?");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();
                    if (!double.TryParse(userResponse, out widthOne))
                    {

                        validResponse = false;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();

                    }

                } while (!validResponse);

                do
                {

                    validResponse = true;

                    Console.WriteLine();
                    Console.WriteLine("What is the cost of flooring per square foot in room one in dollars?");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out costOne))
                    {

                        validResponse = false;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();

                    }
                } while (!validResponse);

                do
                {

                    validResponse = true;

                    Console.WriteLine();
                    Console.WriteLine("What is the length of the seconde room in feet?");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out lengthTwo))
                    {

                        validResponse = false;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();

                    }

                } while (!validResponse);

                do
                {

                    validResponse = true;

                    Console.WriteLine();
                    Console.WriteLine("What is the width of the second room in feet?");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out widthTwo))
                    {

                        validResponse = false;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();

                    }

                } while (!validResponse);

                do
                {

                    validResponse = true;

                    Console.WriteLine();
                    Console.WriteLine("What is the cost of flooring per square foot in room two in dollars?");
                    Console.WriteLine();
                    userResponse = Console.ReadLine();

                    if (!double.TryParse(userResponse, out costTwo))
                    {

                        validResponse = false;

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid Number");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();

                    }

                    Cost = widthOne * lengthOne * costOne + widthTwo * lengthTwo * costTwo;

                    break;

                } while (!validResponse);

                if (Cost > 0)
                {

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Your total cost will be $" + Cost + "");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                }

            }
            
            else
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Sorry to hear that you arent getting new floors");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Thanks for using my program");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}

