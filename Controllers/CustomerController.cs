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

        //public new IEnumerable<Customer> GetAll()
        //{
        //    return _repository.GetAll();
        //}

        [HttpGet("{id}")]
        public new Customer GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public new void Add(Customer customer)
        {
            _repository.Add(customer);
        }

        [HttpPut]
        public new void Update(Customer customer)
        {
            _repository.Update(customer);
        }

        [HttpDelete]
        public new void Delete(Customer customer)
        {
            _repository.Delete(customer);
        }

    }
}
