
using Repository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillingWater.Controllers
{
    public class AdminController : Controller
    {

        private readonly IUserAccounts _login;
        private readonly IBilling _bill;


        public AdminController()
        {

            _login = new UserAccountRepository();
            _bill = new BillingRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult viewBill()
        {

            return View();
        
        }

        public JsonResult getviewBill()
        {

            var list = _login.geAlltUserAccount();

            return Json(list, JsonRequestBehavior.AllowGet);
        }


        public ActionResult AddBill(int id)
        {

            ViewBag.id = id;
            return View();

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AddBill(string txtReferenceNumber, string txtName, string txtBill, string txtDueDate, string txtTotalConsume, string txtTotal, int UserId)
        {
            string task = "";
            try
            {
                task = _bill.saveBilling(txtReferenceNumber, txtName, txtBill, "Not Paid", txtDueDate, Convert.ToInt32(txtTotalConsume), Convert.ToDecimal(txtTotal), UserId);
            }
            catch (Exception e)
            {

            }
            return Json(task);
        }


        public ActionResult viewCustomerBill()
        {

            return View();

        }

        public JsonResult getviewCustomerBill()
        {

            var list = _bill.geAlltBilling();

            return Json(list, JsonRequestBehavior.AllowGet);
        }


        public ActionResult viewCustomerBillNotPaid()
        {

            return View();

        }

        public JsonResult getviewCustomerBillNotPaid()
        {

            var list = _bill.geAlltBillingNotPaid();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult viewCustomerBillPaid()
        {

            return View();

        }

        public JsonResult getviewCustomerBillPaid()
        {

            var list = _bill.geAlltBillingPaid();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CreateUser()
        {

           
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult CreateUser(string AccountName, string AccountUserName, string AccountPassword, string AccountEmail)
        {
            string task = "";
            try
            {
                task = _login.saveUserAccount(1, AccountName, AccountUserName, AccountPassword, AccountEmail, "Customer");
            }
            catch (Exception e)
            {

            }
            return Json(task);
        }

        public ActionResult viewUsers()
        {

            return View();

        }

        public JsonResult getviewUsers()
        {

            var list = _login.geAlltUserAccount();

            return Json(list, JsonRequestBehavior.AllowGet);
        }



    }
}