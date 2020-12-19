using Digital_Dairy_Management_System.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Data_Access_Layer
{
    class EventDataAccess
    {
        DataAccess dataAccess;
        public EventDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Event> GetAllEvent()
        {
            string sql = "SELECT * FROM Events";
            SqlDataReader reader= this.dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while(reader.Read())
            {
                Event Event=new Event();
                Event.EventId = (int)reader["EventId"];
                Event.EventName = (int)reader["EventName"];
                events.Add(Event);
            }
            return events;
        }
        public Event GetEvent(int id)
        {
            string sql = "SELECT * FROM Events WHERE EventId="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Event Event = new Event();
            Event.EventId = (int)reader["EventId"];
            Event.EventName = (int)reader["EventName"];
            
            return Event;
        }

    }
}
