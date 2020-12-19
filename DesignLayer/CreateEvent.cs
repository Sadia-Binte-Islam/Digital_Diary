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
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        
        private void SubmitButton_Click(object sender, EventArgs e)

        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO events(EventTitle,EventDescription,EventType,Date) VALUES('" +EventTitleTextBox.Text + "','" + DescriptionTextBox.Text + "','" + MarkAsComboBox.Text + "',"+label1.Text+")";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("Event Added successfully.");
                EventTitleTextBox.Text = DescriptionTextBox.Text = MarkAsComboBox.Text = string.Empty;
                 

            }
            else
            {


                MessageBox.Show("Something Error!.");



            }
        }
    }
}
    
    

