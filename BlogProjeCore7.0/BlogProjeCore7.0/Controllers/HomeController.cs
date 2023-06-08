using BlogProjeCore7._0.Data;
using BlogProjeCore7._0.Entites;
using BlogProjeCore7._0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogProjeCore7._0.Controllers
{
    public class HomeController : Controller
    {
        //sabit sayfaları home controllera ekle 
        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        //postaki kayıtları listeler
        public IActionResult Index()
        {
            var model = _context.Posts.ToList();//Take(4) :son 4 kaydı getirir
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Hakkimda")]
        public IActionResult About()//satatik
        {
            return View();
        }

        [Route("iletisim")]  // layouta href te iletisim yazdığı için bu routu gürdüğü için direk bu actionun içine girecek
        public IActionResult ContactUs()//iletiişm
        {
            return View();
        }

        [Route("iletisim"),HttpPost]
        public IActionResult ContactUs(Contact contact)
        {
            try
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                TempData["Message"] = "<div class='alert alert-success'> Mesajınız Gönderildi. Teşekkürler..</div>";
                return RedirectToAction("ContactUs");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "hata oluştu!");
            
            }

            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}