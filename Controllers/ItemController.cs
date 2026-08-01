using IINVT.Interfaces;
using IINVT.Models;
using IINVT.Repository;
using Microsoft.AspNetCore.Mvc;

namespace IINVT.Controllers
{
    public class ItemController : BaseController<Item>
    {
        protected readonly GenericRepository<Item> _customerRepository;
        public ItemController(IGeneric<Item> repository) : base(repository)
        {
        }


        public IActionResult Index()
        {
            var item = _repository.GetAll();
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item item)
        {

            if (ModelState.IsValid)
            {
                _repository.Add(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var item = _repository.GetById(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Item item)
        {

            if (ModelState.IsValid)
            {
                _repository.Update(item);
                return RedirectToAction(nameof(Index));
            }

            return View(item);
        }

        [HttpPut]
        public new void Update(Item item)
        {
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
