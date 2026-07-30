using IINVT.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IINVT.Controllers
{
    public class BaseController<T> : Controller where T : class
    {
        protected readonly IGeneric<T> _repository;

        public BaseController(IGeneric<T> repository)
        {
            _repository = repository;   
        }


        [HttpGet]
        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Add(T entity)
        {
            _repository.Add(entity);
        }

        [HttpPut]
        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        [HttpDelete]
        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }
    }
}
