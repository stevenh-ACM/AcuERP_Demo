#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using AcuERP_Demo.Models;


namespace AcuERP_Demo.Data;

public class AppDbContext : IdentityDbContext<DemoUser>
{
    public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
    {  }

    public DbSet<AcuAuth> AcuAuths { get; set; }
    public DbSet<DemoUser> DemoUser { get; set; }
    public DbSet<AP_Bill> AP_Bills { get; set; }
    public DbSet<CR_Case> CR_Cases { get; set; }
    public DbSet<CR_Contact> CR_Contacts { get; set; }
    public DbSet<OP_Opportunity> OP_Opportunities { get; set; }
    public DbSet<SO_Shipment> SO_Shipments { get; set; }
    public DbSet<SO_SalesOrder> SO_SalesOrders { get; set; }

}
