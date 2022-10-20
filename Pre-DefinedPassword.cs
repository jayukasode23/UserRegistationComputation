using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class Pre_DefinedPassword
    {
        public string REGEX_PASSWORD = "^[A-Z]{4}[a-z]{4}$";
        public bool ValidPassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);

        }
    }
}
