using System;
using System.Collections.Generic;
using System.Text;

namespace KalendarScopic.Web.Models
{
    public interface IEventData
    {
        int New(Event evnt);

        void Update(Event evnt);

        void Delete(string usr);

        List<Event> GetUserEvents(string usr);

        List<GroupParticipant> GetParticipants(int id);

    }
}
