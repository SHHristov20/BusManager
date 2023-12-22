using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BusManager.Core.Validators
{
    internal class UserValidator
    {
        public UserValidator() { }
        private static bool ValidateName(string name)
        {
            string pattern = @"^[a-zA-Z-' ]+$";

            Regex regex = new(pattern);

            return regex.IsMatch(name);
        }
        private static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new(pattern);

            return regex.IsMatch(email);
        }
        private static bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&.])[A-Za-z\d@$!%*?&.]{8,}$";

            Regex regex = new(pattern);

            return regex.IsMatch(password);
        }
        public static bool ValidateUser(string fName, string lName, string email, string password) 
        { 
            return ValidateName(fName) && ValidateName(lName) && ValidateEmail(email) && ValidatePassword(password);
        }
    }
}
