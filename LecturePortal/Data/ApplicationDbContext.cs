using LecturePortal.Models;
using Microsoft.EntityFrameworkCore;

namespace LecturePortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LeadEntity> leadEntities { get; set; }
    }
}
