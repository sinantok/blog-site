using CoreBlogApp.Business.Abstract;
using CoreBlogApp.DataAccess.Abstract;
using CoreBlogApp.Entity.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBlogApp.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public int Delete(Blog obj)
        {
            return _blogDal.Delete(obj);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetList();
        }

        public List<Blog> GetAllHomePage()
        {
            return _blogDal.GetList(i => i.IsApproved && i.IsHome).OrderByDescending(x => x.Date).ToList();
        }

        public List<Blog> GetAllIsApproved()
        {
            return _blogDal.GetList(x => x.IsApproved).OrderByDescending(x => x.Date).ToList();
        }

        public List<Blog> GetAllSlider()
        {
            return _blogDal.GetList(i => i.IsApproved && i.IsSlider).OrderByDescending(x => x.Date).ToList();
        }

        public List<Blog> GetBlogByCategory(int id)
        {
            return _blogDal.GetList(x => x.IsApproved && x.CategoryId == id).OrderByDescending(x => x.Date).ToList();
        }

        public List<Blog> GetBlogBySearcBox(string q)
        {
            return _blogDal.GetList(x =>
                EF.Functions.Like(x.Title, "%" + q + "%") ||
                EF.Functions.Like(x.Description, "%" + q + "%") ||
                EF.Functions.Like(x.Body, "%" + q + "%")).
                Where(x => x.IsApproved).
                OrderByDescending(x => x.Date).ToList();
        }

        public Blog GetById(int id)
        { 
            return _blogDal.GetById(x => x.BlogId == id);
        }

        public int Insert(Blog obj)
        {
            return _blogDal.Insert(obj);
        }

        public int Update(Blog obj)
        {
            return _blogDal.Update(obj);
        }
    }
}
