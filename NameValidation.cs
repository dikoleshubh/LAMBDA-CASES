using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class UserName     ////User Name verification   
    {
        static string Names = "^[A-Z]{1}[a-z]{3}$"; //// Condtions to be checked for Ideal Name. i.e. UPPER CASE & LOWER CASE
        Regex regexName = new Regex(Names); //// Regex Declaration

        public void Firstname(string firstname)
        {
            if (regexName.IsMatch(firstname)) //// First Name Validation Check
            {
                Console.WriteLine("First Name Is Valid");
            }
            else
            {
                Console.WriteLine("First Name Is Invalid");
            }
        }
        public void Lastname(string lastname)
        {
            if (regexName.IsMatch(lastname)) //// Last Name Validation Check
            {
                Console.WriteLine("Last Name Is  Valid");
            }
            else
            {
                Console.WriteLine("Last Name Is  Invalid");
            }
        }

    }

}