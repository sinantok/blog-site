using CoreBlogApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CoreBlogApp.Core.DataAccess
{

    public interface IEntityRepository<T> where T : class, IEntitiy, new() //Ientity ile ilgili nesne sadece bir db nesnesi olabilir
    {//ayrıca new() parametresi ile bu Interface sadece new'lenebilir bir class ile generik almalı

        T GetById(Expression<Func<T, bool>> where);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        int Insert(T obj);

        int Update(T obj);

        int Delete(T obj);

    }
}
