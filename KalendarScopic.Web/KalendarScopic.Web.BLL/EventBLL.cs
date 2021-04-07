using System;
using System.Collections.Generic;
using System.Text;
using KalendarScopic.Web.Models;
using KalendarScopic.Web.DAL;

namespace KalendarScopic.Web.BLL
{
    public class EventBLL : IEventData
    {
        public void Delete(string usr)
        {
            throw new NotImplementedException();
        }

        public List<GroupParticipant> GetParticipants(int id)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetUserEvents(string usr)
        {
            throw new NotImplementedException();
        }

        public int New(Event evnt)
        {

            int result;

            var dal = new EventDAL();

            int rowInsert = dal.New(evnt);

            if (rowInsert < 1)
            {
                throw new ApplicationException("The event time is already scheaduled. Please chose another one.");
            }
            else
            {
                result = rowInsert;
            }

            return result;
        }

        public void Update(Event evnt)
        {
            throw new NotImplementedException();
        }
    }
}
