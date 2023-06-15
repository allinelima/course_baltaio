using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course_baltaio.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
           
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
        
    }
}