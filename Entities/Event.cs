using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Diary.Entities
{
    class Event
    {
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string EventType { get; set; }
        public string EventDate { get; set; }
        public int UserId { get; set; }


    }
}
