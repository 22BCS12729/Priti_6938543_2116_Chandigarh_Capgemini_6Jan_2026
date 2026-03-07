using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordValidate
{
    internal class PassValidate
    {
        public static int ValidatePassword(string pwd)
        {
            if (pwd.Length < 8)
                return -1;

            if (!char.IsLetter(pwd[0]))
                return -1;

            if (!char.IsLetterOrDigit(pwd[pwd.Length - 1]))
                return -1;

            if (!Regex.IsMatch(pwd, @"[@#_]"))
                return -1;

            if (!Regex.IsMatch(pwd, @"[A-Za-z]"))
                return -1;

            if (!Regex.IsMatch(pwd, @"\d"))
                return -1;

            return 1;
        }

    }
}
