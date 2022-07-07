using Repository.Interface;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BillingWater.Controllers
{
    public class LoginController : Controller
    {
       

        private readonly IUserAccounts _login;

        public LoginController()
        {

            _login = new UserAccountRepository();
           
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginUser(string EmployeeNumber, string Password)
        {
            var result = new { Result = "fail", ID = "" };
            var checkrecord = _login.getUserAccount(EmployeeNumber, Password);
            foreach (var item in checkrecord)
            {
                if (item.AccountType.Contains("Admin") == true)
                {

                    Session["AccountName"] = item.AccountName;
                    Session["Id"] = item.Id;
                    Session["AccountType"] = item.AccountType;

                    result = new { Result = "Admin", ID = "" };
                }
                else if (item.AccountType.Contains("Customer") ==true)
                {
                    Session["AccountName"] = item.AccountName;
                    Session["Id"] = item.Id;
                    Session["AccountType"] = item.AccountType;

                    result = new { Result = "Customer", ID = "" };

                }
            }
           
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Index");

        }


    }
}