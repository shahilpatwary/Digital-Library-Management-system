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

        public List<Event> GetEventList()
        {
            return this.EventDataAccess.GetAllEvent();
        }
    }
}
