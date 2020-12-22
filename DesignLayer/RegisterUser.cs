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

namespace Daily_Diary
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        

        

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["User"].ConnectionString);
            connection.Open();
            string gen = null;
            if (MaleGenderButton.Checked)
            {
                gen = MaleGenderButton.Text;
            }
            else
            {
                gen = FemaleGenderButton.Text;
            }
            string sql = "INSERT INTO t_users(Username,FullName,Password,Email,DateOfBirth,Gender) VALUES('" + UserNameTextBox.Text + "','"+FullNameTextBox.Text + "','" + PasswordTextBox.Text + "','" + EmailTextBox.Text + "','" + DateOfBirthDateTimePacker.Text + "','" + gen + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            
            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("User added successfully.");
                FullNameTextBox.Text = UserNameTextBox.Text = EmailTextBox.Text = PasswordTextBox.Text = ConfirmPasswordTextBox.Text = DateOfBirthDateTimePacker.Text = string.Empty;
               MaleGenderButton.Checked = FemaleGenderButton.Checked = false;
                HomePage home = new HomePage();
                home.Show();
                this.Hide();
            
            }
            else
            {
               
                
                MessageBox.Show("Error in user adding.");
          
            
            
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
    }

