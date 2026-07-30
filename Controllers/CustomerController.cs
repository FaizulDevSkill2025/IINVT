using IINVT.Interfaces;
using IINVT.Models;
using IINVT.Repository;
using IINVT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IINVT.Controllers
{
    public class CustomerController: BaseController<Customer>
    {
       
        protected readonly GenericRepository<Customer> _customerRepository;

        //private readonly DbSet<T> _entity;

        public CustomerController(IGeneric<Customer> repository) : base(repository)
        {
           
        }
        
        public IActionResult Index()
        {
            var customers = _repository.GetAll();
            return View(customers);
        }


        [HttpGet("{id}")]
        public new Customer GetById(int id)
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

        public IActionResult Create(Customer customer)
        {

            if (ModelState.IsValid)
            {
                _repository.Add(customer);

                return RedirectToAction(nameof(Index));
            }


            return View(customer);
        }

        /*
        [HttpPost]
        public new void Add(Customer customer)
        {
            _repository.Add(customer);
        }
        */

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = _repository.GetById(id);
            return View(customer);
        }
  
        [HttpPost]

        [ValidateAntiForgeryToken]

        public IActionResult Edit(Customer customer)
        {

            if (ModelState.IsValid)
            {

                _repository.Update(customer);


                return RedirectToAction(nameof(Index));

            }


            return View(customer);

        }


        [HttpPut]
        public new void Update(Customer customer)
        {
            _repository.Update(customer);
        }

        public IActionResult Details(int id)
        {
            var customer =  _repository.GetById(id);
            return View(customer);
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {

            var customer = _repository.GetById(id);
            return View(customer);

        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            var customer = _repository.GetById(id);
            _repository.Delete(customer);
            return RedirectToAction(nameof(Index));

        }


        //[HttpDelete]
        //public new void Delete(Customer customer)
        //{
        //    _repository.Delete(customer);
        //}

    }
}
