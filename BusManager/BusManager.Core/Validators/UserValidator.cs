using System.Text.RegularExpressions;

namespace BusManager.Core.Validators
{
    internal class UserValidator
    {
        public UserValidator() { }
        public static bool ValidateName(string name)
        {
            string pattern = @"^[a-zA-Z-' ]+$";

            Regex regex = new(pattern);

            return regex.IsMatch(name);
        }
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Regex regex = new(pattern);

            return regex.IsMatch(email);
        }
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^.{8,}$";

            Regex regex = new(pattern);

            return regex.IsMatch(password);
        }
        public static bool PasswordsMatch(string password, string repeatPassword)
        {
            return password == repeatPassword;
        }
    }
}
