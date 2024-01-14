using BusManager.Data.Models;

namespace BusManager.Core.Interfaces
{
    public interface IUserService
    {
        Task<User> Login(string email, string password);
        Task<bool> Register(string fName, string lName, string email, string password, string repeatPassword);
        Task<bool> IsEmailAvailable(string email);
        Task<List<User>> GetAllUsers();
        Task<bool> DeleteUser(User user);
        Task<bool> ChangeUserType(User user, int userTypeId);
    }
}
