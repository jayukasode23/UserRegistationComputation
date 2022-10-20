using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class FirstName
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{3}$";
        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }
    }
}
