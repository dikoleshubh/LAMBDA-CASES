using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq; 

namespace ReX
{
    class Name     ////User Name verification   
    {
        static string name = "^[A-Z]{1}[a-z]{3}$"; //// Condtions to be checked for Ideal Name. i.e. UPPER CASE & LOWER CASE
        Regex regexName = new Regex(name); //// Regex Declaration

        public void firstname(string firstname)
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
        public void Lastname(string Lastname)
        {
            if (regexName.IsMatch(Lastname)) //// Last Name Validation Check
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
