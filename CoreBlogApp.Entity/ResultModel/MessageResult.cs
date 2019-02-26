using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBlogApp.Entity.ResultModel
{
    public class MessageResult<T> where T : class
    {
        public T Result { get; set; }

        //errorMessages eklenecek
    }
}
