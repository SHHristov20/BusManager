namespace BusManager.Core.Validators
{
    public class PasswordValidator
    {
        public static string HashPassword(string password)
        {
            // Generate a salt and hash the password
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Verify the password against the hashed password
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
