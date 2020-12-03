using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompShop.Models;
using CompShop.DAO.DAOclasses;

namespace CompShop.Controllers
{
    public class CategoryController : Controller
    {
        private CSEntities3 db = new CSEntities3();
        CategorysDAO categorysDAO = new CategorysDAO();

        // GET: Category
        public ActionResult Index()
        {
            return View(db.Categorys.ToList());
        }

        [Authorize(Roles = "Seller,Client")]
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize(Roles = "Seller,Manager")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Categorys categorys)
        {
            if (ModelState.IsValid)
            {
                db.Categorys.Add(categorys);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                return View();
            }
        

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
