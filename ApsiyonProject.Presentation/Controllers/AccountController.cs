using ApsiyonProject.Application.App.Common.Interfaces.Dtos;
using ApsiyonProject.Infrastructure.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApsiyonProject.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApsiyonController _apsiyonController;
        public AccountController(ApsiyonController apsiyonController)
        {
            _apsiyonController = apsiyonController;
        }

        public async Task<ActionResult> Index()
        {
            return View(await _apsiyonController.GetListIncludeBuildingAsync());
        }

        public async Task<ActionResult> GetBuildingList()
        {
            return PartialView(await _apsiyonController.GetListIncludeBuildingAsync());
        }

        public async Task<ActionResult> CreateBuilding()
        {
            ViewBag.BuildingStatus = await _apsiyonController.GetListBuildingStatusAsync();
            return ViewComponent("Building");
        }

        [HttpPost]
        public async Task<ActionResult> CreateBuilding(BuildingDto buildingDto)
        {           
            ViewBag.AddCountMessage = await _apsiyonController.AddBuildingAsync(buildingDto);
            return RedirectToAction("Index");
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: AccountController/Create
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

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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
