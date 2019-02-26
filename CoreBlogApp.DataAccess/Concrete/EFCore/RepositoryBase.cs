using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlogApp.DataAccess.Concrete.EFCore
{
    public class RepositoryBase
    {
        protected static DatabaseContext context;

        protected RepositoryBase()
        {
            CreateContext();
        }

        private static object LockSync = new object();

        private static void CreateContext()
        {
            if (context == null)
            {
                lock (LockSync)
                {
                    if (context == null)
                    {
                        context = new DatabaseContext(); //even in multi-use structures only 1 context 
                    }
                }
            }
        }
    }
}
