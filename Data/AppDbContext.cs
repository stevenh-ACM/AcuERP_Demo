#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using AcuERP_Demo.Models;

namespace AcuERP_Demo.Data
{
    public class AppDbContext : IdentityDbContext<DemoUser>
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {  }

        public DbSet<AcuAuth> AcuAuths { get; set; }

        public DbSet<DemoUser> DemoUser { get; set; }
    }
}
