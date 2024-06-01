using Inventory_Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<LocationInfo> LocationInfo { get; set; }
    }
}
