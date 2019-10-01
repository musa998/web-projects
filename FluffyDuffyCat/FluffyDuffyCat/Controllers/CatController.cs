using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluffyDuffyCat.Data;
using FluffyDuffyCat.Data.Models;
using FluffyDuffyCat.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluffyDuffyCat.Controllers
{
    public class CatController : Controller
    {
       public FluffyCatDbContext dbContext = new FluffyCatDbContext();

        // GET: Cat
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(400, Json("Bad request."));
            }

            Cat cat = dbContext.Cats.Find(id);

            if (cat == null)
            {
                return StatusCode(400, Json("Bad request."));
            }
            CatViewModel catVM = new CatViewModel()
            {
                CatId = cat.CatId,
                Name = cat.Name,
                Breed = cat.Breed,
                Age = cat.Age,
                Url = cat.ImageUrl
            };
            return View(catVM);
        }

        // GET: Cat/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Cat/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            //try
            //{
                // TODO: Add insert logic here

                Cat cat = new Cat()
                {
                    Name = collection["Name"],
                    Age = int.Parse(collection["Age"]),
                    Breed = collection["Breed"],
                    ImageUrl = collection["Url"]
                };

                using (var context  = new FluffyCatDbContext())
                {
                    context.Cats.Add(cat);
                    context.SaveChanges();
                }

            return RedirectToAction("Index", "Home");
        }
            //catch
            //{
            //    return View();
            //}
        //}

        // GET: Cat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cat/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cat/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}