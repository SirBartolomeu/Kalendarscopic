using System;
using System.Collections.Generic;
using System.Text;

namespace KalendarScopic.Web.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Tag { get; set; }
        public char IsGroup { get; set; }

        //public List<GroupParticipant> Participants{get;set; }
    }
}
