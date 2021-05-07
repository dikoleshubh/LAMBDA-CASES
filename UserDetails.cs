using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace ReX
{
    class UserDetails
    {
        public static bool PatternValidation(String input, String pattern)
        {

            Regex regex = new Regex(pattern);  //create object of the Regex class (its Regesx predefine class)
            bool match = regex.IsMatch(input) ? true : throw new InvalidDataException("Invalid");
            return match;

        }
        public static bool CustomexceptionsPatternValidation(String input, String pattern)
        {

            Regex regex = new Regex(pattern);  //create object of the Regex class (its Regesx predefine class)
            bool match = regex.IsMatch(input) ? true : throw new InvalidDataException("Invalid User Details");
            return match;

        }
    }
}
