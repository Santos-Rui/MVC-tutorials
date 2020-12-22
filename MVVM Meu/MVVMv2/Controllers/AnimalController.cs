using Microsoft.AspNetCore.Mvc;
using MVVMv2.Data;
using MVVMv2.Models;
using MVVMv2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMv2.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _db;
        private readonly AnimalViewModel _viewModel;


        public AnimalController(AppDbContext db, AnimalViewModel vm)
        {
            _db = db;
            _viewModel = vm;
        }

        //GET - INDEX
        public IActionResult Index()
        {
            IEnumerable<Animal> aniList = _db.Animal;
            

            AnimalViewModel vm = new AnimalViewModel(aniList);
            return View(vm);
        }


        //GET - SEARCH
        public IActionResult Search(string searchString)
        {
            var animais = from m in _db.Animal
                         select m;
            animais = animais.Where(s => s.Name.Contains(searchString));




            AnimalViewModel vm = new AnimalViewModel(animais);
            return View(vm);
        }



        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        public IActionResult Create(Animal anim) {

                _db.Animal.Add(anim);
                _db.SaveChanges();
                return RedirectToAction("Index");

        }






        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            var obj = _db.Animal.Find(id);
            AnimalEditViewModel _vm = new AnimalEditViewModel(obj);
            return View(_vm);
        }

        //POST - EDIT
        [HttpPost]
        public IActionResult Edit(Animal ani)
        {
            if (ModelState.IsValid)
            {
                _db.Animal.Update(ani);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }






        //GET - DELETE
        public IActionResult Delete(int id)
        {
            var obj = _db.Animal.Find(id);
            AnimalDeleteViewModel _vm = new AnimalDeleteViewModel(obj);
            return View(_vm);            
        }

        //POST - DELETE
        [HttpPost]
        public IActionResult DeletePost(int id)
        {
            var obj = _db.Animal.Find(id);
            _db.Animal.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //POST - DELETE2 not working
        [HttpPost]
        public IActionResult DeletePost2(int id)
        {
            var obj = _db.Animal.Find(id);
            _db.Animal.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
