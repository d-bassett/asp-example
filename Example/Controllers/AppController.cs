using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    public class AppController : Controller
    {
        private static List<App> apps = new List<App>();

        // GET: App
        public ActionResult Index()
        {
            return View(apps);
        }

        // GET: App/Details/5
        public ActionResult Details(int id)
        {
            int index = apps.FindIndex(a => a.ID == id);
            return View(apps[index]);
        }

        // GET: App/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: App/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(App app)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    apps.Add(app);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(app);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: App/Edit/5
        public ActionResult Edit(int id)
        {
            int index = apps.FindIndex(a => a.ID == id);
            return View(apps[index]);
        }

        // POST: App/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, App app)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int index = apps.FindIndex(a => a.ID == id);
                    apps[index] = app;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(app);
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: App/Delete/5
        public ActionResult Delete(int id)
        {
            int index = apps.FindIndex(a => a.ID == id);
            return View(apps[index]);
        }

        // POST: App/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, App app)
        {
            try
            {
                int index = apps.FindIndex(a => a.ID == id);
                apps.RemoveAt(index);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}