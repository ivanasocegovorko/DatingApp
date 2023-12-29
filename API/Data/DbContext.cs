using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set;}

    public static implicit operator ControllerContext(DataContext v)
    {
        throw new NotImplementedException();
    }
}