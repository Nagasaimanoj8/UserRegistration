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



    }
}