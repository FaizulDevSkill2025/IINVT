using IINVT.Interfaces;
using IINVT.Models;
using IINVT.Repository;
using Microsoft.AspNetCore.Mvc;

namespace IINVT.Controllers
{
    public class SupplierController : BaseController<Supplier>
    {
        protected readonly GenericRepository<Supplier> _customerRepository;

        public SupplierController(IGeneric<Supplier> repository) : base(repository)
        {

        }

        public IActionResult Index()
        {
            var supplier = _repository.GetAll();
            return View(supplier);
        }

        [HttpGet("{id}")]
        public new Supplier GetById(int id)
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
        public IActionResult Create(Supplier supplier)
        {

            if (ModelState.IsValid)
            {
                _repository.Add(supplier);
                return RedirectToAction(nameof(Index));
            }
            return View(supplier);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var supplier = _repository.GetById(id);
            return View(supplier);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Supplier supplier)
        {

            if (ModelState.IsValid)
            {
               _repository.Update(supplier);
               return RedirectToAction(nameof(Index));
            }

            return View(supplier);
        }

        [HttpPut]
        public new void Update(Supplier supplier)
        {
            _repository.Update(supplier);
        }

        public IActionResult Details(int id)
        {
            var supplier = _repository.GetById(id);
            return View(supplier);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var supplier = _repository.GetById(id);
            return View(supplier);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var supplier = _repository.GetById(id);
            _repository.Delete(supplier);
            return RedirectToAction(nameof(Index));
        }
    }
}
