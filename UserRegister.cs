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
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{1,}$";
        //Method to Validate First Name
        public static string ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, firstNamePattern))
                return "Valid";
            else
                return "InValid";
        }
    }
}
