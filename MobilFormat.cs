using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class MobilFormat
    {
        public string REGEX_MOBILEFORMAT = "^[91]{2}[\\s][8-9]{1}[0-9]{9}$";
        public bool ValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, REGEX_MOBILEFORMAT);
        }
    }
}
