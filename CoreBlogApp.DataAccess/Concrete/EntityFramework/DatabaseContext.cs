using CoreBlogApp.Entity.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlogApp.DataAccess.Concrete.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SINAN-PC;Database=BlogAppDb; Trusted_Connection=true");
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
