using Microsoft.EntityFrameworkCore;

namespace EjadHR_API.Models
{
    public class EmpDetailContext : DbContext
    {
        public EmpDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmpDetails> EmpDetails { get; set; }
       
    }
}
