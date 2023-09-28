using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Data;
using TestCoreApp.Models;

namespace TestCoreApp.Controllers
{
    public class ItemsController : Controller
    {


        public ItemsController(AppDbContext db)
        {
            _db = db;
        }
        private readonly AppDbContext _db;


        public IActionResult Index()
        {
            IEnumerable<Item> itemsList = _db.Item.ToList();
            return View(itemsList);
        }

        //
        public IActionResult New()
        {
            return View();
        }
        
        
        
        //POST New
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Item item)
        {
           
            if (ModelState.IsValid)
            {
                _db.Item.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(item);
            }
        }




        //post  Edit

        [HttpPost]
        [ValidateAntiForgeryToken ]

        public IActionResult Edit
            (Item item)
        {
            if (ModelState.IsValid) { 
            _db.Item.Update(item);
            _db.SaveChanges();
            return RedirectToAction("Index");

            }
            else
            {
                return View(item);
            }
        }
        //Get
        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id ==  0)
            {
                return NotFound();


            }
            var item = _db.Item.Find(Id);
            if(item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        //Post Delete

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Delete
            (Item item)
        {
            if (ModelState.IsValid)
            {
                _db.Item.Update(item);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(item);
            }
        }
        //Get Delete
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();


            }
            var item = _db.Item.Find(Id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

    


    }
}
