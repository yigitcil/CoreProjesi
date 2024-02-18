using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProjesi.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();      //GetListAll'a çevrilebilir.
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
			ViewBag.i = id;
			var values = bm.GetBlogByID(id);
            return View(values);
        }
    }
}
