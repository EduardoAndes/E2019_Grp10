using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   public class UserAccountViewModel
    {
        public int Id { get; set; }

        public int? AccountId { get; set; }

     
        public string AccountName { get; set; }

        public string AccountUserName { get; set; }

   
        public string AccountPassword { get; set; }

    
        public string AccountEmail { get; set; }

     
        public string AccountType { get; set; }
    }
}
