﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        /* UC-2-UserRegistration
             * Validate Last Name starts with Cap and have atlest 3 letters.
             */
        //Method to perform UserRegistration
        public static void UserRegistration()
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option");
                Console.WriteLine("1:First Name\n2: Last Name\n3:Enter Email-Id\n4:Enter Valid PhoneNumber\n5:Enter Password\n0=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateFirstName(firstName));
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateLastName(lastName));
                        break;
                    case 3:
                        Console.WriteLine("Enter Email ID");
                        string email = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateEmailID(email));
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateMobileNumber(mobileNumber));
                        break;
                    case 5:
                        Console.WriteLine("Enter Password");
                        string password=Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidatePassword(password));
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!");
                        break;
                    

                }
            }
        }
        //Program Entry Point
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserRegistration();
            Console.ReadLine();
        }

    }

}