using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class UserRegister
    {
        // Static Variable
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{1,}";
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{1,}";
        public static string emailPattern = "^[a-zA-z0-9]+([.]*[a-zA-Z0-9])+[@]([a-z]{3,})+([.][a-z]{2,3})$";
        public static string mobilePattern = "^([9][1])[ ]*[6-9]{1}[0-9]{9}$";
        public static string ValidatePattern(string userInput, string pattern)
        {
            if (Regex.IsMatch(userInput, pattern))
                return "Valid";
            else
                return "InValid";
        }
        //Method to Validate First Name
        public static string ValidateFirstName(string name)
        {
            var firstNameMatch = ValidatePattern(name, firstNamePattern);
            return firstNameMatch;
        }
        //Method to Validate Last Name
        public static string ValidateLastName(string name)
        {
            var firstNameMatch = ValidatePattern(name, firstNamePattern);
            return firstNameMatch;
        }
        //Method to Validate Email-Id
        public static string ValidateEmailID(string mail)
        {
            var mailMatch = ValidatePattern(mail, emailPattern);
            return mailMatch;
        }
        public static string ValidateMonileNumber(string moblienumber)
        {
            var moblienumberMatch = ValidatePattern(moblienumber, mobilePattern);
            return moblienumberMatch;
        }
    }
}
