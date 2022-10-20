using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class NumberPassword
    {
        public string REGEX_PASSWORD = "^[A-Z]{1}[0-9]{8}$";

        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);


        }
    }
}
