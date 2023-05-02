using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_baltaio.ContentContext
{
    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public int Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}
