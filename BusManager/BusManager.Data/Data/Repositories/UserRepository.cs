using BusManager.Data.Data.Contexts;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
        public async Task<List<User>> GetAllUsers()
        {
            return await _dbContext.Users
                .Include(u => u.UserType)
                .OrderBy(u => u.UserType.Name)
                .ToListAsync();
        }
        public async Task<bool> DeleteUser(User user)
        {
            try
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> ChangeUserType(User user, int userTypeId)
        {
            try
            {
                user.UserTypeId = userTypeId;
                _dbContext.Update(user);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
