using Microsoft.EntityFrameworkCore;
using RetrospectiveWebAPI.Models;

namespace RetrospectiveWebAPI.Entities
{
    /// <summary>
    /// Repository context class
    /// </summary>
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User>? Users { get; set; }
    }
}
