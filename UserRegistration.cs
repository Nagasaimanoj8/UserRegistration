using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegistration
    {
        public static bool NameValidation(String firstName)
        {
            String pattern = "^[A-Z]{1}[a-z]{2,}$";  //Define Pattern
            Regex regex = new Regex(pattern);      //create object of the Regex class (its Regesx predefine class)
            return regex.IsMatch(firstName);         //match in a specified input string
        }
        static void Main(string[] args)    //Main Method
        {
            Console.WriteLine("Welcome to User Registration!");   //Print message             

            Console.WriteLine("Enter the First Name"); //Take user input
            String firstName = Console.ReadLine();     //Store input string veriable
            if (NameValidation(firstName))           //Check firstname NameValidation method
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }

            Console.WriteLine("\nEnter the Last Name"); // Take user input
            String lastName = Console.ReadLine();             //Store input string veriable

            if (NameValidation(lastName))             //Check lastName NameValidation method
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }

        }
    }

}