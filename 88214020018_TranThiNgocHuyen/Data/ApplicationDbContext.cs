using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using _88214020018_TranThiNgocHuyen.Models;

namespace _88214020018_TranThiNgocHuyen.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } = default!;
        public DbSet<Genre> Genres { get; set; } = default!;
    }
}