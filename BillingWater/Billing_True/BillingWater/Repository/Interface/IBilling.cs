using Business;
using CoreLib;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
   public interface IBilling : IBaseRepository<Billing>
    {
        string saveBilling(string ReferenceNumber, string Name, string Bill, string status, string duedate, int totalconsume, decimal total, int UserId);
        List<BillingViewModel> getBilling(int UserId);

        List<BillingViewModel> geAlltBilling();

         List<BillingViewModel> geAlltBillingNotPaid();

        List<BillingViewModel> geAlltBillingPaid();

        string payBill(int UserId, string amount);

        List<BillingViewModel> getBillingPaid(int UserId);
    }
}
