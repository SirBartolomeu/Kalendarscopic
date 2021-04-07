using System;
using System.Collections.Generic;
using System.Text;

namespace KalendarScopic.Web.Models
{
    public class GroupParticipant
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string ResponseStatus { get; set; }
    }
}
