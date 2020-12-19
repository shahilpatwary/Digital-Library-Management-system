using Digital_Dairy_Management_System.Business_Layer;
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
    }
}
