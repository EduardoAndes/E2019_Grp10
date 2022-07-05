using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   public class BillingViewModel
    {
        public int Id { get; set; }

       
        public string ReferenceNumber { get; set; }

      
        public string Name { get; set; }

     
        public string Bill { get; set; }

       
        public string Status { get; set; }

      
        public string DueDate { get; set; }

        public int? TotalConsume { get; set; }

        public decimal? Total { get; set; }

        public DateTime? CrDate { get; set; }
    }
}
