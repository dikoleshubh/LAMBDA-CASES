using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class Number
    {
        static string num = "^(0/91)?[7-9][0-9]{9}$";
        Regex numbers = new Regex(num);
        public void number(string phonenumber)
        {
            if (numbers.IsMatch(phonenumber)) //// phone number Validation Check
            {
                Console.WriteLine("Number Is Valid");
            }
            else
            {
                Console.WriteLine("First Name Is Invalid");
            }
        }
    }
}
