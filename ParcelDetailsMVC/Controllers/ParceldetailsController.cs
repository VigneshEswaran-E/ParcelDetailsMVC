using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelDetailsMVC.Controllers
{
    public class ParceldetailsController : Controller
    {
        IParceldetailsRepository reg = null;
        public ParceldetailsController(IConfiguration configuration, IParceldetailsRepository Regs)
        {
            reg = Regs;
        }
        // GET: ParceldetailsController
        public ActionResult List()
        {
            var result = reg.ShowAllParcel();
            return View("list",result);
        }

        // GET: ParceldetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParceldetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParceldetailsController/Create
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

        // GET: ParceldetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParceldetailsController/Edit/5
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

        // GET: ParceldetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParceldetailsController/Delete/5
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
