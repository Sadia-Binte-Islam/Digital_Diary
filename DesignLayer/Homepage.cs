using Daily_Diary.BusinessLayer;
using Daily_Diary.DesignLayer;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }





        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(UserNameTextBox.Text, PasswordTextBox.Text);
                if (result)
                {
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");
                }
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}

