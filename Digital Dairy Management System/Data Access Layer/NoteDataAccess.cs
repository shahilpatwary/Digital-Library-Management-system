using Digital_Dairy_Management_System.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Dairy_Management_System.Data_Access_Layer
{
    class NoteDataAccess
    {
        DataAccess dataAccess;
        public NoteDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Note> GetAllNotes(int uid)
        {
            string sql = "SELECT * FROM Ntes where UserId ="+uid;
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Note> notes = new List<Note>();
            while (reader.Read())
            {
                Note note = new Note();
                note.NoteId = (int)reader["NoteId"];
                note.NoteName = reader["NoteName"].ToString();
                note.Title = reader["Title"].ToString();
                note.Date = reader["Date"].ToString();
                note.Importance = reader["Importance"].ToString();
                note.Description = reader["Description"].ToString();
                note.UserId = (int)reader["UserId"];
                notes.Add(note);
            }
            return notes;

        }
        
        public Note GetNote(int id)
        {
            string sql = "SELECT * FROM Ntes WHERE NoteId=" +id; 
            SqlDataReader reader = dataAccess.GetData(sql);

            reader.Read();
            Note note = new Note();
            note.NoteId = (int)reader["NoteId"];
            note.NoteName = reader["NoteName"].ToString();
            note.Title = reader["Title"].ToString();
            note.Date = reader["Date"].ToString();
            note.Importance = reader["Importance"].ToString();
            note.Description = reader["Description"].ToString();
            note.UserId = (int)reader["EventId"];
              
            return note;

        }
        public int AddNewNote(Note note)
        {
            string sql = "INSERT INTO Ntes(NoteName,Title,Date,Importance,Description,UserId) VALUES('" + note.NoteName + "'.'"+note.Title+"','"+note.Date+"','"+note.Importance+"','"+note.Description+"','"+note.UserId+"')";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int GetEventId(string eventName)
        {
            string eventIdSearchSql = "SELECT * FROM Events WHERE EventName='" + eventName + "'";
            SqlDataReader reader = this.dataAccess.GetData(eventIdSearchSql);
            reader.Read();
            int UserId = (int)reader["UserId"];//error
            return UserId;

        }


    }
}
