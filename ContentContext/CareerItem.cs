using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.ContentContext;
using course_baltaio.NotificationContext;
using course_baltaio.SharedContext;

namespace course_baltaio.ContentContext
{
   public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string description,
            Course course)
        {
            if (course == null)
                 AddNotification(new Notification("Course", "Curso inválido"));

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}