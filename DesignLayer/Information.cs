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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }
    }
}
