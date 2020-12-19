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
        
        
            EventAccess  eventAccess;
            public EventService()
            {
            EventAccess eventAccess = new EventAccess();
            }

            public List<Event> GetEventList()
            {
                return eventAccess.GetAllEvents();
            }
            /*public int AddNewProduct(string eventTitle, string eventDescription, string eventType, string UserName)
            {
                int UserId = EventAccess.GetUserId(UserName);
            Event e = new Event()
            {
                EventTitle = eventTitle,
                EventDescription = eventDescription,
                EventType = eventType,
                UserId = UserId,

                    
             };
                EventAccess eventAccess = new EventAccess();
                return eventAccess.CreateEvent(e);
            }*/
            
        }
    }

