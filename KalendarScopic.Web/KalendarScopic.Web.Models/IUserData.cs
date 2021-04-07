using System;
using System.Collections.Generic;
using System.Text;

namespace KalendarScopic.Web.Models
{
    public interface IUserData
    {
        void New(User usr);

        void Update(User usr);

        User GetByName(string name);
    }
}
