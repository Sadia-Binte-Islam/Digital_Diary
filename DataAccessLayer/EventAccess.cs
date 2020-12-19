using Daily_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Diary.DataAccessLayer
{
    class EventAccess
    {
        
        DataAccess dataAccess;
            public EventAccess()
            {
                this.dataAccess = new DataAccess();
            }
            public List<Event> GetAllEvents()
            {
                string sql = "SELECT * FROM events";
                this.dataAccess = new DataAccess();
                SqlDataReader reader = this.dataAccess.GetData(sql);
                List<Event> events = new List<Event>();
                while (reader.Read())
                {
                    Event e = new Event();
                    e.UserId = (int)reader["UserId"];
                    e.EventTitle = reader["EventTitle"].ToString();
                    e.EventDescription = reader["EventDescription"].ToString();
                    e.EventType= reader["EventType"].ToString();


                    events.Add(e);
                }
                return events;
            }

            public int CreateEvent(Event e)
            {
                string sql = "INSERT INTO events(EventTitle,EventDescription,EventType,UserId) VALUES('" + e.EventTitle + "','" + e.EventDescription + "','" +e.EventType  + "'," + e.UserId + ")";
                return this.dataAccess.ExecuteQuery(sql);
            }

            public int GetUserId(string userName)
            {
                string sql = "SELECT * FROM t_users WHERE UserName='" + userName + "'";
                SqlDataReader reader = this.dataAccess.GetData(sql);
                reader.Read();
                return (int)reader["UserId"];
            }
            
        }
    }

