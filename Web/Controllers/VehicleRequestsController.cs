using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Data;
using Domain.Entities;

namespace Web.Controllers
{
    public class VehicleRequestsController : Controller
    {
        private MyContext db = new MyContext();

        // GET: VehicleRequests
        public ActionResult Index()
        {
            var vehicleRequests = db.VehicleRequests.Include(v => v.Client);
            return View(vehicleRequests.ToList());
        }

        // GET: VehicleRequests/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleRequest vehicleRequest = db.VehicleRequests.Find(id);
            if (vehicleRequest == null)
            {
                return HttpNotFound();
            }
            return View(vehicleRequest);
        }

        // GET: VehicleRequests/Create
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(db.Clients, "PersonID", "Name");
            return View();
        }

        // POST: VehicleRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NameR,Marque,Kilometrage,Matricule,ClientId")] VehicleRequest vehicleRequest)
        {
            if (ModelState.IsValid)
            {
                db.VehicleRequests.Add(vehicleRequest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClientId = new SelectList(db.Clients, "PersonID", "Name", vehicleRequest.ClientId);
            return View(vehicleRequest);
        }

        // GET: VehicleRequests/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleRequest vehicleRequest = db.VehicleRequests.Find(id);
            if (vehicleRequest == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClientId = new SelectList(db.Clients, "PersonID", "Name", vehicleRequest.ClientId);
            return View(vehicleRequest);
        }

        // POST: VehicleRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NameR,Marque,Kilometrage,Matricule,ClientId")] VehicleRequest vehicleRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicleRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClientId = new SelectList(db.Clients, "PersonID", "Name", vehicleRequest.ClientId);
            return View(vehicleRequest);
        }

        // GET: VehicleRequests/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VehicleRequest vehicleRequest = db.VehicleRequests.Find(id);
            if (vehicleRequest == null)
            {
                return HttpNotFound();
            }
            return View(vehicleRequest);
        }

        // POST: VehicleRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VehicleRequest vehicleRequest = db.VehicleRequests.Find(id);
            db.VehicleRequests.Remove(vehicleRequest);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
