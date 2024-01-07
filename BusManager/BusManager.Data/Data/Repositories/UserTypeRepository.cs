using BusManager.Data.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
