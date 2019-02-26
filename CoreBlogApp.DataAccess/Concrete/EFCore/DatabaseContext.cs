using CoreBlogApp.Entity.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlogApp.DataAccess.Concrete.EFCore
{
    public class DatabaseContext : DbContext
    {

        //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        //{

        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SINAN-PC;Database=BlogAppDb; Trusted_Connection=true");
        }
        //Server=(localdb)\MSSQLLocalDB;Database=eCommerceDb; Trusted_Connection=true

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
