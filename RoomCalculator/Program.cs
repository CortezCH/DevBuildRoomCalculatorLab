using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*----------------------------------LAB SUMMARY--------------------------------------*
            *Prompt: Explain in 3 detailed steps how to get input from the user, do calculations to the
            *        input to create a new variable, then display it back to the user.
            *
            *Step 1: To get input from the user you need to use a conjunction of Console.ReadLine() and Console.Write().
            *        First you would need to use the Console.Write() to tell the user what information you need, followed by an assignment of the
            *        Console.ReadLine() command. This will effectively take whatever the user inputs and place it inside of a predefined variable.
            *        This allows you to capture, handle, and manipulate the data in whatever way you would like.
            *        
            *Step 2: For the purpose of answering this question, I will assume that you have assigned the users input to a variable of data type "string"
            *        If you want to then do calculations on the said input, parsing would be your first step. Parsing allows strings to be converted to
            *        numerical datatypes such as int, double, float, etc. simply doing a double.Parse(user's input) will transform the string into a usuable
            *        number for calculations. After you have your actual numbers, you can use your normal mathmatical operations on them to transform them into
            *        whatever you need.
            *        
            *Step 3: For displaying the outcome back to the user, you have a couple of options. For the sake of consistency, I will assume that we are
            *        still working with the numbers we received from the user on the previous step. For displaying information back to the user, you
            *        would want to use, from as few as 1, Console.WriteLine() statements. Inside the parenthesis for each Console.WriteLine() you can
            *        format the information inside of the parenthesis. Here are a couple of ways to do this:
            *          String interpolation Method (My FAVORITE):
            *              For string interpolation you want to start with double quotes proceeded by a dollar sign: $""
            *              After you have done that you can type out your sentence as usual while placeing {}'s where you would like to insert variables or
            *              mathmatical operations. For example: ($" Hello {userFirstName} {userLastName}. It's very nice weather we have today.")
            *          
            *          String Concatenation Method:
            *              for a simpler approach to displaying data back to the user, you can use string concatenation which uses a series of
            *              double quotes and plus signs. inside the parenthesis would look something like this"
            *              ( "Hello " + userFirstName + userLastName + "It's very nice weather we have today." )
            *            
            *          "I'm not sure what it's actually called so I'm going to call it magic" Method:
            *              For this method, it's very similar to string interpolation, however you are using a series of {}'s with numbers in them to denote
            *              where the variables, math, etc will go and then defining those after the string is finished.
            *              EX: ("Hello {0} {1}. It's very nice weather we have today.", userFirstName, userLastName)
            *
           */

            // Initialize variables for length, width, height, perimeter, area,
            // volume, paint amount, carpet amount, wall area, and keepgoing
            double length = 0;
            double width = 0;
            double height = 0;
            double perimeter = 0;
            double area = 0;
            double volume = 0;
            double amountOfPaint = 0;
            double amountOfCarpet = 0;
            double wallArea = 0;
            bool keepGoing = true;

            //Create a while loop to decide if you want to keepo measuring multiple rooms


            while (keepGoing)
            {
                // Ask user to input a room width and set it to width
                Console.Write("Please enter the width of the room you are measuring: ");
                double.TryParse(Console.ReadLine(), out width);

                // Ask user to input a room length and set it to length 
                Console.Write("Please enter the length of the room you are measuring: ");
                double.TryParse(Console.ReadLine(), out length);

                // Ask user to input a room height and set it to height
                Console.Write("Please enter the height of the room you are measuring: ");
                double.TryParse(Console.ReadLine(), out height);

                // Use formula to calculate perimeter of room ( 2(L+W) )
                perimeter = 2 * (length + width);
                // Use formula to calculate area of room ( L x W )
                area = length * width;
                // Use fumula to calculate volume of the room (L x W x H )
                volume = length * width * height;

                // Display room perimeter
                Console.WriteLine($"The perimeter of the room is : {perimeter}");
                // Display room area
                Console.WriteLine($"The area of the room is : {area}");
                // Display room volume
                Console.WriteLine($"The volume of the room is : {volume}");

                // Calculate the amount of paint cans needed
                wallArea = (2 * (length * height)) + (2 * (width * height)) + area;
                amountOfPaint = wallArea / 5;

                // Calculate the amount of carpet needed for the room
                amountOfCarpet = area / 5;

                // Tell the user how much paint and carpet they will need
                Console.WriteLine($"You will need {amountOfPaint} cans of paint (whole walls)," +
                    $" {perimeter / 5} cans of paint (just floor perimeter)," +
                    $" and {amountOfCarpet} squares of carpet.");

                // Update boolean varriable depending on answer
                bool invalidAnswer = true;

                do
                {
                    // Ask user if they would like to continue measuring rooms
                    Console.WriteLine();
                    Console.Write("Would you like to measure another room? (y/n): ");
                    string userAnswer = Console.ReadLine().Trim();

                    if (userAnswer.ToLower() == "y")
                    {
                        invalidAnswer = false;
                        Console.WriteLine();
                    }
                    else if (userAnswer.ToLower() == "n")
                    {
                        invalidAnswer = false;
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter wither Y or N to continue.");
                    }
                } while (invalidAnswer);


            }


        }
    }
}
