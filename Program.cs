using EFCORECODEFIRST.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORECODEFIRST
{
    public partial class Program
    {


        static void Main(string[] args)
        {
            RemoveBlog();
        }

        static void AddBlog()
        {
            using (var blog = new BlogDbContext())
            {
                Blog b = new() { URL = "TestURL" };
                blog.Add(b);
                blog.SaveChanges();
            }
        }

        static void UpdateBlog()
        {
            using(var blog = new BlogDbContext())
            {
                Blog b = new() { Id = 2, URL = "New2 TestURL" };
                blog.Update(b);
                blog.SaveChanges();
            }
        }

        static void GetBlog()
        {
            using (var blog = new BlogDbContext())
            {
                foreach (var item in blog.Blogs.ToList())
                {
                    Console.WriteLine(item.Id + " "+ item.URL);
                }
                
            }
        }


        static void RemoveBlog()
        {
            using (var blog = new BlogDbContext())
            {
                Blog b = new() { Id = 2};

                blog.Blogs.Remove(b);
                blog.SaveChanges();
            }
        }
    }
}
