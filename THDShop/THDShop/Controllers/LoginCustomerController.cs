﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace THDShop.Controllers
{
    public class LoginCustomerController : Controller
    {
        // GET: LoginCustomer
        QLLaptopShopEntities database = new QLLaptopShopEntities();
        // GET: LoginUser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAccount(USER _user)
        {

            CUSTOMER cUSTOMER = database.CUSTOMERs.Where(m => m.ID == _user.ID).FirstOrDefault();

            if (!CheckExistAccount(_user))
            {
                ViewBag.ErrorInfo = "Sai info";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                database.Configuration.ValidateOnSaveEnabled = false;
                Session["EMAIL"] = _user.EMAIL;
                Session["PASSWORD"] = _user.PASSWORD;
                STAFF sTAFF = database.STAFFs.Where(m => m.ID == _user.ID).FirstOrDefault();
                if (_user.PASSWORD == sTAFF.PASSWORD && _user.EMAIL == sTAFF.EMAIL && sTAFF.ROLE.NAME == "Manager")
                {
                    Session["TENQLY"] = sTAFF.NAME;
                    Session["ID"] = sTAFF.ID;

                }
                else if (_user.ID == sTAFF.IDUSER || sTAFF.ROLE.NAME == "Staff")
                {
                    Session["TENNV"] = sTAFF.NAME;
                    Session["ID"] = sTAFF.ID;
                }

                return RedirectToAction("Index", "Product");
            }

        }
        public ActionResult EditAccount(int ID)
        {
            var detailUser = database.USERS.Where(m => m.ID == ID).FirstOrDefault();
            return View(detailUser);
        }

        [HttpPost]
        public ActionResult EditAccount(USER user)
        {
            var detail = database.USERS.Where(m => m.ID == user.ID);

            if (detail == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                database.Entry(user).State = EntityState.Modified;
                database.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public bool CheckExistAccount(USER _user)
        {

            var check = database.USERS.Where(s => s.EMAIL == _user.EMAIL && s.PASSWORD == _user.PASSWORD).FirstOrDefault();
            if (check != null)
            {
                return true;
            }
            return false;
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "LoginUser");
        }
    }
}