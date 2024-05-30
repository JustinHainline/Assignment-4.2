namespace Assignment_4._2
{
    partial class Form2
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
            passwordtextbox = new TextBox();
            userIdtextbox = new TextBox();
            password = new Label();
            userId = new Label();
            LogonBtn = new Button();
            SuspendLayout();
            // 
            // passwordtextbox
            // 
            passwordtextbox.Location = new Point(357, 161);
            passwordtextbox.Name = "passwordtextbox";
            passwordtextbox.Size = new Size(150, 31);
            passwordtextbox.TabIndex = 7;
            // 
            // userIdtextbox
            // 
            userIdtextbox.Location = new Point(357, 109);
            userIdtextbox.Name = "userIdtextbox";
            userIdtextbox.Size = new Size(150, 31);
            userIdtextbox.TabIndex = 6;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(224, 161);
            password.Name = "password";
            password.Size = new Size(87, 25);
            password.TabIndex = 5;
            password.Text = "Password";
            // 
            // userId
            // 
            userId.AutoSize = true;
            userId.Location = new Point(243, 106);
            userId.Name = "userId";
            userId.Size = new Size(68, 25);
            userId.TabIndex = 4;
            userId.Text = "User Id";
            // 
            // LogonBtn
            // 
            LogonBtn.Location = new Point(322, 244);
            LogonBtn.Name = "LogonBtn";
            LogonBtn.Size = new Size(112, 34);
            LogonBtn.TabIndex = 8;
            LogonBtn.Text = "Logon";
            LogonBtn.UseVisualStyleBackColor = true;
            LogonBtn.Click += LogonBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogonBtn);
            Controls.Add(passwordtextbox);
            Controls.Add(userIdtextbox);
            Controls.Add(password);
            Controls.Add(userId);
            Name = "Form2";
            Text = "Student Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordtextbox;
        private TextBox userIdtextbox;
        private Label password;
        private Label userId;
        private Button LogonBtn;
    }
}