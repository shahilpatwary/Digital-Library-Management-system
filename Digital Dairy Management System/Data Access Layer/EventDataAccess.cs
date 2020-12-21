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

        public List<Event> GetAllEvent(int id)
        {
            string sql = "SELECT * FROM Events where UserId = "+id;
            SqlDataReader reader= this.dataAccess.GetData(sql);
            List<Event> events = new List<Event>();
            while(reader.Read())
            {
                Event Event= new Event();
                Event.EventId = (int)reader["EventId"];
                Event.EventName = reader["EventName"].ToString();
                Event.UserId = (int)reader["UserId"];
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
            string sql="INSERT INTO Events(EventName,UserId) VALUES('"+Event.EventName+"','"+Event.UserId+"')";
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
            string sql = "DELETE FROM Events WHERE EventId="+id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<string> GetAllEventName(int id)
        {
            string sql = "SELECT * FROM Events where UserId = " + id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> events = new List<string>();
            while (reader.Read())
            {
                events.Add(reader["EventName"].ToString());
            }
            return events;
        }

        public List<Note> GetNotesByEvent(string eventName,int uid)
        {
            string eventIdSearchSql = "SELECT * FROM Events WHERE EventName='" + eventName + "' and UserId = '"+uid+"'";
            SqlDataReader reader = this.dataAccess.GetData(eventIdSearchSql);
            reader.Read();
            int EventId = (int)reader["EventId"];
            string sql = "SELECT * FROM Ntes WHERE  EventId=" + EventId;
            dataAccess = new DataAccess();
            reader = dataAccess.GetData(sql);
            List<Note> notes = new List<Note>();
            while(reader.Read())
            {
                Note note = new Note();
                note.NoteId = (int)reader["NoteId"];
                note.NoteName = reader["NoteName"].ToString();
                note.Title = reader["Title"].ToString();
                note.Date = reader["Date"].ToString();
                note.Importance = reader["Importance"].ToString();
                note.Description = reader["Description"].ToString();
                note.EventId = (int)reader["EventId"];
                note.UserId = (int)reader["UserId"];
                notes.Add(note);
            }
            return notes;
        }
    }
}
