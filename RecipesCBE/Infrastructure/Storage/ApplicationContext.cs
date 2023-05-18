using Domain.Models.Users;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Storage
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions options )
            : base( options )
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            builder.ApplyConfiguration( new UserConfiguration() );
        }
    }
}
