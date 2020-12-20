using Daily_Diary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Diary.DesignLayer
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:MM tt");
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            CreateEvents createEvents = new CreateEvents();
            createEvents.Show();
            this.Hide();


        }

     
        private void DashBoard_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            EventLoadGridView.DataSource = eventService.GetAllEvents();
            eventService = new EventService();
            CategoryWiseEventComboBox.DataSource = eventService.GetAllEvents();


        }
        void RefreshGridView(object sender, EventArgs e)
        {
            EventService eventService= new EventService();
            EventLoadGridView.DataSource = eventService.GetAllEvents();
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {

            CreateEvents createEvents = new CreateEvents();
            createEvents.Show();
            this.Hide();


        }

        private void AboutUsBotton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Us admin@gmail.com"); 
        }
    }
}
