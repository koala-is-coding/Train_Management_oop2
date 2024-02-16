namespace RestaurantMagSystemSecond
{
    partial class UserBankRelatedInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBankRelatedInfoForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            UIdlabel = new Label();
            NewBankBtn = new Button();
            UpdateBankBtn = new Button();
            CreateBankPanel = new Panel();
            CreateBtn = new Button();
            AvailBalanceTF = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            BankPassTF = new TextBox();
            PaymentMethodCB = new ComboBox();
            BankUidTF = new TextBox();
            label3 = new Label();
            AddamountPanel = new Panel();
            UpdateBalBtn = new Button();
            AddAmountTF = new TextBox();
            label7 = new Label();
            label11 = new Label();
            BalanceLabel = new Label();
            ReturnBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CreateBankPanel.SuspendLayout();
            AddamountPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 756);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(188, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 169);
            label2.Name = "label2";
            label2.Size = new Size(175, 19);
            label2.TabIndex = 20;
            label2.Text = "User Bank related Tab";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 331);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 22;
            label1.Text = "User ID :";
            // 
            // UIdlabel
            // 
            UIdlabel.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            UIdlabel.Location = new Point(249, 331);
            UIdlabel.Name = "UIdlabel";
            UIdlabel.Size = new Size(68, 31);
            UIdlabel.TabIndex = 23;
            UIdlabel.Text = "(UserID)";
            UIdlabel.Click += UIdlabel_Click;
            // 
            // NewBankBtn
            // 
            NewBankBtn.BackColor = SystemColors.Info;
            NewBankBtn.Location = new Point(164, 201);
            NewBankBtn.Name = "NewBankBtn";
            NewBankBtn.Size = new Size(88, 44);
            NewBankBtn.TabIndex = 24;
            NewBankBtn.Text = "Create New Bank Profile";
            NewBankBtn.UseVisualStyleBackColor = false;
            NewBankBtn.Click += NewBankBtn_Click;
            // 
            // UpdateBankBtn
            // 
            UpdateBankBtn.BackColor = SystemColors.Info;
            UpdateBankBtn.Location = new Point(164, 265);
            UpdateBankBtn.Name = "UpdateBankBtn";
            UpdateBankBtn.Size = new Size(88, 47);
            UpdateBankBtn.TabIndex = 25;
            UpdateBankBtn.Text = "Update Bank Statements";
            UpdateBankBtn.UseVisualStyleBackColor = false;
            UpdateBankBtn.Click += UpdateBankBtn_Click;
            // 
            // CreateBankPanel
            // 
            CreateBankPanel.BackColor = Color.CadetBlue;
            CreateBankPanel.Controls.Add(CreateBtn);
            CreateBankPanel.Controls.Add(AvailBalanceTF);
            CreateBankPanel.Controls.Add(label6);
            CreateBankPanel.Controls.Add(label5);
            CreateBankPanel.Controls.Add(label4);
            CreateBankPanel.Controls.Add(BankPassTF);
            CreateBankPanel.Controls.Add(PaymentMethodCB);
            CreateBankPanel.Controls.Add(BankUidTF);
            CreateBankPanel.Controls.Add(label3);
            CreateBankPanel.Location = new Point(380, 180);
            CreateBankPanel.Name = "CreateBankPanel";
            CreateBankPanel.Size = new Size(370, 314);
            CreateBankPanel.TabIndex = 26;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = SystemColors.Info;
            CreateBtn.Location = new Point(128, 241);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(103, 35);
            CreateBtn.TabIndex = 31;
            CreateBtn.Text = "Add Info";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // AvailBalanceTF
            // 
            AvailBalanceTF.BackColor = Color.Cornsilk;
            AvailBalanceTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailBalanceTF.Location = new Point(240, 201);
            AvailBalanceTF.Multiline = true;
            AvailBalanceTF.Name = "AvailBalanceTF";
            AvailBalanceTF.Size = new Size(112, 29);
            AvailBalanceTF.TabIndex = 30;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 185);
            label6.Name = "label6";
            label6.Size = new Size(254, 53);
            label6.TabIndex = 29;
            label6.Text = "Enter an amount. Amount will be deducted when you confirm an order";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 71);
            label5.Name = "label5";
            label5.Size = new Size(149, 52);
            label5.TabIndex = 28;
            label5.Text = "Enter your Payment method(Bkash/Nagad)";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 136);
            label4.Name = "label4";
            label4.Size = new Size(231, 31);
            label4.TabIndex = 27;
            label4.Text = "Enter your bank account password";
            // 
            // BankPassTF
            // 
            BankPassTF.BackColor = Color.Cornsilk;
            BankPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BankPassTF.Location = new Point(230, 138);
            BankPassTF.Multiline = true;
            BankPassTF.Name = "BankPassTF";
            BankPassTF.Size = new Size(112, 29);
            BankPassTF.TabIndex = 26;
            // 
            // PaymentMethodCB
            // 
            PaymentMethodCB.BackColor = SystemColors.Info;
            PaymentMethodCB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PaymentMethodCB.FormattingEnabled = true;
            PaymentMethodCB.Items.AddRange(new object[] { "Bkash", "Nagad" });
            PaymentMethodCB.Location = new Point(148, 83);
            PaymentMethodCB.Name = "PaymentMethodCB";
            PaymentMethodCB.Size = new Size(194, 28);
            PaymentMethodCB.TabIndex = 25;
            PaymentMethodCB.Text = "Payment method";
            // 
            // BankUidTF
            // 
            BankUidTF.BackColor = Color.Cornsilk;
            BankUidTF.Enabled = false;
            BankUidTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BankUidTF.Location = new Point(230, 32);
            BankUidTF.Multiline = true;
            BankUidTF.Name = "BankUidTF";
            BankUidTF.Size = new Size(112, 27);
            BankUidTF.TabIndex = 24;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(148, 32);
            label3.Name = "label3";
            label3.Size = new Size(68, 31);
            label3.TabIndex = 23;
            label3.Text = "User ID :";
            // 
            // AddamountPanel
            // 
            AddamountPanel.BackColor = Color.CornflowerBlue;
            AddamountPanel.Controls.Add(UpdateBalBtn);
            AddamountPanel.Controls.Add(AddAmountTF);
            AddamountPanel.Controls.Add(label7);
            AddamountPanel.Location = new Point(380, 12);
            AddamountPanel.Name = "AddamountPanel";
            AddamountPanel.Size = new Size(370, 151);
            AddamountPanel.TabIndex = 28;
            // 
            // UpdateBalBtn
            // 
            UpdateBalBtn.BackColor = SystemColors.Info;
            UpdateBalBtn.Location = new Point(128, 85);
            UpdateBalBtn.Name = "UpdateBalBtn";
            UpdateBalBtn.Size = new Size(103, 35);
            UpdateBalBtn.TabIndex = 32;
            UpdateBalBtn.Text = "Update Balance";
            UpdateBalBtn.UseVisualStyleBackColor = false;
            UpdateBalBtn.Click += UpdateBalBtn_Click;
            // 
            // AddAmountTF
            // 
            AddAmountTF.BackColor = Color.Cornsilk;
            AddAmountTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddAmountTF.Location = new Point(207, 37);
            AddAmountTF.Multiline = true;
            AddAmountTF.Name = "AddAmountTF";
            AddAmountTF.Size = new Size(112, 32);
            AddAmountTF.TabIndex = 31;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 18);
            label7.Name = "label7";
            label7.Size = new Size(179, 64);
            label7.TabIndex = 30;
            label7.Text = "Enter an amount you want to add to your existing balance";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(164, 368);
            label11.Name = "label11";
            label11.Size = new Size(124, 31);
            label11.TabIndex = 29;
            label11.Text = "Available Balance :";
            // 
            // BalanceLabel
            // 
            BalanceLabel.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BalanceLabel.Location = new Point(283, 368);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(91, 45);
            BalanceLabel.TabIndex = 30;
            BalanceLabel.Text = "(AvailableBalance)";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Location = new Point(260, 12);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(103, 35);
            ReturnBtn.TabIndex = 32;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // UserBankRelatedInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(781, 758);
            Controls.Add(ReturnBtn);
            Controls.Add(BalanceLabel);
            Controls.Add(label11);
            Controls.Add(AddamountPanel);
            Controls.Add(CreateBankPanel);
            Controls.Add(UpdateBankBtn);
            Controls.Add(NewBankBtn);
            Controls.Add(UIdlabel);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "UserBankRelatedInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserBankRelatedInfoForm";
            Load += UserBankRelatedInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CreateBankPanel.ResumeLayout(false);
            CreateBankPanel.PerformLayout();
            AddamountPanel.ResumeLayout(false);
            AddamountPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label UIdlabel;
        private Button NewBankBtn;
        private Button UpdateBankBtn;
        private Panel CreateBankPanel;
        private Label label3;
        private TextBox BankUidTF;
        private Label label5;
        private Label label4;
        private TextBox BankPassTF;
        private ComboBox PaymentMethodCB;
        private Button CreateBtn;
        private TextBox AvailBalanceTF;
        private Label label6;
        private Panel AddamountPanel;
        private Button UpdateBalBtn;
        private TextBox AddAmountTF;
        private Label label7;
        private Label label11;
        private Label BalanceLabel;
        private Button ReturnBtn;
    }
}