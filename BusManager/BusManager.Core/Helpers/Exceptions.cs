using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Core.Helpers
{
    namespace Exceptions
    {
        class InvalidFirstNameException : Exception
        {
            public InvalidFirstNameException() : base("First name must be in English!") { }
        }
        class InvalidLastNameException : Exception
        {
            public InvalidLastNameException() : base("Last name must be in English!") { }
        }
        class InvalidEmailException : Exception 
        {
            public InvalidEmailException() : base("Invalid email address!") { }
        }
        class EmailInUseException : Exception
        {
            public EmailInUseException() : base("Email address already in use!") { }
        }
        class InvalidPasswordException : Exception
        {
            public InvalidPasswordException() : base("Password must contain atleast 8 characters!") { }
        }
        class PasswordNotMatchingException : Exception
        {
            public PasswordNotMatchingException() : base("Passwords must match!") { }
        }
        class UserNotExistException : Exception
        {
            public UserNotExistException() : base("User doesn't exist!") { }
        }
    }
}
