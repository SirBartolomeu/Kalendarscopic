using System;
using System.Collections.Generic;
using System.Text;
using KalendarScopic.Web.Models;

namespace KalendarScopic.Web.DAL
{
    public class UserDAL : IUserData
    {
        public User GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void New(User usr)
        {
            DBHelper.ExecuteNonQuery("NewClient",
            "@Name", usr.Name,
            "@Email", usr.Email,
            "@Password", usr.Password);
        }

        public void Update(User usr)
        {
            throw new NotImplementedException();
        }
    }
}
