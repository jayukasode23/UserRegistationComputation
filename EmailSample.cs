using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class EmailSample
    {
        public static string REGEX_EMAIL = "^[a-z]{4}[a-z]{6}[0-9]{4}['@'][a-z]{5}['.'][a-z]{3}$";
        public bool ValidateEmailAdd(string Email)
        {
            return Regex.IsMatch(Email, REGEX_EMAIL);

        }
    }
}