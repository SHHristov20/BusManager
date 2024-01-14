using BusManager.Core.Interfaces;
using BusManager.Core.Validators;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
using static BusManager.Core.Validators.UserValidator;
using BusManager.Core.Helpers.Exceptions;

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
            if(string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(password)) { throw new Exception("Please fill this field!"); }
            User user = await _userRepository.FindUserByEmail(email) ?? throw new UserNotExistException();
            if (!PasswordValidator.VerifyPassword(password, user.Password)) throw new PasswordNotMatchingException();
            return user;
        }
        public async Task<bool> Register(string fName, string lName, string email, string password, string repeatPassword) 
        {
            List<Exception> exceptions = new();
            if(!ValidateName(fName)) { exceptions.Add(new InvalidFirstNameException()); }
            if(!ValidateName(lName)) { exceptions.Add(new InvalidLastNameException()); }
            if(!ValidateEmail(email)) { exceptions.Add(new InvalidEmailException()); }
            if(!ValidatePassword(password)) { exceptions.Add(new InvalidPasswordException()); }
            if(!PasswordsMatch(password, repeatPassword)) { exceptions.Add(new PasswordNotMatchingException()); }
            if(!await IsEmailAvailable(email)) { exceptions.Add(new EmailInUseException()); }
            if (exceptions.Any()) { throw new AggregateException("Invalid fields!", exceptions); }
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
