using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BusManager.Core.Interfaces;

namespace BusManager.Core.Implementations
{
    internal class UserService : IUserService
    {
        public UserService() { }
        public bool Login(string username, string password) { return false; }
        public bool Register(string fName, string lName, string email, string password) {  return false; }
        public bool IsEmailAvailable(string email) { return false; }
        public bool PasswordValid(string password) { return false; }
    }
}
