using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> Categories = new List<Category>()
            {
                new Category(){ CategoryName ="C#"},
                new Category(){ CategoryName ="ASP.NET MVC"},
                new Category(){ CategoryName ="ASP.NET Web Form"},
                new Category(){ CategoryName ="Windows Form"}

            };
            foreach (var item in Categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();
            List<Blog> Blogs = new List<Blog>()
            {
                new Blog(){ Title="C# Delegates Hakkında",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="1.jpg",CategoryId=1  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = false, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="1.jpg",CategoryId=1  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-30),HomePage=false, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="1.jpg",CategoryId=1  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-20),HomePage=true, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="2.jpg",CategoryId=2  },
                new Blog(){ Title="C# Generic List  ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-5),HomePage=false, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="2.jpg",CategoryId=2  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-15),HomePage=true, Approval = false, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="2.jpg",CategoryId=2  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="3.jpg",CategoryId=3  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="3.jpg",CategoryId=3  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-17),HomePage=false, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="3.jpg",CategoryId=3  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="4.jpg",CategoryId=4  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = false, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="4.jpg",CategoryId=4  },
                new Blog(){ Title="C# Delegates ",Explanation="C# Delagates C# DelagatesC# DelagatesC# DelagatesC# Delagates",DateOfUpload=DateTime.Now.AddDays(-10),HomePage=true, Approval = true, Content ="C# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# DelagatesC# Delagates",Picture="4.jpg",CategoryId=4  }

            };
            foreach (var item in Blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}