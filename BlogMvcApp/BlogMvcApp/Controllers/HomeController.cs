using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                .Select(a => new BlogModel()
                {
                    Id = a.Id,
                    Title = a.Title.Length>100 ? a.Title.Substring(0, 100)+"..." : a.Title,
                    Explanation=a.Explanation,
                    DateOfUpload=a.DateOfUpload,
                    HomePage=a.HomePage,
                    Approval=a.Approval,
                    Picture=a.Picture

                })
           .Where(i => i.Approval==true && i.HomePage==true);
            return View(blogs.ToList());
        }
    }
}