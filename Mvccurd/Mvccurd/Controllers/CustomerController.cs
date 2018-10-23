using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvccurd.Models;

namespace Mvccurd.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer/Index
        public ActionResult Index()
        {
            using (DbModels dbModel=new DbModels())
            {
                return View(dbModel.Customers.ToList());
            }
                
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.Customers.Where(x => x.id==id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    // TODO: Add insert logic here
                    dbModels.Customers.Add(customer);
                    dbModels.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.Customers.Where(x =>x.id==id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                using (DbModels dbModels = new DbModels())
                {
                    dbModels.Entry(customer).State = EntityState.Modified;
                    dbModels.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModels = new DbModels())
            {
                return View(dbModels.Customers.Where(x => x.id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels dbModels = new DbModels())
                {
                    Customer customer=dbModels.Customers.Where(x => x.id==id).FirstOrDefault();
                    dbModels.Customers.Remove(customer);
                    dbModels.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
