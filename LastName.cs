using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class LastName
    {
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{5}$";
        public bool ValidateLastName(string Lastname)
        {
            return Regex.IsMatch(Lastname, REGEX_LASTNAME);
        }
    }
}