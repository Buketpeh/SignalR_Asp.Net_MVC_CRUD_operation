using CrudCase.Hubs;
using CrudCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CrudCase.Controllers
{
    public class HomeController : Controller
    {
        Model1 k = new Model1();

        public ActionResult Index()
        {
            var vehicle = k.Aracs.ToList();
            return View(vehicle);
        }
        #region CREATE
        public ActionResult Create() //GET
        {
     
            return View();
        }
        [HttpPost]
        public ActionResult Create(Arac vehicle)//POST
        {
            k.Aracs.Add(vehicle);
            k.SaveChanges();
            HubVehicle.NotifyCurrentVehicleInformationToAllClients();
            return RedirectToAction("Index");
        }
        #endregion

        #region READ
        public ActionResult test()
        {

            return View();
        }
        #endregion

        #region READ
        public ActionResult Indexx()
        {
            List<Arac> vehicles = k.Aracs.ToList();
            return PartialView("Indexx", vehicles);
        }
        #endregion

        #region UPDATE
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                ViewBag.Uyari = "Güncellenecek hizmet bulunamadi..";
            }

            var f = k.Aracs.Where(x => x.aracno == id).FirstOrDefault();
            if (f == null)
            {
                return HttpNotFound();
            }
            return View(f);


        }
        [HttpPost]
        [ValidateAntiForgeryToken] //Dışarıdan gelebilecek isteklerden korumak için...(Sql injection gibi)
        [ValidateInput(false)]
        public ActionResult Update(int id, Arac f)
        {
            if (ModelState.IsValid)
            {
                var vehicle = k.Aracs.Where(x => x.aracno == id).SingleOrDefault();
                vehicle.marka = f.marka;
                vehicle.model = f.model;
                vehicle.fiyat = f.fiyat;
                vehicle.plaka = f.plaka;
                vehicle.yas = f.yas;
             
                k.SaveChanges();
                HubVehicle.NotifyCurrentVehicleInformationToAllClients();
                return RedirectToAction("Index");

            }

            return View(f);
        }
        #endregion

        #region DELETE
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var vehicle = k.Aracs.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            k.Aracs.Remove(vehicle);
            k.SaveChanges();
            HubVehicle.NotifyCurrentVehicleInformationToAllClients();
            return RedirectToAction("Index");

        }
        #endregion
    


    }
}