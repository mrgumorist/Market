using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Entitis
{
    public class Context : DbContext
    {
        public Context() : base("Model1")
        {

        }
        public DbSet<Product> product { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<ProductsHistory> prodHistory { get; set; }
        public DbSet<User> users { get; set; }
    }
}

