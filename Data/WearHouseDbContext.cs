using Microsoft.EntityFrameworkCore;
using WearHouse.Model;

namespace WearHouse.Data;

public class WearHouseDbContext : DbContext
{
    public WearHouseDbContext(DbContextOptions<WearHouseDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Category{ get; set; }
    public DbSet<User> Users { get; set; }
}

