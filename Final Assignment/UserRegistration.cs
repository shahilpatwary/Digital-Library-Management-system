using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Assignment
{
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioBatton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalAsserment"].ConnectionString);
            connection.Open();
            string gen = null;
            if(RadioBatton1.Checked)
            {
                gen = RadioBatton1.Text;
            }
            else
            {
                gen = radioButton1.Text;
            }
            String sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox5.Text+"','"+dateTimePicker1.Text+"','"+gen+"','"+comboBox1.Text+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
            if(result>0)
            {
                MessageBox.Show("User Added");
                textBox1.Text = textBox2.Text = textBox3.Text =textBox4.Text= textBox5.Text = dateTimePicker1.Text = comboBox1.Text = string.Empty;
                RadioBatton1.Checked = radioButton1.Checked = false;
            }
            else
            {
                MessageBox.Show("Enter All Value");
            }
        }

        
    }
}
