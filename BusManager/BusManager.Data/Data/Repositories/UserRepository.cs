using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Data.Data.Repositories
{
    public class UserRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public UserRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateUser(User user)
        {
            try
            {
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<User?> FindUserByEmail(string email)
        {
            return await _dbContext.Users
                .Where(u => u.Email == email)
                .FirstOrDefaultAsync();
        }
    }
}
