using DataAccessLayer;
using DataAccessLayer.Entity;
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
            var result = reg.GetAllParcel();
            return View("list",result);
        }

        // GET: ParceldetailsController/Details/5
        public ActionResult Details(long id)
        {
            var edit = reg.GetParcelByName(id);

            return View("Details", edit);
        }

        // GET: ParceldetailsController/Create
        public ActionResult Create()
        {
            return View("Add",new Parceldetails());
        }

        // POST: ParceldetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Parceldetails parce)
        {
            try
            {
                reg.InsertDetails(parce);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParceldetailsController/Edit/5
        public ActionResult Edit(long id)
        {
            var edit = reg.GetParcelByName (id);
            return View("Update", edit);
        }

        // POST: ParceldetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Parceldetails regs)
        {
            try
            {
                reg.UpdateParcelDetails(regs);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParceldetailsController/Delete/5
        public ActionResult Delete(long id)
        {
            var details = reg.GetParcelByName(id);
            return View("ConfirmDelete",details);

        }

        // POST: ParceldetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, IFormCollection collection)
        {
            try
            {
                reg.DeleteParcelDetails(id);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
