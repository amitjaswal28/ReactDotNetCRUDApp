using Microsoft.EntityFrameworkCore;

namespace WebAPIs.Model
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options) 
        {

        }

        public DbSet<DCandidate> dCandidates { get; set; }
    }
}
