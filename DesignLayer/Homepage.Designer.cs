﻿
namespace Daily_Diary
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signInButton = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.signUpButton);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.signInButton);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.UserNameTextBox);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.userNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(403, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Do not Have an account??";
            // 
            // signUpButton
            // 
            this.signUpButton.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.BorderRadius = 4;
            this.signUpButton.CheckedState.Parent = this.signUpButton;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.CustomImages.Parent = this.signUpButton;
            this.signUpButton.FillColor = System.Drawing.Color.RosyBrown;
            this.signUpButton.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.Black;
            this.signUpButton.HoverState.Parent = this.signUpButton;
            this.signUpButton.Location = new System.Drawing.Point(139, 344);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.ShadowDecoration.Parent = this.signUpButton;
            this.signUpButton.Size = new System.Drawing.Size(235, 45);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Daily_Diary.Properties.Resources.user_male_circle;
            this.pictureBox1.Location = new System.Drawing.Point(200, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // signInButton
            // 
            this.signInButton.BorderColor = System.Drawing.Color.DarkGray;
            this.signInButton.BorderRadius = 4;
            this.signInButton.CheckedState.Parent = this.signInButton;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.CustomImages.Parent = this.signInButton;
            this.signInButton.FillColor = System.Drawing.Color.RosyBrown;
            this.signInButton.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.Black;
            this.signInButton.HoverState.Parent = this.signInButton;
            this.signInButton.Location = new System.Drawing.Point(139, 247);
            this.signInButton.Name = "signInButton";
            this.signInButton.ShadowDecoration.Parent = this.signInButton;
            this.signInButton.Size = new System.Drawing.Size(235, 45);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign In";
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.BorderRadius = 4;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.FocusedState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.HoverState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Location = new System.Drawing.Point(146, 173);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderText = "";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Size = new System.Drawing.Size(235, 38);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.UserNameTextBox.BorderRadius = 4;
            this.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTextBox.DefaultText = "";
            this.UserNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTextBox.DisabledState.Parent = this.UserNameTextBox;
            this.UserNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTextBox.FocusedState.Parent = this.UserNameTextBox;
            this.UserNameTextBox.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTextBox.HoverState.Parent = this.UserNameTextBox;
            this.UserNameTextBox.Location = new System.Drawing.Point(146, 111);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.PlaceholderText = "";
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.ShadowDecoration.Parent = this.UserNameTextBox;
            this.UserNameTextBox.Size = new System.Drawing.Size(235, 36);
            this.UserNameTextBox.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(37, 181);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(88, 18);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password :";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(29, 119);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(96, 18);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Digital Writing Platform";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderThickness = 1;
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.CustomImages.Parent = this.CloseButton;
            this.CloseButton.FillColor = System.Drawing.Color.Transparent;
            this.CloseButton.Font = new System.Drawing.Font("JetBrains Mono Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.Location = new System.Drawing.Point(799, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(54, 28);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(761, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2PictureBox1.Image = global::Daily_Diary.Properties.Resources.OIP;
            this.guna2PictureBox1.Location = new System.Drawing.Point(65, 185);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(278, 274);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(854, 581);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox UserNameTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private Guna.UI2.WinForms.Guna2Button signInButton;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button signUpButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}

