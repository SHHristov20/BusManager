using BusManager.Data.Data.Contexts;
using BusManager.Data.Data.Repositories;
using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BusManager.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        private BusManagerDbContext _dbContext;
        private UserRepository _userRepository;

        [SetUp]
        public void Setup()
        {
            _dbContext = new BusManagerDbContext();
            _userRepository = new UserRepository(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
        }

        [Test]
        public async Task CreateUser_ShouldCreateUserInDatabase()
        {
            // Arrange
            var user = new User { Email = "test@example.com", FirstName = "Test", LastName = "Test", UserTypeId = 1, Password = "password123" };

            // Act
            var result = await _userRepository.CreateUser(user);

            // Assert
            Assert.IsTrue(result);

            var createdUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == "test@example.com");
            Assert.NotNull(createdUser);
            _dbContext.Users.Remove(createdUser);
            await _dbContext.SaveChangesAsync();
        }

        [Test]
        public async Task FindUserByEmail_ShouldReturnUserIfExists()
        {
            // Arrange
            var userEmail = "test@example.com";
            var user = new User { Email = userEmail, FirstName = "Test", LastName = "Test", UserTypeId = 1, Password = "password123" };
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            // Act
            var foundUser = await _userRepository.FindUserByEmail(userEmail);

            // Assert
            Assert.NotNull(foundUser);
            Assert.AreEqual(userEmail, foundUser?.Email);
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }


        [Test]
        public async Task DeleteUser_ShouldDeleteUserFromDatabase()
        {
            // Arrange
            var user = new User { Email = "test@example.com", FirstName = "Test", LastName = "Test", UserTypeId = 1, Password = "password123" };
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _userRepository.DeleteUser(user);

            // Assert
            Assert.IsTrue(result);
            var deletedUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == "test@example.com");
            Assert.Null(deletedUser);
        }
    }
}
