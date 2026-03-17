using Interview_FollowUp_Core.Service.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Interview_FollowUp_Core.Service.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Interview> Interviews { get; set; }
    }
}
