using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class CustomeException
    {
        public class CustomException : Exception
        {
            public ExceptionType type;

            public enum ExceptionType
            {
                WRONG_FIRSTNAME, 
                WRONG_LASTNAME, 
                WRONG_EMAIL, 
                WRONG_MOBILENUMBER,
                WRONG_PASSWORD
            }
            public readonly ExceptionType type;
            public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        }
    }
}
