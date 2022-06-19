using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Dapper;

namespace DAL
{
    public class UsersDAL
    {
        public static Users CheckLogin(Users obj)
        {
            string sqlQuery = "SELECT Password, Username FROM Users WHERE(Password = N'admin') AND (Username = N'admin')";
            using (var con = ConnectionUtil.GetConnection())
            {
                return con.Query<Users>(sqlQuery, obj).FirstOrDefault();
            }
        }
    }
}
