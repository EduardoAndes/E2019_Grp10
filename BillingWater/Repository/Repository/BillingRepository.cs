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

        public string saveBilling(string ReferenceNumber, string Name, string Bill, string status, string duedate, int totalconsume, decimal total)
        {
            app.Billings.Add(new Billing { Bill = Bill, CrDate = DateTime.Now, DueDate = duedate, Name = Name,  ReferenceNumber = ReferenceNumber, Status = status, Total = total, TotalConsume = totalconsume });
            app.SaveChanges();
            return "";
        }

        public List<BillingViewModel> getBilling(int UserId)
        {

            var get = (from u in app.Billings
                       where u.UserId == UserId
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
    }
}
