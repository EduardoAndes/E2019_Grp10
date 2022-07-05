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
   public class UserAccountRepository : BaseRepository<UserAccount, AppDb>, IUserAccounts
    {
        AppDb app = new AppDb();

        public string saveUserAccount(int AccountId, string AccountName, string AccountUserName, string AccountPassword, string accountEmail, string AccountType)
        {

            app.UserAccounts.Add(new UserAccount { AccountEmail = accountEmail, AccountId = AccountId, AccountName = AccountName, AccountPassword = AccountPassword, AccountType = AccountType, AccountUserName = AccountUserName });
            app.SaveChanges();
            return "";
        }
    }
}
