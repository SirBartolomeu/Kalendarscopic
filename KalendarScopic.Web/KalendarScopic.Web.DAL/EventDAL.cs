using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using KalendarScopic.Web.Models;

namespace KalendarScopic.Web.DAL
{
    public class EventDAL : IEventData
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
            
           result = DBHelper.ExecuteNonQuery("NewEvent",
                   "@AuthorId", evnt.AuthorId,
                    "@Title" , evnt.Title,
                    "@Event_Description", evnt.Description,
                    "@Start_Time", evnt.StartTime,
                    "@End_Time", evnt.EndTime,
                    "@Tag", evnt.Tag,
                    "@IsGroup", evnt.IsGroup);

            return result;
        }

        public void Update(Event evnt)
        {
            throw new NotImplementedException();
        }
    }
}
