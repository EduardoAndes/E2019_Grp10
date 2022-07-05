using Business;
using MyLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
   public interface IUserAccounts : IBaseRepository<UserAccount>
    {
        string saveUserAccount(int AccountId, string AccountName, string AccountUserName, string AccountPassword, string accountEmail, string AccountType);
    }
}
