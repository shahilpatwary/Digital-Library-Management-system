using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Entites
{
    class Note
    {
        public int NoteId { get; set; }
        public string NoteName { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Importance { get; set; }
        public string Description { get; set; }
        public int EventId { get; set; }
    }
}
