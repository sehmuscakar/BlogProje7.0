using BlogProjeCore7._0.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogProjeCore7._0.Controllers
{
    public class PostsController : Controller
    {
        // İçerik Arama ve Filtreleme Sayfası için yaptık bu controllerı 
        private readonly DatabaseContext _context;

        public PostsController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _context.Posts.ToListAsync() ;//yukardaki async sil ve await yaz uyarıya bas otomatik yapar async yi
            return View(model);
        }

        public async Task<IActionResult> SearchAsync(string keklime)
        {
            var model = await _context.Posts.Where(p=>p.Name.Contains(keklime)).ToListAsync();
            return View(model);
        }
        public async Task<IActionResult> Details(int id)
        {
            var model = await _context.Posts.FindAsync(id);
            return View(model);
        }
    }
}
