namespace Assignment_4._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginbutton = new Button();
            AddStudentButton = new Button();
            exitbutton = new Button();
            SuspendLayout();
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(644, 12);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(112, 34);
            loginbutton.TabIndex = 4;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(12, 12);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(164, 34);
            AddStudentButton.TabIndex = 5;
            AddStudentButton.Text = "Add Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(509, 302);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(210, 121);
            exitbutton.TabIndex = 6;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitbutton);
            Controls.Add(AddStudentButton);
            Controls.Add(loginbutton);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion
        private Button loginbutton;
        private Button AddStudentButton;
        private Button exitbutton;
    }
}
