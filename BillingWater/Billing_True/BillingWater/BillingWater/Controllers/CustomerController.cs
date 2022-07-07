using Repository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillingWater.Controllers
{
    public class CustomerController : Controller
    {

        private readonly IUserAccounts _login;
        private readonly IBilling _bill;


        public CustomerController()
        {

            _login = new UserAccountRepository();
            _bill = new BillingRepository();
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getviewBill()
        {

            var list = _bill.getBilling(Convert.ToInt32(Session["Id"]));

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddBill(int id)
        {

            ViewBag.id = id;
            return View();

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult AddBill(string txtAmountPaid, int UserId)
        {
            string task = "";
            try
            {
                task = _bill.payBill(UserId, txtAmountPaid);
            }
            catch (Exception e)
            {

            }
            return Json(task);
        }


        public ActionResult viewPaid()
        {
            return View();
        }

        public JsonResult getviewPaid()
        {

            var list = _bill.getBillingPaid(Convert.ToInt32(Session["Id"]));

            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}