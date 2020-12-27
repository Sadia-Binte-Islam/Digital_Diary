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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);
            connection.Open();
            
            string sql = "INSERT INTO t_events (EventTitle,EventDescription,EventType,EventDate,EventPicture) VALUES('" + EventTitleTextBox.Text + "','" + DescriptionTextBox.Text + "','" + MarkAsComboBox.Text + "','"+guna2DateTimePicker2.Text+"','"+EventPictureBox.Image+"')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("Event added successfully.");
                EventTitleTextBox.Text = DescriptionTextBox.Text = MarkAsComboBox.Text =guna2DateTimePicker2.Text= string.Empty;

                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();

            }
            else
            {


                MessageBox.Show("Error in Event Creation");



            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);
            connection1.Open();

            string sql = "UPDATE t_events SET EventTitle='" + EventTitleTextBox.Text + "',EventDescription='" + DescriptionTextBox.Text + "',EventType='" + MarkAsComboBox.Text + "',EventDate='" + guna2DateTimePicker1.Text + "'Where EventTitle='" + EventTitleTextBox.Text + "'";
            SqlCommand command = new SqlCommand(sql, connection1);

            int result = command.ExecuteNonQuery();
            connection1.Close();
            if (result > 0)
            {
                MessageBox.Show("Event added successfully.");
                EventTitleTextBox.Text = DescriptionTextBox.Text = MarkAsComboBox.Text = guna2DateTimePicker1.Text = string.Empty;

                DashBoard dashBoard = new DashBoard();
                dashBoard.Show();
                this.Hide();

            }
            else
            {


                MessageBox.Show("Error in Event Creation");



            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png)|*.jpg;*.png ";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                EventPictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
    }

