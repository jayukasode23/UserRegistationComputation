using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class SpecialCharacter
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z]{4}[0-9]{2}['@'][A-Z]{1}[a-z]{2}[0-7]{2}$";
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, REGEX_PASSWORD);

        }
    }
}
