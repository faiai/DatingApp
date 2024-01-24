using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) //base class where we are deriving from
    {
    }

    public DbSet<AppUser> Users {get; set;}
}
