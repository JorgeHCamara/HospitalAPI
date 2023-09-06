
using Microsoft.EntityFrameworkCore;

namespace HospitalAPI.Persistence
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }
    }
}
