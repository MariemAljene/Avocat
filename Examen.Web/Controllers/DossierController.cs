using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Numerics;

namespace Examen.Web.Controllers
{
    public class DossierController : Controller
    { 
        IDossierService dossierService { get; set; } 
        IAvocatService avocatService { get; set; } 
        IClientService clientService { get; set; }
        public DossierController(IDossierService dossierService, IAvocatService avocatService, IClientService clientService)
        {
            this.dossierService = dossierService;
            this.avocatService = avocatService;
            this.clientService = clientService;
        }

        // GET: DossierController
        public ActionResult Index(string? avocatName)
        {
            if (avocatName == null)
            {
                return View(dossierService.GetAll());


            }
            else return View(dossierService.GetMany(f => f.Avocat.Nom.Equals(avocatName)));
        }

        // GET: DossierController/Details/5
        public ActionResult Details(int id)
        {
            return View(avocatService.GetById(id));
        }

        // GET: DossierController/Create
        public ActionResult Create()
        {ViewBag.ClientFk= new SelectList(clientService.GetAll(), "CIN", "Nom");
            ViewBag.AvocatFk = new SelectList(avocatService.GetAll(), "AvocatId", "Nom");

            return View();
        }

        // POST: DossierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dossier collection)
        {
            try
            { 
                dossierService.Add(collection);
                dossierService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DossierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DossierController/Edit/5
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

        // GET: DossierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DossierController/Delete/5
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
