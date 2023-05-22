using AssignmentMvcEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentMvcEntity.Context
{
    public class InventoryDbContext: DbContext
    {
        public InventoryDbContext()
        {
            
        }
        public InventoryDbContext(DbContextOptions<InventoryDbContext> options): base(options) { }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<AssignmentMvcEntity.Models.InventoryViewModel>? InventoryViewModel { get; set; }
    }
}
