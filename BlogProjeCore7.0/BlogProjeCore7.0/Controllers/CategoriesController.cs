using BlogProjeCore7._0.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogProjeCore7._0.Controllers
{
    //Kategoriye Göre İçerik Gösterimi yapacaz bu controllerda
    //viewcomponenteki categories te bu actionun yolunu verceen
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            //  var model=_context.Categories.Find(id);
            var model = _context.Categories.Include(p => p.Posts).FirstOrDefault(c => c.Id == id);//Include(p => p.Posts) post verilerini de bu modele dahil et yani
            return View(model);
        }
    }
}
