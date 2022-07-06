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
   public class UserAccountRepository : BaseRepository<UserAccount, AppDb>, IUserAccounts
    {
        AppDb app = new AppDb();

        public string saveUserAccount(int AccountId, string AccountName, string AccountUserName, string AccountPassword, string accountEmail, string AccountType)
        {

            app.UserAccounts.Add(new UserAccount { AccountEmail = accountEmail, AccountId = AccountId, AccountName = AccountName, AccountPassword = AccountPassword, AccountType = AccountType, AccountUserName = AccountUserName });
            app.SaveChanges();
            return "";
        }

        public List<UserAccountViewModel> getUserAccount(string Username, string Password)
        {
            var get = (from u in app.UserAccounts
                       where u.AccountUserName == Username && u.AccountPassword == Password
                       select new
                       {

                           AccountId = u.AccountId,
                           AccountUserName = u.AccountUserName,
                           AccountPassword = u.AccountPassword,
                           AccountEmail = u.AccountEmail,
                           AccountType = u.AccountType,
                           AccountName = u.AccountName,
                           Id = u.Id


                       }).Select(x => new UserAccountViewModel { AccountType = x.AccountType, AccountPassword = x.AccountPassword, AccountUserName = x.AccountUserName, AccountId = x.AccountId, AccountName = x.AccountName, Id = x.Id }).ToList();
            return get;
        }

        public List<UserAccountViewModel> geAlltUserAccount()
        {
            var get = (from u in app.UserAccounts

                       select new
                       {

                           AccountId = u.AccountId,
                           AccountUserName = u.AccountUserName,
                           AccountPassword = u.AccountPassword,
                           AccountEmail = u.AccountEmail,
                           AccountType = u.AccountType,
                           AccountName = u.AccountName,
                           Id = u.Id


                       }).Select(x => new UserAccountViewModel { AccountType = x.AccountType, AccountPassword = x.AccountPassword, AccountUserName = x.AccountUserName, AccountId = x.AccountId, AccountName = x.AccountName, Id = x.Id }).ToList();
            return get;
        }
    }
}
