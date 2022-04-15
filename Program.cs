using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program \n");

            UserRegister p = new UserRegister("msg");

            Console.WriteLine("Write your name using 1st character should be Capital ");
            Console.Write("\n Enter First Name : ");
            string name1 = Console.ReadLine();
            p.FirstName(name1);

            Console.WriteLine("\n Write your name using 1st character should be Capital ");
            Console.Write("\n Enter Last Name : ");
            string name2 = Console.ReadLine();
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> UC2_EnterValidLastName
=======

>>>>>>> UC2_EnterValidLastName
        }
    }
}