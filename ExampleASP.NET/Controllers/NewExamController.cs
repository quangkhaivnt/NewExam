using ExampleASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleASP.NET.Controllers
{
    public class NewExamController : Controller
    {
        Model1 db = new Model1();
        
        // GET: NewExam
        public ActionResult Index()
        {
            return View(db.Exams.ToList());
        }

        // GET: NewExam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewExam/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewExam/Create
        [HttpPost]
        public ActionResult Create(Exam exam)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Exams.Add(exam);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(exam);
                
            }
            catch
            {
                return View();
            }
        }

        // GET: NewExam/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewExam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewExam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewExam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
