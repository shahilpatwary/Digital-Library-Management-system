using Digital_Dairy_Management_System.Data_Access_Layer;
using Digital_Dairy_Management_System.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Business_Layer
{
    class NoteService
    {
        NoteDataAccess noteDataAccess;

        public string NoteName { get; private set; }
        public int NoteId { get; set; }
       // public string NoteName { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Importance { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public NoteService()
        {
            this.noteDataAccess = new NoteDataAccess();
        }
        public List<Note> GetNoteList(int uid)
        {
            return this.noteDataAccess.GetAllNotes(uid);
        }
        public int AddNewNote(string noteName,string title,string date,string importance,string description,string EventName,int userId)
        {
            Note note = new Note();
            {
                NoteName = noteName;
                Title = title;
                Date = date;
                Importance = importance;
                Description = description;
                UserId = userId;

            }
            return this.noteDataAccess.AddNewNote(note);
        }


    }
}
