using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Core;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }
        //public DbSet Product { get; set; }
        //public DbSet Category{ get; set;}
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }       
    }
}
