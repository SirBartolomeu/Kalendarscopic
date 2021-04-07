using System;
using System.Collections.Generic;
using System.Text;
using KalendarScopic.Web.Models;
using KalendarScopic.Web.DAL;

namespace KalendarScopic.Web.BLL
{
    public class UserBLL : IUserData
    {
        public User GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void New(User usr)
        {


            if (string.IsNullOrEmpty(usr.Email))
            {
                throw new ApplicationException("O e-mail precisa ser informado");
            }

            var dal = new UserDAL();

            dal.New(usr);

        }

        public void Update(User usr)
        {
            throw new NotImplementedException();
        }
    }
}
