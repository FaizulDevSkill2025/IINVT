using IINVT.Interfaces;
using IINVT.Models;
using IINVT.Repository;
using Microsoft.AspNetCore.Mvc;

namespace IINVT.Controllers
{
    public class ProfileController : BaseController<Profile>
    {
        protected readonly GenericRepository<Profile> _profileRepository;
        public ProfileController(IGeneric<Profile> repository) : base(repository)
        {
        }

        public IActionResult Index()
        {
            var profile = _repository.GetAll();
            return View(profile);
        }

        [HttpGet("{id}")]
        public new Profile GetById(int id)
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
        public IActionResult Create(Profile profile)
        {

            if (ModelState.IsValid)
            {
                _repository.Add(profile);
                return RedirectToAction(nameof(Index));
            }
            return View(profile);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var profile = _repository.GetById(id);
            return View(profile);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Profile profile)
        {

            if (ModelState.IsValid)
            {
                _repository.Update(profile);
                return RedirectToAction(nameof(Index));
            }

            return View(profile);
        }

        [HttpPut]
        public new void Update(Profile profile)
        {
            _repository.Update(profile);
        }

        public IActionResult Details(int id)
        {
            var profile = _repository.GetById(id);
            return View(profile);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var profile = _repository.GetById(id);
            return View(profile);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var profile = _repository.GetById(id);
            _repository.Delete(profile);
            return RedirectToAction(nameof(Index));
        }
    }
}
}
