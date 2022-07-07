using Business;
using CoreLib;
using MyLibrary.Repositories;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
  public class BillingRepository : BaseRepository<Billing, AppDb> , IBilling
    {
        AppDb app = new AppDb();

        public string saveBilling(string ReferenceNumber, string Name, string Bill, string status, string duedate, int totalconsume, decimal total, int UserId)
        {
            app.Billings.Add(new Billing { Bill = Bill, CrDate = DateTime.Now, DueDate = duedate, Name = Name,  ReferenceNumber = ReferenceNumber, Status = status, Total = total, TotalConsume = totalconsume, UserId = UserId });
            app.SaveChanges();
            return "";
        }

        public List<BillingViewModel> getBilling(int UserId)
        {

            var get = (from u in app.Billings
                       where u.UserId == UserId && u.Status == "Not Paid"
                       select new
                       {

                           ReferenceNumber = u.ReferenceNumber,
                           Name = u.Name,
                           Bill = u.Bill,
                           Status = u.Status,
                           DueDate = u.DueDate,
                           totalConsume = u.TotalConsume,
                           total = u.Total,
                           UserId = u.UserId,
                           Id = u.Id,
                           Crdate = u.CrDate

                       }).Select(x => new BillingViewModel { Total = x.total, TotalConsume = x.totalConsume, DueDate = x.DueDate, Bill = x.Bill, Id = x.Id, CrDate = x.Crdate, Name = x.Name, ReferenceNumber = x.ReferenceNumber, Status = x.Status }).ToList();

            return get;
        
        }

        public List<BillingViewModel> getBillingPaid(int UserId)
        {

            var get = (from u in app.Billings
                       where u.UserId == UserId && u.Status == "Paid"
                       select new
                       {

                           ReferenceNumber = u.ReferenceNumber,
                           Name = u.Name,
                           Bill = u.Bill,
                           Status = u.Status,
                           DueDate = u.DueDate,
                           totalConsume = u.TotalConsume,
                           total = u.Total,
                           UserId = u.UserId,
                           Id = u.Id,
                           Crdate = u.CrDate

                       }).Select(x => new BillingViewModel { Total = x.total, TotalConsume = x.totalConsume, DueDate = x.DueDate, Bill = x.Bill, Id = x.Id, CrDate = x.Crdate, Name = x.Name, ReferenceNumber = x.ReferenceNumber, Status = x.Status }).ToList();

            return get;

        }

        public List<BillingViewModel> geAlltBilling()
        {

            var get = (from u in app.Billings
                    
                       select new
                       {

                           ReferenceNumber = u.ReferenceNumber,
                           Name = u.Name,
                           Bill = u.Bill,
                           Status = u.Status,
                           DueDate = u.DueDate,
                           totalConsume = u.TotalConsume,
                           total = u.Total,
                           UserId = u.UserId,
                           Id = u.Id,
                           Crdate = u.CrDate

                       }).Select(x => new BillingViewModel { Total = x.total, TotalConsume = x.totalConsume, DueDate = x.DueDate, Bill = x.Bill, Id = x.Id, CrDate = x.Crdate, Name = x.Name, ReferenceNumber = x.ReferenceNumber, Status = x.Status }).ToList();

            return get;

        }

        public List<BillingViewModel> geAlltBillingNotPaid()
        {

            var get = (from u in app.Billings
                       where u.Status == "Not Paid"
                       select new
                       {

                           ReferenceNumber = u.ReferenceNumber,
                           Name = u.Name,
                           Bill = u.Bill,
                           Status = u.Status,
                           DueDate = u.DueDate,
                           totalConsume = u.TotalConsume,
                           total = u.Total,
                           UserId = u.UserId,
                           Id = u.Id,
                           Crdate = u.CrDate

                       }).Select(x => new BillingViewModel { Total = x.total, TotalConsume = x.totalConsume, DueDate = x.DueDate, Bill = x.Bill, Id = x.Id, CrDate = x.Crdate, Name = x.Name, ReferenceNumber = x.ReferenceNumber, Status = x.Status }).ToList();

            return get;

        }


        public List<BillingViewModel> geAlltBillingPaid()
        {

            var get = (from u in app.Billings
                       where u.Status == "Paid"
                       select new
                       {

                           ReferenceNumber = u.ReferenceNumber,
                           Name = u.Name,
                           Bill = u.Bill,
                           Status = u.Status,
                           DueDate = u.DueDate,
                           totalConsume = u.TotalConsume,
                           total = u.Total,
                           UserId = u.UserId,
                           Id = u.Id,
                           Crdate = u.CrDate

                       }).Select(x => new BillingViewModel { Total = x.total, TotalConsume = x.totalConsume, DueDate = x.DueDate, Bill = x.Bill, Id = x.Id, CrDate = x.Crdate, Name = x.Name, ReferenceNumber = x.ReferenceNumber, Status = x.Status }).ToList();

            return get;

        }

        public string payBill(int UserId, string amount)
        {

            var get = (from u in app.Billings
                       where u.Id == UserId
                       select u).FirstOrDefault();

            if (get != null)
            {
                var outs = get.Total - Convert.ToDecimal(amount); 
                get.AmountPaid = Convert.ToDecimal(amount);
                get.OutstandingBalance = get.Total - Convert.ToDecimal(amount);
                if (outs <= 0)
                {
                    get.Status = "Paid";
                }
                app.SaveChanges();
            }

            return "";

        }


    }
}
