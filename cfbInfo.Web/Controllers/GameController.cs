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
    public class GameController : Controller
    {
        private Context db = new Context();

        // GET: /Game/
        public ActionResult Index()
        {
            return View(db.GameStatistics.ToList());
        }

        // GET: /Game/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameStatistic gamestatistic = db.GameStatistics.Find(id);
            var GameViewModel = new GameViewModel(gamestatistic, db);
            if (gamestatistic == null)
            {
                return HttpNotFound();
            }
            return View(GameViewModel);
        }

        //// GET: /Game/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: /Game/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="Id,GameRefNum,Attendance,Duration")] GameStatistic gamestatistic)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.GameStatistics.Add(gamestatistic);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(gamestatistic);
        //}

        //// GET: /Game/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GameStatistic gamestatistic = db.GameStatistics.Find(id);
        //    if (gamestatistic == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(gamestatistic);
        //}

        //// POST: /Game/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="Id,GameRefNum,Attendance,Duration")] GameStatistic gamestatistic)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(gamestatistic).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(gamestatistic);
        //}

        //// GET: /Game/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GameStatistic gamestatistic = db.GameStatistics.Find(id);
        //    if (gamestatistic == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(gamestatistic);
        //}

        //// POST: /Game/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    GameStatistic gamestatistic = db.GameStatistics.Find(id);
        //    db.GameStatistics.Remove(gamestatistic);
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
