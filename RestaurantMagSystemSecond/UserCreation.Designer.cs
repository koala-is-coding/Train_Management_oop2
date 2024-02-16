namespace RestaurantMagSystemSecond
{
    partial class UserCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreation));
            panel1 = new Panel();
            UNameTF = new TextBox();
            label1 = new Label();
            UPassTF = new TextBox();
            UMnoTF = new TextBox();
            UCityCB = new ComboBox();
            RoleCB = new ComboBox();
            UStatusCB = new ComboBox();
            ULocTF = new TextBox();
            SignUpBtn = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 561);
            panel1.TabIndex = 0;
            // 
            // UNameTF
            // 
            UNameTF.BackColor = Color.Cornsilk;
            UNameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UNameTF.Location = new Point(399, 89);
            UNameTF.Multiline = true;
            UNameTF.Name = "UNameTF";
            UNameTF.PlaceholderText = "Username";
            UNameTF.Size = new Size(194, 35);
            UNameTF.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 40);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 6;
            label1.Text = "Please fill out all the information correctly";
            // 
            // UPassTF
            // 
            UPassTF.BackColor = Color.Cornsilk;
            UPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UPassTF.Location = new Point(399, 150);
            UPassTF.Multiline = true;
            UPassTF.Name = "UPassTF";
            UPassTF.PlaceholderText = "password";
            UPassTF.Size = new Size(194, 35);
            UPassTF.TabIndex = 7;
            // 
            // UMnoTF
            // 
            UMnoTF.BackColor = Color.Cornsilk;
            UMnoTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UMnoTF.Location = new Point(399, 213);
            UMnoTF.Multiline = true;
            UMnoTF.Name = "UMnoTF";
            UMnoTF.PlaceholderText = "Mobile number";
            UMnoTF.Size = new Size(194, 35);
            UMnoTF.TabIndex = 8;
            // 
            // UCityCB
            // 
            UCityCB.BackColor = SystemColors.Info;
            UCityCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UCityCB.FormattingEnabled = true;
            UCityCB.Items.AddRange(new object[] { "Dhaka", "Rajshahi", "Chittagong", "Gazipur", "Narayanganj", "Sylhet", "Bogura" });
            UCityCB.Location = new Point(399, 278);
            UCityCB.Name = "UCityCB";
            UCityCB.Size = new Size(194, 28);
            UCityCB.TabIndex = 9;
            UCityCB.Text = "City";
            // 
            // RoleCB
            // 
            RoleCB.BackColor = SystemColors.Info;
            RoleCB.Enabled = false;
            RoleCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCB.FormattingEnabled = true;
            RoleCB.Items.AddRange(new object[] { "User", "Admin", "Driver" });
            RoleCB.Location = new Point(399, 333);
            RoleCB.Name = "RoleCB";
            RoleCB.Size = new Size(194, 28);
            RoleCB.TabIndex = 10;
            RoleCB.Text = "User";
            // 
            // UStatusCB
            // 
            UStatusCB.BackColor = SystemColors.Info;
            UStatusCB.Enabled = false;
            UStatusCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UStatusCB.FormattingEnabled = true;
            UStatusCB.Items.AddRange(new object[] { "Actived", "Deactivated" });
            UStatusCB.Location = new Point(399, 384);
            UStatusCB.Name = "UStatusCB";
            UStatusCB.Size = new Size(194, 28);
            UStatusCB.TabIndex = 11;
            UStatusCB.Text = "Deactivated";
            // 
            // ULocTF
            // 
            ULocTF.BackColor = Color.Cornsilk;
            ULocTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ULocTF.Location = new Point(399, 433);
            ULocTF.Multiline = true;
            ULocTF.Name = "ULocTF";
            ULocTF.PlaceholderText = "Location";
            ULocTF.Size = new Size(194, 51);
            ULocTF.TabIndex = 12;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = SystemColors.Info;
            SignUpBtn.Location = new Point(450, 503);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(88, 32);
            SignUpBtn.TabIndex = 13;
            SignUpBtn.Text = "SignUp";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 166);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 15;
            label2.Text = "User Creation Tab";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Location = new Point(680, 28);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(88, 32);
            ReturnBtn.TabIndex = 16;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // UserCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 559);
            Controls.Add(ReturnBtn);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(SignUpBtn);
            Controls.Add(ULocTF);
            Controls.Add(UStatusCB);
            Controls.Add(RoleCB);
            Controls.Add(UCityCB);
            Controls.Add(UMnoTF);
            Controls.Add(UPassTF);
            Controls.Add(label1);
            Controls.Add(UNameTF);
            Controls.Add(panel1);
            Name = "UserCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserCreation";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox UNameTF;
        private Label label1;
        private TextBox UPassTF;
        private TextBox UMnoTF;
        private ComboBox UCityCB;
        private ComboBox RoleCB;
        private ComboBox UStatusCB;
        private TextBox ULocTF;
        private Button SignUpBtn;
        private PictureBox pictureBox1;
        private Label label2;
        private Button ReturnBtn;
    }
}