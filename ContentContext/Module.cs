using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course_baltaio.SharedContext;

namespace course_baltaio.ContentContext
{
    public class Module : Base
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
