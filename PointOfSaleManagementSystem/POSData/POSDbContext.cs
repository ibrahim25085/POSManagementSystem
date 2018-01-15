using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POSEntity.Model.SetupFile;

namespace POSData
{
    public class POSDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategoris { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Outlet> Outlets { get; set; }
        public DbSet<Party> Parties { get; set; }
    }
}
