using Business;
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
    }
}
