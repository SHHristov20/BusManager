using BusManager.Core.Interfaces;
using BusManager.Core.Validators;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
using static BusManager.Core.Validators.UserValidator;

namespace BusManager.Core.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Login(string email, string password) 
        {
            if(string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(password)) { throw new Exception("Please fill all fields"); }
            User user = await _userRepository.FindUserByEmail(email) ?? throw new Exception("User does not exist");
            if (!PasswordValidator.VerifyPassword(password, user.Password)) throw new Exception("Invalid password");
            return user;
        }
        public async Task<bool> Register(string fName, string lName, string email, string password, string repeatPassword) 
        {
            List<Exception> exceptions = new();
            if(!ValidateName(fName)) { exceptions.Add(new ArgumentException("First name must be in English")); }
            if(!ValidateName(lName)) { exceptions.Add(new ArgumentException("Last name must be in English")); }
            if(!ValidateEmail(email)) { exceptions.Add(new ArgumentException("Invalid email address")); }
            if(!ValidatePassword(password)) { exceptions.Add(new ArgumentException("Password must contain at least 8 characters")); }
            if(!PasswordsMatch(password, repeatPassword)) { exceptions.Add(new ArgumentException("Passwords must match")); }
            if(!await IsEmailAvailable(email)) { exceptions.Add(new ArgumentException("Email already in use")); }
            if (exceptions.Any()) { throw new AggregateException("Error", exceptions); }
            string passwordHash = PasswordValidator.HashPassword(password);
            User user = new()
            {
                FirstName = fName,
                LastName = lName,
                Email = email,
                Password = passwordHash,
                UserTypeId = 1

            };
            return await _userRepository.CreateUser(user);

        }
        public async Task<bool> IsEmailAvailable(string email) 
        {
            return await _userRepository.FindUserByEmail(email.ToLower()) == null;
        }
    }
}
