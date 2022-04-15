using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static UserRegistrationProblem.CustomeException;

namespace UserRegistrationProblem
{
    public class UserRegister
    {

        // Static Variable
        private string msg;

        public UserRegister(string msg)
        {
            this.msg = msg;
        }

        public string FirstName(string name1)
        {
            string FirstName = "^[A-Za-z]\\w{1,10}$$";
            Regex regex = new Regex(FirstName);
            try
            {
                if (regex.IsMatch(name1))
                {
                    Console.WriteLine(name1 + " is valid name");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(name1 + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException ex) { throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid"); }
        }
        public string LastName(string name2)
        {
            string LastName = "^[A-Za-z]\\w{1,10}$$";
            Regex regex = new Regex(LastName);

            try
            {
                if (regex.IsMatch(name2))
                {
                    Console.WriteLine(name2 + " is valid name");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(name2 + " is invalid. Please Enter First name start with capital letter and maximum 10 charactors");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
        public string Email(string name3)
        {
            string Email = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)*[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            Regex regex = new Regex(Email);

            try
            {


                if (regex.IsMatch(name3))
                {
                    Console.WriteLine(name3 + " is valid name");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(name3 + " is invalid.");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
        public string MobileNumber(string name4)
        {
            string MobileNumber = "(0|91)?[ ][6-9][0-9]{9}";
            Regex regex = new Regex(MobileNumber);

            try
            {

                if (regex.IsMatch(name4))
                {
                    Console.WriteLine(name4 + " is valid name");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(name4 + " is invalid.");
                    return "Invalid";
                }

            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
        public string Password(string name5)
        {
            string Password = "^.*(?=.{8,})(?=.*)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*";
            Regex regex = new Regex(Password);

            try
            {

                if (regex.IsMatch(name5))
                {
                    Console.WriteLine(name5 + " is valid name");
                    return "Valid";
                }
                else
                {
                    Console.WriteLine(name5 + " is invalid.");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
    }
}