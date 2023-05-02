using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.ContentContext;

namespace course_baltaio
{
    public class Program
    {
         static void Main (string[] args)
        {
            Console.WriteLine("Test");
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            foreach(var item in course.Modules)
            {
                
            }

        }
    }
}