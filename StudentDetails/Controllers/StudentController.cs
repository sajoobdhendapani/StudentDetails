using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentDetails.DataAccessLayer;
using Microsoft.Extensions.Configuration;

namespace StudentDetails.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentDetailsRepoistory _add;
        private readonly string _connectionstring;
        public StudentController(IStudentDetailsRepoistory add, IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("DbConnection");
            _add = add;


        }
        // GET: Student
        public ActionResult Index()
        {
            try
            {
                var result = _add.GetallRecords();
                return View("View", result);
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            var gat = new StudentDetail();

            return View("Create", gat);
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentDetail val)
        {
            try
            {
                _add.Insert(val);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
