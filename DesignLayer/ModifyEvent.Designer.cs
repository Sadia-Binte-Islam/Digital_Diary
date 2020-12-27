
namespace Daily_Diary.DesignLayer
{
    partial class ModifyEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyEvent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MarkAsComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EditButton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.EventTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateTitleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.GoToButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.teventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet3 = new Daily_Diary.UserDataSet3();
            this.teventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet2 = new Daily_Diary.UserDataSet2();
            this.t_eventsTableAdapter = new Daily_Diary.UserDataSet2TableAdapters.t_eventsTableAdapter();
            this.t_eventsTableAdapter1 = new Daily_Diary.UserDataSet3TableAdapters.t_eventsTableAdapter();
            this.t_eventsTableAdapter2 = new Daily_Diary.UserDataSet4TableAdapters.t_eventsTableAdapter();
            this.UpdateEventId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teventsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // MarkAsComboBox
            // 
            this.MarkAsComboBox.BackColor = System.Drawing.Color.Transparent;
            this.MarkAsComboBox.BorderRadius = 4;
            this.MarkAsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MarkAsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkAsComboBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.MarkAsComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MarkAsComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MarkAsComboBox.FocusedState.Parent = this.MarkAsComboBox;
            this.MarkAsComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MarkAsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MarkAsComboBox.HoverState.Parent = this.MarkAsComboBox;
            this.MarkAsComboBox.ItemHeight = 30;
            this.MarkAsComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Low"});
            this.MarkAsComboBox.ItemsAppearance.Parent = this.MarkAsComboBox;
            this.MarkAsComboBox.Location = new System.Drawing.Point(196, 279);
            this.MarkAsComboBox.Name = "MarkAsComboBox";
            this.MarkAsComboBox.ShadowDecoration.Parent = this.MarkAsComboBox;
            this.MarkAsComboBox.Size = new System.Drawing.Size(272, 36);
            this.MarkAsComboBox.StartIndex = 0;
            this.MarkAsComboBox.TabIndex = 6;
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(3, 86);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(187, 36);
            this.guna2DateTimePicker2.TabIndex = 17;
            this.guna2DateTimePicker2.UseTransparentBackground = true;
            this.guna2DateTimePicker2.Value = new System.DateTime(2020, 12, 26, 19, 17, 24, 642);
            this.guna2DateTimePicker2.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BorderColor = System.Drawing.Color.Honeydew;
            this.EditButton.BorderRadius = 10;
            this.EditButton.CheckedState.Parent = this.EditButton;
            this.EditButton.CustomImages.Parent = this.EditButton;
            this.EditButton.FillColor = System.Drawing.Color.LightSalmon;
            this.EditButton.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.EditButton.ForeColor = System.Drawing.Color.Black;
            this.EditButton.HoverState.Parent = this.EditButton;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EditButton.ImageSize = new System.Drawing.Size(35, 35);
            this.EditButton.Location = new System.Drawing.Point(474, 395);
            this.EditButton.Name = "EditButton";
            this.EditButton.ShadowDecoration.Parent = this.EditButton;
            this.EditButton.Size = new System.Drawing.Size(189, 42);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "Edit";
            this.EditButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EditButton.UseTransparentBackground = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderColor = System.Drawing.Color.Honeydew;
            this.DeleteButton.BorderRadius = 10;
            this.DeleteButton.CheckedState.Parent = this.DeleteButton;
            this.DeleteButton.CustomImages.Parent = this.DeleteButton;
            this.DeleteButton.FillColor = System.Drawing.Color.LightSalmon;
            this.DeleteButton.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.DeleteButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteButton.HoverState.Parent = this.DeleteButton;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeleteButton.ImageSize = new System.Drawing.Size(35, 35);
            this.DeleteButton.Location = new System.Drawing.Point(705, 395);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShadowDecoration.Parent = this.DeleteButton;
            this.DeleteButton.Size = new System.Drawing.Size(189, 42);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeleteButton.UseTransparentBackground = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(877, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(50, 24);
            this.guna2ControlBox2.TabIndex = 20;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(933, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(50, 24);
            this.guna2ControlBox1.TabIndex = 21;
            // 
            // EventTitle
            // 
            this.EventTitle.AutoSize = true;
            this.EventTitle.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventTitle.Location = new System.Drawing.Point(12, 51);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(160, 18);
            this.EventTitle.TabIndex = 22;
            this.EventTitle.Text = "Update Event Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update Event Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mark As:";
            // 
            // UpdateTitleTextBox
            // 
            this.UpdateTitleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateTitleTextBox.BorderRadius = 4;
            this.UpdateTitleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateTitleTextBox.DefaultText = "";
            this.UpdateTitleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpdateTitleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateTitleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateTitleTextBox.DisabledState.Parent = this.UpdateTitleTextBox;
            this.UpdateTitleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateTitleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateTitleTextBox.FocusedState.Parent = this.UpdateTitleTextBox;
            this.UpdateTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateTitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.UpdateTitleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateTitleTextBox.HoverState.Parent = this.UpdateTitleTextBox;
            this.UpdateTitleTextBox.Location = new System.Drawing.Point(196, 44);
            this.UpdateTitleTextBox.Name = "UpdateTitleTextBox";
            this.UpdateTitleTextBox.PasswordChar = '\0';
            this.UpdateTitleTextBox.PlaceholderText = "";
            this.UpdateTitleTextBox.SelectedText = "";
            this.UpdateTitleTextBox.ShadowDecoration.Parent = this.UpdateTitleTextBox;
            this.UpdateTitleTextBox.Size = new System.Drawing.Size(272, 36);
            this.UpdateTitleTextBox.TabIndex = 25;
            // 
            // UpdateDescription
            // 
            this.UpdateDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateDescription.BorderRadius = 4;
            this.UpdateDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateDescription.DefaultText = "";
            this.UpdateDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpdateDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateDescription.DisabledState.Parent = this.UpdateDescription;
            this.UpdateDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateDescription.FocusedState.Parent = this.UpdateDescription;
            this.UpdateDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateDescription.ForeColor = System.Drawing.Color.Black;
            this.UpdateDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateDescription.HoverState.Parent = this.UpdateDescription;
            this.UpdateDescription.Location = new System.Drawing.Point(196, 115);
            this.UpdateDescription.Name = "UpdateDescription";
            this.UpdateDescription.PasswordChar = '\0';
            this.UpdateDescription.PlaceholderText = "";
            this.UpdateDescription.SelectedText = "";
            this.UpdateDescription.ShadowDecoration.Parent = this.UpdateDescription;
            this.UpdateDescription.Size = new System.Drawing.Size(272, 130);
            this.UpdateDescription.TabIndex = 26;
            // 
            // GoToButton
            // 
            this.GoToButton.BorderColor = System.Drawing.Color.Transparent;
            this.GoToButton.BorderRadius = 4;
            this.GoToButton.CheckedState.Parent = this.GoToButton;
            this.GoToButton.CustomImages.Parent = this.GoToButton;
            this.GoToButton.FillColor = System.Drawing.Color.LightSalmon;
            this.GoToButton.Font = new System.Drawing.Font("JetBrains Mono", 12F);
            this.GoToButton.ForeColor = System.Drawing.Color.Black;
            this.GoToButton.HoverState.Parent = this.GoToButton;
            this.GoToButton.Image = global::Daily_Diary.Properties.Resources.template;
            this.GoToButton.Location = new System.Drawing.Point(15, 435);
            this.GoToButton.Name = "GoToButton";
            this.GoToButton.ShadowDecoration.Parent = this.GoToButton;
            this.GoToButton.Size = new System.Drawing.Size(193, 37);
            this.GoToButton.TabIndex = 27;
            this.GoToButton.Text = "Go to Dash Board";
            this.GoToButton.Click += new System.EventHandler(this.GoToButton_Click);
            // 
            // guna2DataGridView2
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView2.AutoGenerateColumns = false;
            this.guna2DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView2.ColumnHeadersHeight = 18;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventId,
            this.eventTitleDataGridViewTextBoxColumn,
            this.eventDescriptionDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.ModifyDate});
            this.guna2DataGridView2.DataSource = this.teventsBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView2.EnableHeadersVisualStyles = false;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(474, 32);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView2.Size = new System.Drawing.Size(500, 313);
            this.guna2DataGridView2.TabIndex = 28;
            this.guna2DataGridView2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(209)))), ((int)(((byte)(177)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 18;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellContentClick);
            // 
            // teventsBindingSource1
            // 
            this.teventsBindingSource1.DataMember = "t_events";
            this.teventsBindingSource1.DataSource = this.userDataSet3;
            // 
            // userDataSet3
            // 
            this.userDataSet3.DataSetName = "UserDataSet3";
            this.userDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teventsBindingSource
            // 
            this.teventsBindingSource.DataMember = "t_events";
            this.teventsBindingSource.DataSource = this.userDataSet2;
            // 
            // userDataSet2
            // 
            this.userDataSet2.DataSetName = "UserDataSet2";
            this.userDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_eventsTableAdapter
            // 
            this.t_eventsTableAdapter.ClearBeforeFill = true;
            // 
            // t_eventsTableAdapter1
            // 
            this.t_eventsTableAdapter1.ClearBeforeFill = true;
            // 
            // t_eventsTableAdapter2
            // 
            this.t_eventsTableAdapter2.ClearBeforeFill = true;
            // 
            // UpdateEventId
            // 
            this.UpdateEventId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateEventId.BorderRadius = 4;
            this.UpdateEventId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpdateEventId.DefaultText = "";
            this.UpdateEventId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpdateEventId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpdateEventId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateEventId.DisabledState.Parent = this.UpdateEventId;
            this.UpdateEventId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpdateEventId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateEventId.FocusedState.Parent = this.UpdateEventId;
            this.UpdateEventId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateEventId.ForeColor = System.Drawing.Color.Black;
            this.UpdateEventId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpdateEventId.HoverState.Parent = this.UpdateEventId;
            this.UpdateEventId.Location = new System.Drawing.Point(196, 349);
            this.UpdateEventId.Name = "UpdateEventId";
            this.UpdateEventId.PasswordChar = '\0';
            this.UpdateEventId.PlaceholderText = "";
            this.UpdateEventId.SelectedText = "";
            this.UpdateEventId.ShadowDecoration.Parent = this.UpdateEventId;
            this.UpdateEventId.Size = new System.Drawing.Size(272, 36);
            this.UpdateEventId.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Update Event Id";
            // 
            // EventId
            // 
            this.EventId.DataPropertyName = "EventId";
            this.EventId.HeaderText = "EventId";
            this.EventId.Name = "EventId";
            this.EventId.ReadOnly = true;
            // 
            // eventTitleDataGridViewTextBoxColumn
            // 
            this.eventTitleDataGridViewTextBoxColumn.DataPropertyName = "EventTitle";
            this.eventTitleDataGridViewTextBoxColumn.HeaderText = "EventTitle";
            this.eventTitleDataGridViewTextBoxColumn.Name = "eventTitleDataGridViewTextBoxColumn";
            // 
            // eventDescriptionDataGridViewTextBoxColumn
            // 
            this.eventDescriptionDataGridViewTextBoxColumn.DataPropertyName = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.HeaderText = "EventDescription";
            this.eventDescriptionDataGridViewTextBoxColumn.Name = "eventDescriptionDataGridViewTextBoxColumn";
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "EventType";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // ModifyDate
            // 
            this.ModifyDate.DataPropertyName = "ModifyDate";
            this.ModifyDate.HeaderText = "ModifyDate";
            this.ModifyDate.Name = "ModifyDate";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // ModifyEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(995, 518);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateEventId);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.GoToButton);
            this.Controls.Add(this.UpdateDescription);
            this.Controls.Add(this.UpdateTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventTitle);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.MarkAsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyEvent";
            this.Load += new System.EventHandler(this.ModifyEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teventsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox MarkAsComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2Button EditButton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label EventTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox UpdateTitleTextBox;
        private Guna.UI2.WinForms.Guna2TextBox UpdateDescription;
        private Guna.UI2.WinForms.Guna2Button GoToButton;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private UserDataSet2 userDataSet2;
        private System.Windows.Forms.BindingSource teventsBindingSource;
        private UserDataSet2TableAdapters.t_eventsTableAdapter t_eventsTableAdapter;
        private UserDataSet3 userDataSet3;
        private System.Windows.Forms.BindingSource teventsBindingSource1;
        private UserDataSet3TableAdapters.t_eventsTableAdapter t_eventsTableAdapter1;
        private UserDataSet4TableAdapters.t_eventsTableAdapter t_eventsTableAdapter2;
        private Guna.UI2.WinForms.Guna2TextBox UpdateEventId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifyDate;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}