using Daily_Diary.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daily_Diary.DesignLayer
{
    public partial class CreateEvents : Form


    {
        
        public CreateEvents()
        {

            InitializeComponent();
            //SubmitButton.Click += this.RefreshGridView;
        }





        /* private void timer1_Tick(object sender, EventArgs e)
         {
             label1.Text = DateTime.Now.ToString("MM/dd/yyyy");
         }
        */

        private void SubmitButton_Click(object sender, EventArgs e)

        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);
            connection.Open();

            string sql = "INSERT INTO t_events(EventTitle,EventDescripTion,EventType,EventDate) VALUES('" + EventTitleTextBox.Text + "','" + DescriptionTextBox.Text + "','" + MarkAsComboBox.Text + "','" + dateTimePicker1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("User added successfully.");
                EventTitleTextBox.Text = DescriptionTextBox.Text = MarkAsComboBox.Text = dateTimePicker1.Text = string.Empty;

                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();
            }



        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);
            connection.Open();

            string sql = "INSERT INTO t_events(EventTitle,EventDescripTion,EventType,EventDate) VALUES('" + EventTitleTextBox.Text + "','" + DescriptionTextBox.Text + "','" + MarkAsComboBox.Text + "','" + dateTimePicker1.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("Event added successfully.");
                EventTitleTextBox.Text = DescriptionTextBox.Text = MarkAsComboBox.Text = dateTimePicker1.Text = string.Empty;

                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();
            }

        }

        private void GotoDashboardButtoon_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }
    }
}

    
    

