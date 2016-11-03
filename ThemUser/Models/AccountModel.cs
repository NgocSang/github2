using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Framework;
using System.Data.SqlClient;

namespace Models
{
    public class AccountModel
    {
        private github2DbContext context = null;

        public AccountModel()
        {
            context = new github2DbContext();
        }

        public bool Signup(string username, string password)
        {
            object[] sqlParms = 
            {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Signup @username,@password", sqlParms).SingleOrDefault();
            return res;
        }
    }
}
