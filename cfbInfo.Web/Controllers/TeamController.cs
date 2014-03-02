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
    public class TeamController : Controller
    {
        // GET: /Team/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Team/Details/5
        public ActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            var TeamViewModel = new TeamViewModel(id);

            if (TeamViewModel == null)
            {
                return HttpNotFound();
            }
            return View(TeamViewModel);
        }

        //// GET: /Team/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: /Team/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include="Id,RefNum,Name,SchoolName,ConfId,NumOfNatlChamp,NumOfConfChamp,YearFounded,AllTimeWins,AllTimeLosses,AllTimeTies,BowlWins,BowlLosses,BowlTies,NumOfHeismans,NumOfAllAmericans,HeadCoach,OffCoord,DefCoord,Mascot,TeamUrl,ColorHexCode,Image")] Team team)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Teams.Add(team);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(team);
        //}

        //// GET: /Team/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Team team = db.Teams.Find(id);
        //    if (team == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(team);
        //}

        //// POST: /Team/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include="Id,RefNum,Name,SchoolName,ConfId,NumOfNatlChamp,NumOfConfChamp,YearFounded,AllTimeWins,AllTimeLosses,AllTimeTies,BowlWins,BowlLosses,BowlTies,NumOfHeismans,NumOfAllAmericans,HeadCoach,OffCoord,DefCoord,Mascot,TeamUrl,ColorHexCode,Image")] Team team)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(team).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(team);
        //}

        //// GET: /Team/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Team team = db.Teams.Find(id);
        //    if (team == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(team);
        //}

        //// POST: /Team/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Team team = db.Teams.Find(id);
        //    db.Teams.Remove(team);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
