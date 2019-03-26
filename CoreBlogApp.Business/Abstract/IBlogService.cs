using CoreBlogApp.Entity.DbEntities;
using CoreBlogApp.Entity.ResultModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBlogApp.Business.Abstract
{
    public interface IBlogService
    {
        Blog GetById(int id);

        List<Blog> GetAll();

        List<Blog> GetAllHomePage();

        List<Blog> GetAllSlider();

        List<Blog> GetAllIsApproved();

        List<Blog> GetBlogByCategory(int id);

        List<Blog> GetBlogBySearcBox(string q);

        int Insert(Blog obj);

        int Update(Blog obj);

        int Delete(Blog obj);
    }
}
