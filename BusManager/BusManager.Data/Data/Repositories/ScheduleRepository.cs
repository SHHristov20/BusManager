using BusManager.Data.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Data.Data.Repositories
{
    public class ScheduleRepository
    {
        private readonly BusManagerDbContext _dbContext;
        public ScheduleRepository(BusManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
