using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cfbInfo.Models;
using cfbInfo.DAL;
using cfbInfo.Web.ViewModels;

namespace cfbInfo.Web.Controllers
{
    public class ConferenceController : Controller
    {
        private Context db = new Context();

        // GET: /Conference/
        public ActionResult Index()
        {
            return View(db.Conferences.ToList());
        }

        // GET: /Conference/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conference conference = db.Conferences.Find(id);
            var conferenceViewModel = new ConferenceViewModel(conference, db);
            if (conference == null)
            {
                return HttpNotFound();
            }
            return View(conferenceViewModel);
        }

        //// GET: /Conference/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: /Conference/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="Id,RefNum,Name,Subdivision")] Conference conference)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Conferences.Add(conference);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(conference);
        //}

        //// GET: /Conference/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Conference conference = db.Conferences.Find(id);
        //    if (conference == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(conference);
        //}

        //// POST: /Conference/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="Id,RefNum,Name,Subdivision")] Conference conference)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(conference).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(conference);
        //}

        //// GET: /Conference/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Conference conference = db.Conferences.Find(id);
        //    if (conference == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(conference);
        //}

        //// POST: /Conference/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Conference conference = db.Conferences.Find(id);
        //    db.Conferences.Remove(conference);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
