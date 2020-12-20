using Daily_Diary.DataAccessLayer;
using Daily_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Diary.BusinessLayer
{
    class EventService
    {


              EventAccess eventAccess;
            public EventService()
            {
            EventAccess eventAccess = new EventAccess();
            }

            public List<Event> GetAllEvents()
            {
                return eventAccess.GetAllEvents();
            }
            
        public List<Event> GetProductListForSearch(string eventType)
        {
            return this.eventAccess.GetEventsForSearch(eventType);
        }

    }
    }

