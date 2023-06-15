using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using course_baltaio.ContentContext.Enums;
using course_baltaio.SharedContext;

namespace course_baltaio.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public int Title { get; set; }
        public int DurationInMinutes { get; set; }

         public EContentLevel Level { get; set; }
    }
}