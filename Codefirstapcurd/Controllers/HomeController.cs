using Codefirstapcurd.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirstapcurd.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbcontext Db = new ApplicationDbcontext();
        // GET: Home
        public ActionResult Index()
        {
            var emp = Db.employes.ToList();
            return View(emp);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employes s)
        {
            if (ModelState.IsValid == true)
            {

                Db.employes.Add(s);
                int a = Db.SaveChanges();
                if (a > 0)
                {
                    TempData["insertdata"] = "<script>alert('inserted ')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["insertdata"] = "<script>alert(' not inserted ')</script>";
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = Db.employes.Where(model => model.Eid == id).FirstOrDefault();

            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(Employes s)
        {
            if (ModelState.IsValid == true)
            {
                Db.Entry(s).State = EntityState.Modified;
                int a = Db.SaveChanges();
                if (a > 0)
                {
                    TempData["updatedata"] = "<script>alert('update ')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["updatedata"] = "<script>alert(' not update ')</script>";
                }
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var DeleteRow = Db.employes.Where(model => model.Eid == id).FirstOrDefault();
                if (DeleteRow != null)
                {
                    Db.Entry(DeleteRow).State = EntityState.Deleted;
                    int a = Db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Deletedata"] = "<script>alert('Delete ')</script>";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Deletedata"] = "<script>alert(' not Delete ')</script>";
                    }
                }
            }
            return View();
        }
        public ActionResult Details(int id)
        {

            var Row = Db.employes.Where(model => model.Eid == id).FirstOrDefault();
            return View(Row);
        }
    }
}