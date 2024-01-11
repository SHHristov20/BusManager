using BusManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Core.Interfaces
{
    public interface IUserService
    {
        Task<User> Login(string email, string password);
        Task<bool> Register(string fName, string lName, string email, string password, string repeatPassword);
        Task<bool> IsEmailAvailable(string email);
    }
}
