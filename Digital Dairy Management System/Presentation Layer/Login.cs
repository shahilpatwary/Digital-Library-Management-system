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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {
            if(UserNametextBox2.Text==""||UserPasswordtextBox3.Text=="")
            {
                MessageBox.Show("Meg and pass cant not be empty");
            }
            else
            {
                UserRegistrationService userRegistrationService = new UserRegistrationService();
                int id = userRegistrationService.LoginValidation(UserNametextBox2.Text, UserPasswordtextBox3.Text);
                if (id!=0)
                {
                    Event @event = new Event(this,id);
                    @event.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Meg and pass Invalid");
                }

            }

            
        }

        private void UserPasswordtextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UserPasswordtextBox3.Text = "";
            UserNametextBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
