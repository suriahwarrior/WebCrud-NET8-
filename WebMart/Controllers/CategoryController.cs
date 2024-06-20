using Microsoft.AspNetCore.Mvc;
using WebMart.Data;
using WebMart.Models;

namespace WebMart.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> Obj = _db.Categories.ToList();
            return View(Obj);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category Obj)
        {
            //if (Obj.Name == Obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("Name", "The Name cannot be exactly match with the Display Order");
            //}
            if (ModelState.IsValid)
            {
                _db.Categories.Add(Obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(string Id)
        {
            if (string.IsNullOrEmpty(Id)) { return NotFound(); }
            var id = new Guid(Id);
            var Obj = _db.Categories.Find(id);
            if (Obj == null)
            {
                return NotFound();
            }
            return View(Obj);
        }

        [HttpPost]
        public IActionResult Edit(Category Obj)
        {
            //if (Obj.Name == Obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("Name", "The Name cannot be exactly match with the Display Order");
            //}
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id)) { return NotFound(); }
            var id = new Guid(Id);
            var Obj = _db.Categories.Find(id);
            if (Obj == null)
            {
                return NotFound();
            }
            return View(Obj);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(string Id)
        {
            if (string.IsNullOrEmpty(Id)) { return NotFound(); }
            var id = new Guid(Id);
            var Obj = _db.Categories.Find(id);
            if (Obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(Obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
