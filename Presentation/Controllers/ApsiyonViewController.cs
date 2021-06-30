using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class ApsiyonViewController : Controller
    {
        // GET: ApsiyonViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApsiyonViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApsiyonViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApsiyonViewController/Create
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

        // GET: ApsiyonViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApsiyonViewController/Edit/5
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

        // GET: ApsiyonViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApsiyonViewController/Delete/5
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
