﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ReX
{
    class MailVerification
    {
        static string email = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        Regex regexEmail = new Regex(email);

        public  void verificationemail(string emailID)
        {
            if (regexEmail.IsMatch(emailID))
            {
                Console.WriteLine("Email Is  Valid");
            }
            else
            {
                Console.WriteLine("Email Is  Invalid");
            }

        }
    }
}
