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
                Event Event= new Event();
                Event.EventId = (int)reader["EventId"];
                Event.EventName = reader["EventName"].ToString();
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
            Event.EventName =reader["EventName"].ToString();
            
            return Event;
        }

        public int InsertEvent(Event Event)
        {
            string sql="INSERT INTO Events(EventName) VALUES('"+Event.EventName+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateEvent(Event Event)
        {
            string sql = "UPDATE Events SET EventName='" + Event.EventName + "' WHERE EventId='" + Event.EventId + "'";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteEvent(int id)
        {
            string sql = "DELETE FROM Event WHERE EventId="+id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<string> GetAllEventName()
        {
            string sql = "SELECT * FROM Events";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> events = new List<string>();
            while (reader.Read())
            {
                events.Add(reader["EventName"].ToString());
            }
            return events;
        }
    }
}
