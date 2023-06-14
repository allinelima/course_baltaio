using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.ContentContext;
using course_baltaio.ContentContext;

namespace course_baltaio
{
     class Program
    {
         static void Main (string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos.io"));
            articles.Add(new Article("Artigo sobre C#", "csharp.io"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet.io"));

            foreach(var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop.io");
            var courseCsharp = new Course("C#", "fundamentos-csharp.io");
            var courseAspNet = new Course("ASP .Net", "fundamentos-aspdotnet.io");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);

            foreach(var career in careers){
                Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}