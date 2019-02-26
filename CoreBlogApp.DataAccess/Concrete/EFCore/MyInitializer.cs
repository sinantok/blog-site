using CoreBlogApp.Entity.DbEntities;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBlogApp.DataAccess.Concrete.EFCore
{
    public static class MyInitializer
    {
        public static void Seed(IApplicationBuilder app )
        {
            //DatabaseContext context = app.ApplicationServices.GetRequiredService<DatabaseContext>();
            DatabaseContext context = new DatabaseContext();

            context.Database.Migrate();

            if(!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category() { Name = "Cat 1" },
                    new Category() { Name = "Cat 2" }
                    );
                context.SaveChanges();
            }

            if(!context.Blogs.Any())
            {
                context.Blogs.AddRange(
                    new Blog() { Title = "Gezi", Description = "afasd", Body = "Blog Body 1", Image = "4.jpeg", Date = DateTime.Now.AddDays(-2), IsApproved = true, CategoryId = 1 },
                    new Blog() { Title = "Gezi2", Description = "afasd", Body = "Blog Body 1", Image = "5.jpeg", Date = DateTime.Now.AddDays(-1), IsApproved = false, CategoryId = 2 }
                    );
                context.SaveChanges();
            }

        }
    }
}
