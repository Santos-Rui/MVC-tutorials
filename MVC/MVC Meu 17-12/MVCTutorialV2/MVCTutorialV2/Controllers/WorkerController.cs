using Microsoft.AspNetCore.Mvc;
using MVCTutorialV2.Data;
using MVCTutorialV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTutorialV2.Controllers
{
    public class WorkerController : Controller
    {
        private readonly AppDbContext _db;

        public WorkerController(AppDbContext db)
        {
            _db = db;
        }

        //GET - INDEX
        public IActionResult Index()
        {
            IEnumerable<Worker> objList = _db.Worker;
            return View(objList);
        }



        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Worker obj)
        {
            //if (ModelState.IsValid)
            //{
                _db.Worker.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            //}
            //return View();
        }



        //GET - EDIT
        public IActionResult Edit(int ? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Worker.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Worker obj)
        {
            if (ModelState.IsValid)
            {
                _db.Worker.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Worker.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Worker.Find(id);
            if (obj == null) { return NotFound(); }

            _db.Worker.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
