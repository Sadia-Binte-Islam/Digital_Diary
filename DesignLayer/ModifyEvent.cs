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
    public partial class ModifyEvent : Form
    {
        public ModifyEvent()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);


        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void ModifyEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet4.t_events' table. You can move, or remove it, as needed.
           // this.t_eventsTableAdapter2.Fill(this.userDataSet4.t_events);
            // TODO: This line of code loads data into the 'userDataSet3.t_events' table. You can move, or remove it, as needed.
            this.t_eventsTableAdapter1.Fill(this.userDataSet3.t_events);
            // TODO: This line of code loads data into the 'userDataSet2.t_events' table. You can move, or remove it, as needed.
            this.t_eventsTableAdapter.Fill(this.userDataSet2.t_events);

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.guna2DataGridView2.Rows[e.RowIndex];
                    UpdateTitleTextBox.Text = row.Cells[1].Value.ToString();
                    UpdateDescription.Text = row.Cells[2].Value.ToString();
                    
                    MarkAsComboBox.Text = row.Cells[3].Value.ToString();
                    guna2DateTimePicker2.Text = row.Cells[5].Value.ToString();
                    UpdateEventId.Text = row.Cells[0].Value.ToString();
                }
            }
        }

        private void GoToButton_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();

                string sql = "UPDATE t_events SET EventTitle=@EventTitle,EventDescription=@EventDescription,EventType=@EventType,ModifyDate=@ModifyDate where EventID= '" + UpdateEventId.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@EventTitle", UpdateTitleTextBox.Text);
                command.Parameters.AddWithValue("@EventDescription", UpdateDescription.Text);
                command.Parameters.AddWithValue("@EventType", MarkAsComboBox.Text);
                command.Parameters.AddWithValue("@ModifyDate", guna2DateTimePicker2.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetValue()
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                string sql = "Select * From t_events";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader rdr = command.ExecuteReader();
                dt.Load(rdr);
                connection.Close();
                guna2DataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sql = "Delete from t_events where EventID = '" + UpdateEventId.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Delete Successfully", "Deleted",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
