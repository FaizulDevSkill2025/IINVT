using IINVT.Data;
using IINVT.Interfaces;
using IINVT.Models;
using IINVT.Repository;
using IINVT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace IINVT.Controllers
{
    public class ItemController : BaseController<Item>
    {
        protected readonly GenericRepository<Item> _itemRepository; 
        private readonly ApplicationDbContext _context;
        public ItemController(IGeneric<Item> repository, ApplicationDbContext context) : base(repository)
        {
            _context = context;     
        }
    
        public IActionResult Index()
        {
            List<Unit> uli = new List<Unit>();
            List<Category> ctgry = new List<Category>();
            List<Subcategory> subctgry = new List<Subcategory>();
            uli.Insert(0, new Unit { UnitID = 0, UnitName = "Select" });
            ctgry.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });
            subctgry.Insert(0, new Subcategory { SubCategoryID = 0, SubCategoryName  = "Select" });
            ViewBag.uli = uli;
            ViewBag.ctgry = ctgry;
            ViewBag.subctgry = subctgry;
            var item = _repository.GetAll().ToList();
            return View(item);
        }

        [HttpGet("{id}")]
        public new Item GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ItemViewModel model = new ItemViewModel();
            ViewBag.CategoryName = new SelectList(_context.category, "CategoryName", "CategoryName");
            ViewBag.SubCategoryName = new SelectList(_context.subcategory, "SubCategoryName", "SubCategoryName");
            ViewBag.UnitName = new SelectList(_context.unit, "UnitName", "UnitName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {
            ItemViewModel model = new ItemViewModel();

            
            if (ModelState.IsValid)
            {

                List<Unit> units = new List<Unit>();
                List<Category> ctgry = new List<Category>();
                List<Subcategory> subctgry = new List<Subcategory>();
                ViewBag.CategoryName = new SelectList(_context.category, "CategoryName", "CategoryName");
                ViewBag.SubCategoryName = new SelectList(_context.subcategory, "SubCategoryName", "SubCategoryName");
                ViewBag.UnitName = new SelectList(_context.unit, "UnitName", "UnitName");
                units.Insert(0, new Unit { UnitID = 0, UnitName = "Select" });
                ctgry.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });
                subctgry.Insert(0, new Subcategory { SubCategoryID = 0, SubCategoryName  = "Select" });   
                ViewBag.uli = units;
                ViewBag.ctgry = ctgry;
                ViewBag.subctgry = subctgry;
                _repository.Add(item);
                return RedirectToAction(nameof(Index));
            }

            
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<Unit> units = new List<Unit>();
            List<Category> ctgry = new List<Category>();
            List<Subcategory> subctgry = new List<Subcategory>();
            ViewBag.CategoryName = new SelectList(_context.category, "CategoryName", "CategoryName");
            ViewBag.SubCategoryName = new SelectList(_context.subcategory, "SubCategoryName", "SubCategoryName");
            ViewBag.UnitName = new SelectList(_context.unit, "UnitName", "UnitName");
            ViewBag.uli = units;
            ViewBag.ctgry = ctgry;
            ViewBag.subctgry = subctgry;
            units.Insert(0, new Unit { UnitID = 0, UnitName = "Select" });
            ctgry.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });
            subctgry.Insert(0, new Subcategory { SubCategoryID = 0, SubCategoryName  = "Select" });
            var item = _repository.GetById(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item item)
        {

            if (ModelState.IsValid)
            {
                List<Unit> units = new List<Unit>();
                List<Category> ctgry = new List<Category>();
                List<Subcategory> subctgry = new List<Subcategory>();
                ViewBag.CategoryName = new SelectList(_context.category, "CategoryName", "CategoryName");
                ViewBag.SubCategoryName = new SelectList(_context.subcategory, "SubCategoryName", "SubCategoryName");
                ViewBag.UnitName = new SelectList(_context.unit, "UnitName", "UnitName");
                ViewBag.uli = units;
                ViewBag.ctgry = ctgry;
                ViewBag.subctgry = subctgry;
                units.Insert(0, new Unit { UnitID = 0, UnitName = "Select" });
                ctgry.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });
                subctgry.Insert(0, new Subcategory { SubCategoryID = 0, SubCategoryName = "Select" });
                _repository.Update(item);
                return RedirectToAction(nameof(Index));
            }

            return View(item);
        }

        [HttpPut]
        public new void Update(Item item)
        {
            List<Unit> units = new List<Unit>();
            List<Category> ctgry = new List<Category>();
            List<Subcategory> subctgry = new List<Subcategory>();
            ViewBag.CategoryName = new SelectList(_context.category, "CategoryName", "CategoryName");
            ViewBag.SubCategoryName = new SelectList(_context.subcategory, "SubCategoryName", "SubCategoryName");
            ViewBag.UnitName = new SelectList(_context.unit, "UnitName", "UnitName");
            ViewBag.uli = units;
            ViewBag.ctgry = ctgry;
            ViewBag.subctgry = subctgry;
            units.Insert(0, new Unit { UnitID = 0, UnitName = "Select" });
            ctgry.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });
            subctgry.Insert(0, new Subcategory { SubCategoryID = 0, SubCategoryName = "Select" });
            _repository.Update(item);
        }

        public IActionResult Details(int id)
        {
            var item = _repository.GetById(id);
            return View(item);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var item = _repository.GetById(id);
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _repository.GetById(id);
            _repository.Delete(item);
            return RedirectToAction(nameof(Index));
        }
    }
}
