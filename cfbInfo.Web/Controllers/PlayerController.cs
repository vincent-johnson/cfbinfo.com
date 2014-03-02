﻿using System;
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
    public class PlayerController : Controller
    {
        private Context db = new Context();

        // GET: /Player/
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        // GET: /Player/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);

            var playerViewModel = new PlayerViewModel(player, db);

            if (player == null)
            {
                return HttpNotFound();
            }
            return View(playerViewModel);
        }

        //// GET: /Player/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: /Player/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="Id,RefNum,TeamRefNum,FirstName,LastName,JerseyNum,Class,Position,Height,Weight,Town,State,Country,PrevSchool")] Player player)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Players.Add(player);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(player);
        //}

        //// GET: /Player/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Player player = db.Players.Find(id);
        //    if (player == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(player);
        //}

        //// POST: /Player/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="Id,RefNum,TeamRefNum,FirstName,LastName,JerseyNum,Class,Position,Height,Weight,Town,State,Country,PrevSchool")] Player player)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(player).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(player);
        //}

        //// GET: /Player/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Player player = db.Players.Find(id);
        //    if (player == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(player);
        //}

        //// POST: /Player/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Player player = db.Players.Find(id);
        //    db.Players.Remove(player);
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
