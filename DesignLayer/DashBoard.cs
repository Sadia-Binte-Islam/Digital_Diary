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
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.t_events' table. You can move, or remove it, as needed.
            this.t_eventsTableAdapter.Fill(this.userDataSet.t_events);

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();

        }
    }
}
