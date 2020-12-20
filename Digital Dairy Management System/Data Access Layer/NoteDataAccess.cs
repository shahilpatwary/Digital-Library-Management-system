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

        public List<Note> GetAllNotes()
        {
            string sql = "SELECT * FROM Ntes";
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
                note.EventId = (int)reader["EventId"];
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
            note.EventId = (int)reader["EventId"];
              
            return note;

        }
        public int AddNewNote(Note note)
        {
            string sql = "INSERT INTO Ntes(NoteName,Title,Date,Importance,Description,EventId) VALUES('" + note.NoteName + "'.'"+note.Title+"','"+note.Date+"','"+note.Importance+"','"+note.Description+"','"+note.EventId+"')";
            return this.dataAccess.ExecuteQuery(sql);
        }

        

    }
}
