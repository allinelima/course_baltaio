using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balta.ContentContext;
using course_baltaio.ContentContext;

namespace course_baltaio
{
    public class Program
    {
         static void Main (string[] args)
        {
            /*Console.WriteLine("Test");
            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Beginner;
            foreach(var item in course.Modules)
            {

            }
            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);*/

            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP" , "orientacao-objetos.com.br"));
            articles.Add(new Article("Artigo sobre C#" , "csharp.com.br"));
            articles.Add(new Article("Artigo sobre .NET" , "dotnet.com.br"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

        }
    }
}