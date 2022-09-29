using DogGo.Interfaces;
using DogGo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DogGo.Controllers
{
    public class DogsController : Controller
    {

        private readonly IDogRepository _dogRepo;

        public DogsController(IDogRepository dogRepository)
        {
            _dogRepo = dogRepository;
        }

     

        // GET: Dogs
        public ActionResult Index()
        {
           List<Dog> dogs = _dogRepo.GetAllDogs();
            return View(dogs);
        }

        // GET: DogsController/Details/5
        public ActionResult Details(int id)
        {
            var dog = _dogRepo.GetDogById(id);
            return View(dog);
        }

        // GET: DogsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DogsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DogsController/Edit/5
        public ActionResult Edit(int id)
        {
            var dog = _dogRepo.GetDogById(id);
            return View(dog);
        }

        // POST: DogsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Dog dog)
        {
            try
            {
                _dogRepo.UpdateDog(dog);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(dog);
            }
        }
        // GET: DogsController/Delete/5
        public ActionResult Delete(int id)
        {
            var dog = _dogRepo.GetDogById(id);
            return View(dog);
        }

        // POST: DogsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Dog dog)
        {
            try
            {
                _dogRepo.DeleteDog(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(dog);
            }
        }
    }
}
