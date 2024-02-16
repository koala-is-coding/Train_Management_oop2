namespace RestaurantMagSystemSecond
{
    partial class PassManagement
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
            label1 = new Label();
            NameTF = new TextBox();
            EnterBtn = new Button();
            ConfirmBtn = new Button();
            NewpassTF = new TextBox();
            label2 = new Label();
            ReturnBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 55);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 4;
            label1.Text = "Please enter your registered name ";
            // 
            // NameTF
            // 
            NameTF.BackColor = Color.Cornsilk;
            NameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTF.Location = new Point(360, 52);
            NameTF.Multiline = true;
            NameTF.Name = "NameTF";
            NameTF.PlaceholderText = " Name";
            NameTF.Size = new Size(194, 36);
            NameTF.TabIndex = 5;
            // 
            // EnterBtn
            // 
            EnterBtn.BackColor = SystemColors.Info;
            EnterBtn.Location = new Point(405, 108);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(88, 32);
            EnterBtn.TabIndex = 6;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = SystemColors.Info;
            ConfirmBtn.Location = new Point(405, 265);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(88, 32);
            ConfirmBtn.TabIndex = 7;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // NewpassTF
            // 
            NewpassTF.BackColor = Color.Cornsilk;
            NewpassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewpassTF.Location = new Point(360, 198);
            NewpassTF.Multiline = true;
            NewpassTF.Name = "NewpassTF";
            NewpassTF.PasswordChar = '*';
            NewpassTF.PlaceholderText = "password";
            NewpassTF.Size = new Size(194, 36);
            NewpassTF.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 201);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 9;
            label2.Text = "Please enter your new password";
            // 
            // ReturnBtn
            // 
            ReturnBtn.BackColor = SystemColors.Info;
            ReturnBtn.Location = new Point(685, 28);
            ReturnBtn.Name = "ReturnBtn";
            ReturnBtn.Size = new Size(88, 32);
            ReturnBtn.TabIndex = 10;
            ReturnBtn.Text = "Return";
            ReturnBtn.UseVisualStyleBackColor = false;
            ReturnBtn.Click += ReturnBtn_Click;
            // 
            // PassManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnBtn);
            Controls.Add(label2);
            Controls.Add(NewpassTF);
            Controls.Add(ConfirmBtn);
            Controls.Add(EnterBtn);
            Controls.Add(NameTF);
            Controls.Add(label1);
            Name = "PassManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PassManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTF;
        private Button EnterBtn;
        private Button ConfirmBtn;
        private TextBox NewpassTF;
        private Label label2;
        private Button ReturnBtn;
    }
}