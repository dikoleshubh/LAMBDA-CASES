using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class Program
    {
        static void Main(string[] args)
        {

            ////
            Name ver = new Name();
            MailVerification ver1 = new MailVerification();
            Password ver2 = new Password();

            Console.WriteLine("------Welcome to Regular expression----- ");

            Console.WriteLine("Enter your First name");
            string firstname = Console.ReadLine();
            ver.firstname(firstname);

            Console.WriteLine("Enter your last name");
            string Lastname = Console.ReadLine();
            ver.Lastname(Lastname);

            Console.WriteLine("Enter your EmailID");
            string emailID = Console.ReadLine();
            ver1.verificationemail(emailID);

            Console.WriteLine("Enter your Password");
            string passwordID = Console.ReadLine();
            ver2.passwordvarification(passwordID);






        }
    }
}
