using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class UpperCase
    {
        public string REGEX_PASSWORD = "^[A-Z]{5}[a-z]{3}$";

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);


        }
    }
}