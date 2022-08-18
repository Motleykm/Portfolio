using System;

//Motley,Kamirah
//08/17/2022
//Course :Portfolio 1 Fundamentials of Application Development
//Synopsis :Application for people to keep track of their expenses based on their trip and area prices 

namespace TripLists
{
    public class Validation
    {

        // validates that the user string is not left blank
        public static string ValidateString(string input)
        {
            bool isValid = false;
            while (!isValid)
            {
                if (!string.IsNullOrEmpty(input))
                {
                    isValid = true;
                }
                else
                {
                    Console.Write("Invalid input. Try again ");
                    input = Console.ReadLine();
                }
            }

            return input;

        }// validate user will enter the correct password and its requirements
        public static string ValidateRegex(string input, string pattern)
        {
            Regex rg = new Regex(pattern);
            bool isvalid = false;
            while (!isvalid)
            {
                if (rg.IsMatch(input))
                {
                    isvalid = true;

                }
                else
                {
                    Console.WriteLine($"Invalid input.Should match the pattern :{pattern}.Try again ");
                    input = Console.ReadLine();
                }
            }
            return input;
        }
    }

}

   













