using BusManager.Data.Data.Contexts;

namespace BusManager.Data.Data.Repositories
{
    public class UserTypeRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public UserTypeRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
