using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.ContentContext;

namespace course_baltaio.ContentContext
{
    public class CareerItem
    {
        public int Ordem { get; set; }
        public string? Title { get; set; }
        public string? Descripton { get; set; }
        public Course? Course { get; set; }
    }
}