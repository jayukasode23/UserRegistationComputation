using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class ValidE_Mail
    {
        public string REGEX_EMAIL = "^[a-z]{10}[1-9]{4}@[a-z]{5}[.][a-z]{3}";

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}

