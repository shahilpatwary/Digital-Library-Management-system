using Digital_Dairy_Management_System.Data_Access_Layer;
using Digital_Dairy_Management_System.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Business_Layer
{
    class EventService
    {
        EventDataAccess EventDataAccess;
        public EventService()
        {
            this.EventDataAccess = new EventDataAccess();
        }

        public List<Event> GetEventList(int id)
        {
            return this.EventDataAccess.GetAllEvent(id);
        }

        public int AddNewEvent(string eventName,int id)
        {
            Event @event = new Event()
            {
                EventName = eventName,
                UserId = id
            };
            return this.EventDataAccess.InsertEvent(@event);
        }
        public int UpdateNewEvent(int id,string eventName)
        {
            Event @event = new Event()
            {
                EventId = id,
                EventName = eventName
            };
            return this.EventDataAccess.UpdateEvent(@event);
        }
        public int DeleteNewEvent(int id)
        {
            return this.EventDataAccess.DeleteEvent(id);
        }

        public List<string> GetEventNameList(int id)
        {
            return this.EventDataAccess.GetAllEventName(id);
        }
        public List<Note> GetNoteListByEvent(string eventName,int uid)
        {
            return this.EventDataAccess.GetNotesByEvent(eventName,uid);
        }
    }
}
