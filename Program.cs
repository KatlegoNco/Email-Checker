
using System;
using System.Text.RegularExpressions;

namespace EmailCheckerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an email address: ");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                //if valid
                Console.WriteLine($"The email address entered '{email}' is valid.");
            }
            else
            {   
                //if not valid
                Console.WriteLine($"The email address entered '{email}' is not valid.");
            }

            Console.ReadLine();
        }

         static bool IsValidEmail(string email)
        {
            // Regular expression pattern for email validation
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            // Check if the email matches the pattern
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
