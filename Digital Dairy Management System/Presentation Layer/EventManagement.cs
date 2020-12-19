﻿using Digital_Dairy_Management_System.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Dairy_Management_System.Presentation_Layer
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            AddEventbutton1.Click += this.RefreshGridView;
            UpdateEventbutton1.Click += this.RefreshGridView;
            DeleteEventbutton1.Click += this.RefreshGridView;
        }

        private void Event_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Event_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            LoadEventdataGridView1.DataSource = eventService.GetEventList();
        }

        private void RefreshGridView(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            LoadEventdataGridView1.DataSource = eventService.GetEventList();
        }
        private void ClearInputFields()
        {
            AddEventtextBox1.Text =UpdateEventNametextBox1.Text=DeleteEventtextBox1.Text =string.Empty;
        }

        private void AddEventbutton1_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.AddNewEvent(AddEventtextBox1.Text);
            if(result>0)
            {
                MessageBox.Show("New Event Added");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Server Error");
            }

        }
        int id = 0;
        private void LoadEventdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =(int) LoadEventdataGridView1.Rows[e.RowIndex].Cells[0].Value;
            UpdateEventNametextBox1.Text = LoadEventdataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void UpdateEventbutton1_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.UpdateNewEvent(id,UpdateEventNametextBox1.Text);
            if (result > 0)
            {
                MessageBox.Show("Event Updated");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Update Server Error");
            }

        }

        private void DeleteEventbutton1_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.DeleteNewEvent(Convert.ToInt32(DeleteEventtextBox1.Text));
            if (result > 0)
            {
                MessageBox.Show("Event Deleted");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Delete Server Error");
            }

        }
    }
}
