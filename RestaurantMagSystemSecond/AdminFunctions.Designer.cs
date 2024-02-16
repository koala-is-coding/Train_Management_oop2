namespace RestaurantMagSystemSecond
{
    partial class AdminFunctions
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
            ShowTablesDGV = new DataGridView();
            panel1 = new Panel();
            ShowResBtn = new Button();
            ShowPaymentBtn = new Button();
            DisplayMenuBtn = new Button();
            ManageReserBtn = new Button();
            AddAdmin = new Button();
            ShowLogInTableBtn = new Button();
            ShowAdminsBtn = new Button();
            ShowUsersBtn = new Button();
            ActivateuserBtn = new Button();
            UpdateUsersBtn = new Button();
            UserActivationPanel = new Panel();
            ActivateBtn = new Button();
            LoadUsersBtn = new Button();
            label1 = new Label();
            AllUsersCB = new ComboBox();
            UpdateUserPanel = new Panel();
            UpdateUserBtn = new Button();
            UpLocTF = new TextBox();
            UpCityCB = new ComboBox();
            UpMnoTF = new TextBox();
            UpNameTF = new TextBox();
            AddAdminPanel = new Panel();
            AddAdminBtn = new Button();
            AdRoleCB = new ComboBox();
            AddAdminWorkFieldTF = new TextBox();
            AddAdminPassTF = new TextBox();
            AddAdminnameTF = new TextBox();
            ReturnBtn = new Button();
            ManageReservationsPanel = new Panel();
            label8 = new Label();
            ResDateTF = new TextBox();
            ConfirmAppointBtn = new Button();
            TableNoCB = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            EndTimeTF = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            LoaadResBtn = new Button();
            PendingResCB = new ComboBox();
            label2 = new Label();
            StartTimeTF = new TextBox();
            panel2 = new Panel();
            UpdateMenuBtn = new Button();
            UpdateFoodItemPanel = new Panel();
            UpMenuBtnInPAnel = new Button();
            ItemDesTF = new TextBox();
            ItemPriceTF = new TextBox();
            ItemNameTF = new TextBox();
            panel3 = new Panel();
            DltUserBtn = new Button();
            DltAdminBtn = new Button();
            DltAdTF = new TextBox();
            DltAdBtn = new Button();
            label9 = new Label();
            DeleteAdPanel = new Panel();
            DeleteUserPanel = new Panel();
            label10 = new Label();
            DeleteUserBtn = new Button();
            DltUserTF = new TextBox();
            ShowUserBankRelatedBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ShowTablesDGV).BeginInit();
            panel1.SuspendLayout();
            UserActivationPanel.SuspendLayout();
            UpdateUserPanel.SuspendLayout();
            AddAdminPanel.SuspendLayout();
            ManageReservationsPanel.SuspendLayout();
            panel2.SuspendLayout();
            UpdateFoodItemPanel.SuspendLayout();
            panel3.SuspendLayout();
            DeleteAdPanel.SuspendLayout();
            DeleteUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ShowTablesDGV
            // 
            ShowTablesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ShowTablesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowTablesDGV.Location = new Point(897, 21);
            ShowTablesDGV.Name = "ShowTablesDGV";
            ShowTablesDGV.Size = new Size(574, 485);
            ShowTablesDGV.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(ShowUserBankRelatedBtn);
            panel1.Controls.Add(ShowResBtn);
            panel1.Controls.Add(ShowPaymentBtn);
            panel1.Controls.Add(DisplayMenuBtn);
            panel1.Controls.Add(ManageReserBtn);
            panel1.Controls.Add(AddAdmin);
            panel1.Controls.Add(ShowLogInTableBtn);
            panel1.Controls.Add(ShowAdminsBtn);
            panel1.Controls.Add(ShowUsersBtn);
            panel1.Controls.Add(ActivateuserBtn);
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 537);
            panel1.TabIndex = 2;
            // 
            // ShowResBtn
            // 
            ShowResBtn.BackColor = SystemColors.Info;
            ShowResBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowResBtn.Location = new Point(57, 330);
            ShowResBtn.Name = "ShowResBtn";
            ShowResBtn.Size = new Size(131, 49);
            ShowResBtn.TabIndex = 23;
            ShowResBtn.Text = "Show Reservation table";
            ShowResBtn.UseVisualStyleBackColor = false;
            ShowResBtn.Click += ShowResBtn_Click;
            // 
            // ShowPaymentBtn
            // 
            ShowPaymentBtn.BackColor = SystemColors.Info;
            ShowPaymentBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPaymentBtn.Location = new Point(57, 279);
            ShowPaymentBtn.Name = "ShowPaymentBtn";
            ShowPaymentBtn.Size = new Size(131, 35);
            ShowPaymentBtn.TabIndex = 22;
            ShowPaymentBtn.Text = "Show Payment table";
            ShowPaymentBtn.UseVisualStyleBackColor = false;
            ShowPaymentBtn.Click += ShowPaymentBtn_Click;
            // 
            // DisplayMenuBtn
            // 
            DisplayMenuBtn.BackColor = SystemColors.Info;
            DisplayMenuBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayMenuBtn.Location = new Point(57, 238);
            DisplayMenuBtn.Name = "DisplayMenuBtn";
            DisplayMenuBtn.Size = new Size(131, 35);
            DisplayMenuBtn.TabIndex = 21;
            DisplayMenuBtn.Text = "Show FoodMenu table";
            DisplayMenuBtn.UseVisualStyleBackColor = false;
            DisplayMenuBtn.Click += DisplayMenuBtn_Click;
            // 
            // ManageReserBtn
            // 
            ManageReserBtn.BackColor = SystemColors.Info;
            ManageReserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManageReserBtn.Location = new Point(42, 61);
            ManageReserBtn.Name = "ManageReserBtn";
            ManageReserBtn.Size = new Size(156, 35);
            ManageReserBtn.TabIndex = 20;
            ManageReserBtn.Text = "Manage Reservation";
            ManageReserBtn.UseVisualStyleBackColor = false;
            ManageReserBtn.Click += ManageReserBtn_Click;
            // 
            // AddAdmin
            // 
            AddAdmin.BackColor = SystemColors.Info;
            AddAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAdmin.Location = new Point(57, 491);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(131, 35);
            AddAdmin.TabIndex = 19;
            AddAdmin.Text = "Add Admin";
            AddAdmin.UseVisualStyleBackColor = false;
            AddAdmin.Click += AddAdmin_Click;
            // 
            // ShowLogInTableBtn
            // 
            ShowLogInTableBtn.BackColor = SystemColors.Info;
            ShowLogInTableBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowLogInTableBtn.Location = new Point(57, 197);
            ShowLogInTableBtn.Name = "ShowLogInTableBtn";
            ShowLogInTableBtn.Size = new Size(131, 35);
            ShowLogInTableBtn.TabIndex = 18;
            ShowLogInTableBtn.Text = "Show LogInTable";
            ShowLogInTableBtn.UseVisualStyleBackColor = false;
            ShowLogInTableBtn.Click += ShowLogInTableBtn_Click;
            // 
            // ShowAdminsBtn
            // 
            ShowAdminsBtn.BackColor = SystemColors.Info;
            ShowAdminsBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowAdminsBtn.Location = new Point(57, 156);
            ShowAdminsBtn.Name = "ShowAdminsBtn";
            ShowAdminsBtn.Size = new Size(131, 35);
            ShowAdminsBtn.TabIndex = 16;
            ShowAdminsBtn.Text = "Show Admins";
            ShowAdminsBtn.UseVisualStyleBackColor = false;
            ShowAdminsBtn.Click += ShowAdminsBtn_Click;
            // 
            // ShowUsersBtn
            // 
            ShowUsersBtn.BackColor = SystemColors.Info;
            ShowUsersBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowUsersBtn.Location = new Point(57, 115);
            ShowUsersBtn.Name = "ShowUsersBtn";
            ShowUsersBtn.Size = new Size(131, 35);
            ShowUsersBtn.TabIndex = 15;
            ShowUsersBtn.Text = "Show Users";
            ShowUsersBtn.UseVisualStyleBackColor = false;
            ShowUsersBtn.Click += ShowUsersBtn_Click;
            // 
            // ActivateuserBtn
            // 
            ActivateuserBtn.BackColor = SystemColors.Info;
            ActivateuserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActivateuserBtn.Location = new Point(57, 20);
            ActivateuserBtn.Name = "ActivateuserBtn";
            ActivateuserBtn.Size = new Size(131, 35);
            ActivateuserBtn.TabIndex = 14;
            ActivateuserBtn.Text = "Activate user";
            ActivateuserBtn.UseVisualStyleBackColor = false;
            ActivateuserBtn.Click += ActivateuserBtn_Click;
            // 
            // UpdateUsersBtn
            // 
            UpdateUsersBtn.BackColor = SystemColors.Info;
            UpdateUsersBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateUsersBtn.Location = new Point(57, 22);
            UpdateUsersBtn.Name = "UpdateUsersBtn";
            UpdateUsersBtn.Size = new Size(131, 35);
            UpdateUsersBtn.TabIndex = 17;
            UpdateUsersBtn.Text = "Update User";
            UpdateUsersBtn.UseVisualStyleBackColor = false;
            UpdateUsersBtn.Click += UpdateUsersBtn_Click;
            // 
            // UserActivationPanel
            // 
            UserActivationPanel.BackColor = Color.LemonChiffon;
            UserActivationPanel.Controls.Add(ActivateBtn);
            UserActivationPanel.Controls.Add(LoadUsersBtn);
            UserActivationPanel.Controls.Add(label1);
            UserActivationPanel.Controls.Add(AllUsersCB);
            UserActivationPanel.Location = new Point(248, 33);
            UserActivationPanel.Name = "UserActivationPanel";
            UserActivationPanel.Size = new Size(386, 211);
            UserActivationPanel.TabIndex = 3;
            // 
            // ActivateBtn
            // 
            ActivateBtn.BackColor = Color.Teal;
            ActivateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActivateBtn.Location = new Point(132, 153);
            ActivateBtn.Name = "ActivateBtn";
            ActivateBtn.Size = new Size(119, 35);
            ActivateBtn.TabIndex = 16;
            ActivateBtn.Text = "Activate";
            ActivateBtn.UseVisualStyleBackColor = false;
            ActivateBtn.Click += ActivateBtn_Click;
            // 
            // LoadUsersBtn
            // 
            LoadUsersBtn.BackColor = SystemColors.Info;
            LoadUsersBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadUsersBtn.Location = new Point(255, 73);
            LoadUsersBtn.Name = "LoadUsersBtn";
            LoadUsersBtn.Size = new Size(119, 35);
            LoadUsersBtn.TabIndex = 15;
            LoadUsersBtn.Text = "Load Users";
            LoadUsersBtn.UseVisualStyleBackColor = false;
            LoadUsersBtn.Click += LoadUsersBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 15);
            label1.Name = "label1";
            label1.Size = new Size(316, 40);
            label1.TabIndex = 11;
            label1.Text = "Select a user from the following drop-down menu\r\n(Click 'Load Users' to See UserList )";
            label1.Click += label1_Click;
            // 
            // AllUsersCB
            // 
            AllUsersCB.BackColor = SystemColors.Info;
            AllUsersCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllUsersCB.FormattingEnabled = true;
            AllUsersCB.Location = new Point(44, 77);
            AllUsersCB.Name = "AllUsersCB";
            AllUsersCB.Size = new Size(194, 28);
            AllUsersCB.TabIndex = 10;
            AllUsersCB.SelectedIndexChanged += AllUsersCB_SelectedIndexChanged;
            // 
            // UpdateUserPanel
            // 
            UpdateUserPanel.BackColor = Color.LightGoldenrodYellow;
            UpdateUserPanel.Controls.Add(UpdateUserBtn);
            UpdateUserPanel.Controls.Add(UpLocTF);
            UpdateUserPanel.Controls.Add(UpCityCB);
            UpdateUserPanel.Controls.Add(UpMnoTF);
            UpdateUserPanel.Controls.Add(UpNameTF);
            UpdateUserPanel.Location = new Point(248, 250);
            UpdateUserPanel.Name = "UpdateUserPanel";
            UpdateUserPanel.Size = new Size(251, 341);
            UpdateUserPanel.TabIndex = 4;
            UpdateUserPanel.Paint += panel2_Paint;
            // 
            // UpdateUserBtn
            // 
            UpdateUserBtn.BackColor = SystemColors.Info;
            UpdateUserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateUserBtn.Location = new Point(69, 262);
            UpdateUserBtn.Name = "UpdateUserBtn";
            UpdateUserBtn.Size = new Size(119, 35);
            UpdateUserBtn.TabIndex = 15;
            UpdateUserBtn.Text = "Update user";
            UpdateUserBtn.UseVisualStyleBackColor = false;
            UpdateUserBtn.Click += UpdateUserBtn_Click;
            // 
            // UpLocTF
            // 
            UpLocTF.BackColor = Color.Cornsilk;
            UpLocTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpLocTF.Location = new Point(27, 195);
            UpLocTF.Multiline = true;
            UpLocTF.Name = "UpLocTF";
            UpLocTF.PlaceholderText = "Location";
            UpLocTF.Size = new Size(194, 51);
            UpLocTF.TabIndex = 13;
            // 
            // UpCityCB
            // 
            UpCityCB.BackColor = SystemColors.Info;
            UpCityCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpCityCB.FormattingEnabled = true;
            UpCityCB.Items.AddRange(new object[] { "Dhaka", "Rajshahi", "Chittagong", "Gazipur", "Narayanganj", "Sylhet", "Bogura" });
            UpCityCB.Location = new Point(27, 146);
            UpCityCB.Name = "UpCityCB";
            UpCityCB.Size = new Size(194, 28);
            UpCityCB.TabIndex = 10;
            UpCityCB.Text = "City";
            // 
            // UpMnoTF
            // 
            UpMnoTF.BackColor = Color.Cornsilk;
            UpMnoTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpMnoTF.Location = new Point(27, 88);
            UpMnoTF.Multiline = true;
            UpMnoTF.Name = "UpMnoTF";
            UpMnoTF.PlaceholderText = "Mobile number";
            UpMnoTF.Size = new Size(194, 35);
            UpMnoTF.TabIndex = 9;
            // 
            // UpNameTF
            // 
            UpNameTF.BackColor = Color.Cornsilk;
            UpNameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpNameTF.Location = new Point(27, 32);
            UpNameTF.Multiline = true;
            UpNameTF.Name = "UpNameTF";
            UpNameTF.PlaceholderText = "Username";
            UpNameTF.Size = new Size(194, 35);
            UpNameTF.TabIndex = 6;
            // 
            // AddAdminPanel
            // 
            AddAdminPanel.BackColor = SystemColors.Info;
            AddAdminPanel.Controls.Add(AddAdminBtn);
            AddAdminPanel.Controls.Add(AdRoleCB);
            AddAdminPanel.Controls.Add(AddAdminWorkFieldTF);
            AddAdminPanel.Controls.Add(AddAdminPassTF);
            AddAdminPanel.Controls.Add(AddAdminnameTF);
            AddAdminPanel.Location = new Point(248, 597);
            AddAdminPanel.Name = "AddAdminPanel";
            AddAdminPanel.Size = new Size(251, 297);
            AddAdminPanel.TabIndex = 5;
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.BackColor = SystemColors.Info;
            AddAdminBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAdminBtn.Location = new Point(59, 250);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(119, 35);
            AddAdminBtn.TabIndex = 16;
            AddAdminBtn.Text = "Add Admin";
            AddAdminBtn.UseVisualStyleBackColor = false;
            AddAdminBtn.Click += AddAdminBtn_Click;
            // 
            // AdRoleCB
            // 
            AdRoleCB.BackColor = SystemColors.Info;
            AdRoleCB.Enabled = false;
            AdRoleCB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdRoleCB.FormattingEnabled = true;
            AdRoleCB.Items.AddRange(new object[] { "User", "Admin", "Driver" });
            AdRoleCB.Location = new Point(22, 145);
            AdRoleCB.Name = "AdRoleCB";
            AdRoleCB.Size = new Size(194, 29);
            AdRoleCB.TabIndex = 11;
            AdRoleCB.Text = "Admin";
            // 
            // AddAdminWorkFieldTF
            // 
            AddAdminWorkFieldTF.BackColor = Color.Cornsilk;
            AddAdminWorkFieldTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAdminWorkFieldTF.Location = new Point(22, 195);
            AddAdminWorkFieldTF.Multiline = true;
            AddAdminWorkFieldTF.Name = "AddAdminWorkFieldTF";
            AddAdminWorkFieldTF.PlaceholderText = "Admin WorkField";
            AddAdminWorkFieldTF.Size = new Size(194, 35);
            AddAdminWorkFieldTF.TabIndex = 7;
            // 
            // AddAdminPassTF
            // 
            AddAdminPassTF.BackColor = Color.Cornsilk;
            AddAdminPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAdminPassTF.Location = new Point(22, 88);
            AddAdminPassTF.Multiline = true;
            AddAdminPassTF.Name = "AddAdminPassTF";
            AddAdminPassTF.PlaceholderText = "Admin password";
            AddAdminPassTF.Size = new Size(194, 35);
            AddAdminPassTF.TabIndex = 8;
            // 
            // AddAdminnameTF
            // 
            AddAdminnameTF.BackColor = Color.Cornsilk;
            AddAdminnameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAdminnameTF.Location = new Point(22, 32);
            AddAdminnameTF.Multiline = true;
            AddAdminnameTF.Name = "AddAdminnameTF";
            AddAdminnameTF.PlaceholderText = "Admin Name";
            AddAdminnameTF.Size = new Size(194, 35);
            AddAdminnameTF.TabIndex = 7;
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnBtn.Location = new Point(682, 33);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(168, 35);
            ReturnBtn.TabIndex = 17;
            ReturnBtn.Text = "Return to LogIn page";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // ManageReservationsPanel
            // 
            ManageReservationsPanel.BackColor = Color.PaleGoldenrod;
            ManageReservationsPanel.Controls.Add(label8);
            ManageReservationsPanel.Controls.Add(ResDateTF);
            ManageReservationsPanel.Controls.Add(ConfirmAppointBtn);
            ManageReservationsPanel.Controls.Add(TableNoCB);
            ManageReservationsPanel.Controls.Add(label7);
            ManageReservationsPanel.Controls.Add(label6);
            ManageReservationsPanel.Controls.Add(EndTimeTF);
            ManageReservationsPanel.Controls.Add(label5);
            ManageReservationsPanel.Controls.Add(label4);
            ManageReservationsPanel.Controls.Add(label3);
            ManageReservationsPanel.Controls.Add(LoaadResBtn);
            ManageReservationsPanel.Controls.Add(PendingResCB);
            ManageReservationsPanel.Controls.Add(label2);
            ManageReservationsPanel.Controls.Add(StartTimeTF);
            ManageReservationsPanel.Location = new Point(505, 250);
            ManageReservationsPanel.Name = "ManageReservationsPanel";
            ManageReservationsPanel.Size = new Size(370, 401);
            ManageReservationsPanel.TabIndex = 18;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 127);
            label8.Name = "label8";
            label8.Size = new Size(117, 27);
            label8.TabIndex = 26;
            label8.Text = "Reservation Date";
            // 
            // ResDateTF
            // 
            ResDateTF.BackColor = Color.Cornsilk;
            ResDateTF.Enabled = false;
            ResDateTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResDateTF.Location = new Point(126, 122);
            ResDateTF.Multiline = true;
            ResDateTF.Name = "ResDateTF";
            ResDateTF.Size = new Size(226, 28);
            ResDateTF.TabIndex = 25;
            ResDateTF.TextChanged += ResDateTF_TextChanged;
            // 
            // ConfirmAppointBtn
            // 
            ConfirmAppointBtn.BackColor = SystemColors.Info;
            ConfirmAppointBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmAppointBtn.Location = new Point(77, 323);
            ConfirmAppointBtn.Name = "ConfirmAppointBtn";
            ConfirmAppointBtn.Size = new Size(186, 35);
            ConfirmAppointBtn.TabIndex = 24;
            ConfirmAppointBtn.Text = "Authenticate verification";
            ConfirmAppointBtn.UseVisualStyleBackColor = false;
            ConfirmAppointBtn.Click += ConfirmAppointBtn_Click;
            // 
            // TableNoCB
            // 
            TableNoCB.BackColor = SystemColors.Info;
            TableNoCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableNoCB.FormattingEnabled = true;
            TableNoCB.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            TableNoCB.Location = new Point(188, 269);
            TableNoCB.Name = "TableNoCB";
            TableNoCB.Size = new Size(75, 28);
            TableNoCB.TabIndex = 23;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 272);
            label7.Name = "label7";
            label7.Size = new Size(157, 27);
            label7.TabIndex = 22;
            label7.Text = "Select reservation table";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(233, 214);
            label6.Name = "label6";
            label6.Size = new Size(39, 27);
            label6.TabIndex = 21;
            label6.Text = "pm";
            // 
            // EndTimeTF
            // 
            EndTimeTF.BackColor = Color.Cornsilk;
            EndTimeTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EndTimeTF.Location = new Point(188, 211);
            EndTimeTF.Multiline = true;
            EndTimeTF.Name = "EndTimeTF";
            EndTimeTF.Size = new Size(39, 35);
            EndTimeTF.TabIndex = 20;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 219);
            label5.Name = "label5";
            label5.Size = new Size(168, 27);
            label5.TabIndex = 19;
            label5.Text = "Reservation ending time";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 170);
            label4.Name = "label4";
            label4.Size = new Size(39, 27);
            label4.TabIndex = 18;
            label4.Text = "pm";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 173);
            label3.Name = "label3";
            label3.Size = new Size(168, 27);
            label3.TabIndex = 17;
            label3.Text = "Reservation starting time";
            // 
            // LoaadResBtn
            // 
            LoaadResBtn.BackColor = SystemColors.Info;
            LoaadResBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoaadResBtn.Location = new Point(214, 81);
            LoaadResBtn.Name = "LoaadResBtn";
            LoaadResBtn.Size = new Size(70, 35);
            LoaadResBtn.TabIndex = 16;
            LoaadResBtn.Text = "Load ";
            LoaadResBtn.UseVisualStyleBackColor = false;
            LoaadResBtn.Click += LoaadResBtn_Click;
            // 
            // PendingResCB
            // 
            PendingResCB.BackColor = SystemColors.Info;
            PendingResCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PendingResCB.FormattingEnabled = true;
            PendingResCB.Location = new Point(14, 85);
            PendingResCB.Name = "PendingResCB";
            PendingResCB.Size = new Size(194, 28);
            PendingResCB.TabIndex = 13;
            PendingResCB.SelectedIndexChanged += PendingResCB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 11);
            label2.Name = "label2";
            label2.Size = new Size(299, 71);
            label2.TabIndex = 12;
            label2.Text = "Select pending reservations from the drop down menu \r\n(Click 'Load' to see pending reservations)\r\n";
            // 
            // StartTimeTF
            // 
            StartTimeTF.BackColor = Color.Cornsilk;
            StartTimeTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartTimeTF.Location = new Point(188, 170);
            StartTimeTF.Multiline = true;
            StartTimeTF.Name = "StartTimeTF";
            StartTimeTF.Size = new Size(39, 35);
            StartTimeTF.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(UpdateMenuBtn);
            panel2.Controls.Add(UpdateUsersBtn);
            panel2.Location = new Point(12, 564);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 137);
            panel2.TabIndex = 19;
            // 
            // UpdateMenuBtn
            // 
            UpdateMenuBtn.BackColor = SystemColors.Info;
            UpdateMenuBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateMenuBtn.Location = new Point(57, 75);
            UpdateMenuBtn.Name = "UpdateMenuBtn";
            UpdateMenuBtn.Size = new Size(131, 35);
            UpdateMenuBtn.TabIndex = 18;
            UpdateMenuBtn.Text = "Update Menu";
            UpdateMenuBtn.UseVisualStyleBackColor = false;
            // 
            // UpdateFoodItemPanel
            // 
            UpdateFoodItemPanel.BackColor = Color.LightGoldenrodYellow;
            UpdateFoodItemPanel.Controls.Add(UpMenuBtnInPAnel);
            UpdateFoodItemPanel.Controls.Add(ItemDesTF);
            UpdateFoodItemPanel.Controls.Add(ItemPriceTF);
            UpdateFoodItemPanel.Controls.Add(ItemNameTF);
            UpdateFoodItemPanel.Location = new Point(897, 519);
            UpdateFoodItemPanel.Name = "UpdateFoodItemPanel";
            UpdateFoodItemPanel.Size = new Size(251, 341);
            UpdateFoodItemPanel.TabIndex = 20;
            // 
            // UpMenuBtnInPAnel
            // 
            UpMenuBtnInPAnel.BackColor = SystemColors.Info;
            UpMenuBtnInPAnel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpMenuBtnInPAnel.Location = new Point(69, 217);
            UpMenuBtnInPAnel.Name = "UpMenuBtnInPAnel";
            UpMenuBtnInPAnel.Size = new Size(119, 35);
            UpMenuBtnInPAnel.TabIndex = 15;
            UpMenuBtnInPAnel.Text = "Update Menu";
            UpMenuBtnInPAnel.UseVisualStyleBackColor = false;
            // 
            // ItemDesTF
            // 
            ItemDesTF.BackColor = Color.Cornsilk;
            ItemDesTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemDesTF.Location = new Point(27, 140);
            ItemDesTF.Multiline = true;
            ItemDesTF.Name = "ItemDesTF";
            ItemDesTF.PlaceholderText = "ItemDescription";
            ItemDesTF.Size = new Size(194, 51);
            ItemDesTF.TabIndex = 13;
            // 
            // ItemPriceTF
            // 
            ItemPriceTF.BackColor = Color.Cornsilk;
            ItemPriceTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemPriceTF.Location = new Point(27, 88);
            ItemPriceTF.Multiline = true;
            ItemPriceTF.Name = "ItemPriceTF";
            ItemPriceTF.PlaceholderText = "Item Price";
            ItemPriceTF.Size = new Size(194, 35);
            ItemPriceTF.TabIndex = 9;
            // 
            // ItemNameTF
            // 
            ItemNameTF.BackColor = Color.Cornsilk;
            ItemNameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ItemNameTF.Location = new Point(27, 37);
            ItemNameTF.Multiline = true;
            ItemNameTF.Name = "ItemNameTF";
            ItemNameTF.PlaceholderText = "ItemName";
            ItemNameTF.Size = new Size(194, 35);
            ItemNameTF.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(DltUserBtn);
            panel3.Controls.Add(DltAdminBtn);
            panel3.Location = new Point(12, 707);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 137);
            panel3.TabIndex = 21;
            // 
            // DltUserBtn
            // 
            DltUserBtn.BackColor = SystemColors.Info;
            DltUserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DltUserBtn.Location = new Point(57, 75);
            DltUserBtn.Name = "DltUserBtn";
            DltUserBtn.Size = new Size(131, 35);
            DltUserBtn.TabIndex = 18;
            DltUserBtn.Text = "Delete User";
            DltUserBtn.UseVisualStyleBackColor = false;
            DltUserBtn.Click += DltUserBtn_Click;
            // 
            // DltAdminBtn
            // 
            DltAdminBtn.BackColor = SystemColors.Info;
            DltAdminBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DltAdminBtn.Location = new Point(57, 22);
            DltAdminBtn.Name = "DltAdminBtn";
            DltAdminBtn.Size = new Size(131, 35);
            DltAdminBtn.TabIndex = 17;
            DltAdminBtn.Text = "Delete Admin";
            DltAdminBtn.UseVisualStyleBackColor = false;
            DltAdminBtn.Click += DltAdminBtn_Click;
            // 
            // DltAdTF
            // 
            DltAdTF.BackColor = Color.Cornsilk;
            DltAdTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DltAdTF.Location = new Point(21, 54);
            DltAdTF.Multiline = true;
            DltAdTF.Name = "DltAdTF";
            DltAdTF.PlaceholderText = "Admin ID";
            DltAdTF.Size = new Size(194, 35);
            DltAdTF.TabIndex = 6;
            // 
            // DltAdBtn
            // 
            DltAdBtn.BackColor = SystemColors.Info;
            DltAdBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DltAdBtn.Location = new Point(55, 110);
            DltAdBtn.Name = "DltAdBtn";
            DltAdBtn.Size = new Size(119, 35);
            DltAdBtn.TabIndex = 15;
            DltAdBtn.Text = "Delete Admin";
            DltAdBtn.UseVisualStyleBackColor = false;
            DltAdBtn.Click += DltAdBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 21);
            label9.Name = "label9";
            label9.Size = new Size(226, 20);
            label9.TabIndex = 16;
            label9.Text = "Enter Admin ID ot delete an admin";
            // 
            // DeleteAdPanel
            // 
            DeleteAdPanel.BackColor = Color.LightGoldenrodYellow;
            DeleteAdPanel.Controls.Add(label9);
            DeleteAdPanel.Controls.Add(DltAdBtn);
            DeleteAdPanel.Controls.Add(DltAdTF);
            DeleteAdPanel.Location = new Point(1166, 519);
            DeleteAdPanel.Name = "DeleteAdPanel";
            DeleteAdPanel.Size = new Size(251, 170);
            DeleteAdPanel.TabIndex = 22;
            // 
            // DeleteUserPanel
            // 
            DeleteUserPanel.BackColor = Color.LightGoldenrodYellow;
            DeleteUserPanel.Controls.Add(label10);
            DeleteUserPanel.Controls.Add(DeleteUserBtn);
            DeleteUserPanel.Controls.Add(DltUserTF);
            DeleteUserPanel.Location = new Point(1166, 695);
            DeleteUserPanel.Name = "DeleteUserPanel";
            DeleteUserPanel.Size = new Size(251, 170);
            DeleteUserPanel.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 21);
            label10.Name = "label10";
            label10.Size = new Size(213, 20);
            label10.TabIndex = 16;
            label10.Text = "Enter User ID ot delete an admin";
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.BackColor = SystemColors.Info;
            DeleteUserBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteUserBtn.Location = new Point(55, 110);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(119, 35);
            DeleteUserBtn.TabIndex = 15;
            DeleteUserBtn.Text = "Delete User";
            DeleteUserBtn.UseVisualStyleBackColor = false;
            DeleteUserBtn.Click += DeleteUserBtn_Click;
            // 
            // DltUserTF
            // 
            DltUserTF.BackColor = Color.Cornsilk;
            DltUserTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DltUserTF.Location = new Point(21, 54);
            DltUserTF.Multiline = true;
            DltUserTF.Name = "DltUserTF";
            DltUserTF.PlaceholderText = "User ID";
            DltUserTF.Size = new Size(194, 35);
            DltUserTF.TabIndex = 6;
            // 
            // ShowUserBankRelatedBtn
            // 
            ShowUserBankRelatedBtn.BackColor = SystemColors.Info;
            ShowUserBankRelatedBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowUserBankRelatedBtn.Location = new Point(57, 399);
            ShowUserBankRelatedBtn.Name = "ShowUserBankRelatedBtn";
            ShowUserBankRelatedBtn.Size = new Size(131, 49);
            ShowUserBankRelatedBtn.TabIndex = 24;
            ShowUserBankRelatedBtn.Text = "Show UserBank info";
            ShowUserBankRelatedBtn.UseVisualStyleBackColor = false;
            ShowUserBankRelatedBtn.Click += ShowUserBankRelatedBtn_Click;
            // 
            // AdminFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1557, 900);
            Controls.Add(DeleteUserPanel);
            Controls.Add(DeleteAdPanel);
            Controls.Add(panel3);
            Controls.Add(UpdateFoodItemPanel);
            Controls.Add(panel2);
            Controls.Add(ManageReservationsPanel);
            Controls.Add(ReturnBtn);
            Controls.Add(AddAdminPanel);
            Controls.Add(UpdateUserPanel);
            Controls.Add(UserActivationPanel);
            Controls.Add(panel1);
            Controls.Add(ShowTablesDGV);
            Name = "AdminFunctions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminFunctions";
            ((System.ComponentModel.ISupportInitialize)ShowTablesDGV).EndInit();
            panel1.ResumeLayout(false);
            UserActivationPanel.ResumeLayout(false);
            UserActivationPanel.PerformLayout();
            UpdateUserPanel.ResumeLayout(false);
            UpdateUserPanel.PerformLayout();
            AddAdminPanel.ResumeLayout(false);
            AddAdminPanel.PerformLayout();
            ManageReservationsPanel.ResumeLayout(false);
            ManageReservationsPanel.PerformLayout();
            panel2.ResumeLayout(false);
            UpdateFoodItemPanel.ResumeLayout(false);
            UpdateFoodItemPanel.PerformLayout();
            panel3.ResumeLayout(false);
            DeleteAdPanel.ResumeLayout(false);
            DeleteAdPanel.PerformLayout();
            DeleteUserPanel.ResumeLayout(false);
            DeleteUserPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView ShowTablesDGV;
        private Panel panel1;
        private Button ActivateuserBtn;
        private Button ShowUsersBtn;
        private Panel UserActivationPanel;
        private ComboBox AllUsersCB;
        private Label label1;
        private Button ShowAdminsBtn;
        private Button LoadUsersBtn;
        private Button UpdateUsersBtn;
        private Panel UpdateUserPanel;
        private TextBox UpNameTF;
        private TextBox UpMnoTF;
        private ComboBox UpCityCB;
        private TextBox UpLocTF;
        private Button UpdateUserBtn;
        private Button ShowLogInTableBtn;
        private Button ActivateBtn;
        private Button AddAdmin;
        private Panel AddAdminPanel;
        private TextBox AddAdminPassTF;
        private TextBox AddAdminnameTF;
        private Button AddAdminBtn;
        private ComboBox AdRoleCB;
        private TextBox AddAdminWorkFieldTF;
        private Button ReturnBtn;
        private Button ManageReserBtn;
        private Panel ManageReservationsPanel;
        private Label label2;
        private TextBox StartTimeTF;
        private Button LoaadResBtn;
        private ComboBox PendingResCB;
        private ComboBox TableNoCB;
        private Label label7;
        private Label label6;
        private TextBox EndTimeTF;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button ConfirmAppointBtn;
        private Label label8;
        private TextBox ResDateTF;
        private Button DisplayMenuBtn;
        private Button ShowPaymentBtn;
        private Button ShowResBtn;
        private Panel panel2;
        private Button UpdateMenuBtn;
        private Panel UpdateFoodItemPanel;
        private Button UpMenuBtnInPAnel;
        private TextBox ItemDesTF;
        private TextBox ItemPriceTF;
        private TextBox ItemNameTF;
        private Panel panel3;
        private Button DltUserBtn;
        private Button DltAdminBtn;
        private TextBox DltAdTF;
        private Button DltAdBtn;
        private Label label9;
        private Panel DeleteAdPanel;
        private Panel DeleteUserPanel;
        private Label label10;
        private Button DeleteUserBtn;
        private TextBox DltUserTF;
        private Button ShowUserBankRelatedBtn;
    }
}