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
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }
    }
}
