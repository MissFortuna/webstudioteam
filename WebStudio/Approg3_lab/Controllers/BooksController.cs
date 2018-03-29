using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Approg3_lab.Models;

namespace Approg3_lab.Controllers
{
    public class BooksController : Controller
    {
        private static People people = new People();

        // GET: People
        public ActionResult Index()
        {
            return View(people.peopleList);
        }

        // GET: Details/5
        public ActionResult Details(int id)
        {
            return View(people.ShowPerson(id));
        }

        // GET: Create
        public ActionResult Create()
        {
            return View(new PersonModels());
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(PersonModels model)
        {
            try
            {
                // TODO: Add insert logic here
                people.CreatePerson(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Edit/5
        public ActionResult Edit(int id)
        {
            return View(people.ShowPerson(id));
        }

        // POST: Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PersonModels model)
        {
            try
            {
                people.UpdatePerson(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Delete/5
        public ActionResult Delete(int id)
        {
            return View(people.ShowPerson(id));
        }

        // POST: Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PersonModels model)
        {
            try
            {

                people.DeletePerson(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
