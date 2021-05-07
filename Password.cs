using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class Password
    { /// <summary>
      /// PASSWORD CONDTION -min - 8 Characters,1 Upper Case,1 numerical variable.
        /// </summary>
        static string password = "^(?=.*[a - z])(?=.*[A - Z])(?=.*)(?=.*[^a - zA - Z]).{8,15}$";  

        
        Regex regexEmail = new Regex(password);//REGULAR EXPRESSION
        public void passwordvarification(string passwordID)
        {
            if (regexEmail.IsMatch(passwordID))
            {
                Console.WriteLine("Password Is  Valid");
            }
            else
            {
                Console.WriteLine("Password Is  Invalid");
            }
        }
    }

}
